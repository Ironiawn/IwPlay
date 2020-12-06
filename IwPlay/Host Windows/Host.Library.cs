using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Linq;
using System.Text;
using System.Net;
using System.Windows.Forms;
using System.Text.Json.Serialization;
using System.Text.Json;
using DBCS = IwPlay.Systems.IwP_Main_Database.Connection;
using DBCG = IwPlay.Systems.IwP_Main_Database.UserInfo;
using DBDB = IwPlay.Systems.IwP_Main_Database.DevInfo;

namespace IwPlay.Hosts
{
    public partial class HostLibrary : UserControl
    {
        public HostLibrary()
        {
            InitializeComponent();
        }

        // Janelas de HostSelf dos jogos
        HostSelf[] GameHandler;

        /// <summary>
        /// Filtro de jogos
        /// </summary>
        string ApplyFilterIndex = null;

        /// <summary>
        /// Background worker
        /// </summary>
        BackgroundWorker LibraryWorker = new BackgroundWorker();

        private void Host_Load(object sender, EventArgs e)
        {
            // Adquirir todos os jogos da IwPlay
            GameHandler = new HostSelf[DBCS.Games.Count];

            // Iniciar trabalhos do Background Worker
            LibraryWorker.DoWork += LibraryWorker_DoWork;
            LibraryWorker.RunWorkerCompleted += LibraryWorker_RunWorkerCompleted;
            LibraryWorker.RunWorkerAsync();

            // Desabilitar visualização do Flow
            Flow.Visible = false;

            // Desabilitar filtro
            Filter.Enabled = false;
        }

        private void LibraryWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < GameHandler.Length; i++)
            {
                // Usuário é um dos desenvolvedores do jogo?
                bool IsDev = false;

                // Percorrer nomes de desenvolvedor do usuário
                foreach(DBDB._DeveloperInfo di in DBDB.DeveloperInfo)
                {
                    // Se uma das empresas do jogo for uma das cadastradas no usuário
                    // informar que é um dos desenvolvedores
                    if (DBCS.Games[i].Developer.ToLower() == di.DeveloperName.ToLower())
                        IsDev = true;
                }

                // Verificar se o jogo foi aprovado para ser exibido na loja
                if (bool.Parse(DBCS.Games[i].ApprovedGame) == true || IsDev)
                {
                    GameHandler[i] = new HostSelf();
                    GameHandler[i].GameName.Text = DBCS.Games[i].Name;
                    GameHandler[i].Developer.Text = DBCS.Games[i].Developer;
                    GameHandler[i].GameDescription = DBCS.Games[i].Description;
                    GameHandler[i].GameCode = DBCS.Games[i].ID;
                    GameHandler[i].GamePrice = DBCS.Games[i].Price == "0" ? "FREE" : DBCS.Games[i].Price;
                    GameHandler[i].BoxShot = DBCS.Games[i].Image;
                    GameHandler[i].GameBuyLink = DBCS.Games[i].GameBuyLink;
                    GameHandler[i].HasGame = DBCG.HasGame(DBCS.Games[i].ID);
                    GameHandler[i].Approved = bool.Parse(DBCS.Games[i].ApprovedGame);
                    GameHandler[i].IsTheDev = IsDev;

                    // Verifica se o desenvolvedor é verificado
                    string VerifyDev = DBDB.DeveloperInfoWeb(DBCS.Games[i].Developer).Verified;
                    if (VerifyDev != null && VerifyDev.Length >= 4)
                        GameHandler[i].DevVerified = bool.Parse(VerifyDev);
                    else
                        GameHandler[i].DevVerified = false;
                }
            }
        }

        private void LibraryWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Desabilitar label e gif de carregamento
            lbLoading.Visible = false;
            lbLoading.Enabled = false;
            pbLoading.Visible = false;
            pbLoading.Enabled = false;

            foreach (HostSelf s in GameHandler)
            {
                // Verifica os filtros
                if(ApplyFilterIndex == null) // Nenhum filtro aplicado
                    // Adicionar controle ao Flow
                    Flow.Controls.Add(s);
                else
                    if(ApplyFilterIndex == "ITEMS THAT I BOUGHT") // Somente itens que o jogador possui
                {
                    if (s.HasGame)
                    {
                        // Adicionar controle ao Flow
                        Flow.Controls.Add(s);
                    }
                }else
                    if(ApplyFilterIndex == "MY PUBLISHED ITEMS")
                {
                    if (s.IsTheDev && s.Approved)
                    {
                        // Adicionar controle ao Flow
                        Flow.Controls.Add(s);
                    }
                }else
                    if(ApplyFilterIndex == "ITEMS THAT IS PENDING APPROVAL")
                {
                    if (s.IsTheDev && !s.Approved)
                    {
                        // Adicionar controle ao Flow
                        Flow.Controls.Add(s);
                    }
                }
                else
                    if(ApplyFilterIndex == "ALL MY DEV. ITEMS")
                {
                    if (s.IsTheDev)
                    {
                        // Adicionar controle ao Flow
                        Flow.Controls.Add(s);
                    }
                }
            }

            // Habilitar filtro
            Filter.Enabled = true;

            // Habilitar visualização do Flow
            Flow.Visible = true;
        }

        private void Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Dispose e remoção de todos os itens da lista
            foreach(Control c in Flow.Controls)
            {
                c.Dispose();
                Flow.Controls.Remove(c);
            }

            // Dispose em todos os game handlers
            //foreach (HostSelf hs in GameHandler) { hs.Dispose(); }
            //GameHandler = null;

            // Mudar filtro
            if(Filter.GetItemText(Filter.SelectedItem) == "ALL GAMES")
            {
                // Nenhum filtro selecionado
                ApplyFilterIndex = null;

                // Forçar atualização de jogos da Store
                DBCS._Games = null;
            }
            else
            {
                // Aplicar filtros
                ApplyFilterIndex = Filter.GetItemText(Filter.SelectedItem);
            }

            // Fazer o background worker trabalhar
            LibraryWorker.RunWorkerAsync();

            // Habilitar label e gif de carregamento
            lbLoading.Visible = true;
            lbLoading.Enabled = true;
            pbLoading.Visible = true;
            pbLoading.Enabled = true;

            // Desabilitar filtro
            Filter.Enabled = false;

            // Desabilitar visualização do Flow
            Flow.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}

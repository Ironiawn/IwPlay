using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using CefSharp.WinForms;
using System.Windows.Forms;
using CefSharp;

namespace IwPlay.Hosts
{
    public partial class HostPages : UserControl
    {
        /// <summary>
        /// Browser web
        /// </summary>
        static ChromiumWebBrowser Browser;

        /// <summary>
        /// Prefixo de produtos do tipo JOGO
        /// </summary>
        protected string GamePrefix = "IwPG";

        public HostPages()
        {
            InitializeComponent();
        }

        private void Host_Load(object sender, EventArgs e)
        {
            // Definir configurações do browser
            CefSettings ces = new CefSettings
            {
                UserAgent = "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/86.0.4240.183 Safari/537.36 Ironiawn Synth ~ IwPlay"
            };

            // Inicializar configurações
            if (!Cef.IsInitialized)
                Cef.Initialize(ces);

            // Criar browser
            Browser = new ChromiumWebBrowser("https://www.ironiawn.com.br/playshop", null)
            {
                Dock = DockStyle.Fill
            };
            BrowserHost.Controls.Add(Browser);

            // Definir funções em tempo real do browser
            Browser.LoadingStateChanged += Browser_LoadingStateChanged;

            // Desabilitar menu de contexto
            Browser.MenuHandler = new Systems.IwP_Main_Security.CustomMenuHandler();
        }

        private void Browser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            #region CHECAGEM DE BOTÕES
            // Verifica se é possível ir para a próxima página
            if (e.CanGoForward)
            {
                // Altera status do botão de forward
                AtualizaStatusControle(pbForward, true);
            }
            else
            {
                // Altera status do botão de forward
                AtualizaStatusControle(pbForward, false);
            }
            // Verifica se é possível voltar a página
            if(e.CanGoBack)
            {
                // Altera status do botão de back
                AtualizaStatusControle(pbBack, true);
            }
            else
            {
                // Altera status do botão de back
                AtualizaStatusControle(pbBack, false);
            }
            // Verifica se é possível recarregar página
            if(e.CanReload)
            {
                // Altera status do botão de reload
                AtualizaStatusControle(pbReload, true);
            }
            else
            {
                // Altera status do botão de reload
                AtualizaStatusControle(pbReload, false);
            }
            #endregion

            // URL atual da página
            string curURL = e.Browser.MainFrame.Url.ToLower();

            // Verifica a URL da página
            if (!curURL.Contains("ironiawn.com.br/playshop") && !e.IsLoading)
            {
                // Verifica se não são páginas de pagamento
                if (curURL.Contains("pago") || curURL.Contains("paypal"))
                    return;

                // Voltar para a página do site da Ironiawn
                Browser.Load("https://www.ironiawn.com.br/playshop");
            }
            else
            {
                // Verifica se a página está carregada
                if (e.IsLoading)
                    return;


            }
        }

        /// <summary>
        /// Verificar se a página atual é de um produto do tipo JOGO
        /// </summary>
        /// <param name="curPage">URL da página atual</param>
        /// <returns></returns>
        private bool IsGamePage(string curPage)
        {
            // Verifica se a página contém 'produto' e o prefixo de jogos
            if (curPage.Contains("produto") && curPage.Contains(GamePrefix))
                return true;

            // Padrão: retornar falso
            return false;
        }

        /// <summary>
        /// Atualizar status de algum controle
        /// </summary>
        /// <param name="c">Nome do Controle</param>
        /// <param name="status">Status do Controle</param>
        void AtualizaStatusControle(Control c, bool status)
        {
            //Check if invoke requied if so return - as i will be recalled in correct thread
            if (Systems.IwP_Main_Security.ControlInvokeRequired(this, () => AtualizaStatusControle(c, status))) return;

            // Atualizar status dos botões
            c.Enabled = status;
        }
    }
}

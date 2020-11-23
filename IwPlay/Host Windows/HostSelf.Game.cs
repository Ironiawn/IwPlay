using System;
using System.Windows.Forms;
using GameDatabase = IwPlay.Systems.IwP_Main_Database.UserInfo;
using DevDatabase = IwPlay.Systems.IwP_Main_Database.DevInfo;
using System.IO;
using CefSharp.WinForms;

namespace IwPlay
{
    public partial class HostSelf : UserControl
    {
        /// <summary>
        /// Código do jogo
        /// </summary>
        public string GameCode = string.Empty;

        /// <summary>
        /// Imagem de exibição do jogo
        /// </summary>
        public string BoxShot = string.Empty;

        /// <summary>
        /// Preço do jogo
        /// </summary>
        public string GamePrice = string.Empty;

        /// <summary>
        /// Link de compra do jogo
        /// </summary>
        public string GameBuyLink = string.Empty;

        /// <summary>
        /// Descrição do jogo em HTML
        /// </summary>
        public string GameDescription = string.Empty;

        /// <summary>
        /// Validador de compra de jogo
        /// </summary>
        public bool HasGame = false;

        /// <summary>
        /// O usuário é um dos desenvolvedores do jogo?
        /// </summary>
        public bool IsTheDev = false;

        /// <summary>
        /// Validador de desenvolvedor verificado
        /// </summary>
        public bool DevVerified = false;

        /// <summary>
        /// Valida se o jogo está aprovado na IwPlay
        /// </summary>
        public bool Approved = false;

        ChromiumWebBrowser Browser;

        public HostSelf()
        {
            InitializeComponent();
        }

        [STAThread]
        private void HostSelf_Load(object sender, EventArgs e)
        {
            //Check if invoke requied if so return - as i will be recalled in correct thread
            if (Systems.IwP_Main_Security.ControlInvokeRequired(this, () => HostSelf_Load(sender, e))) return;

            // Atualiza descrição do jogo
            UpdateBrowserHTML("1");

            // Criar browser
            Browser = new ChromiumWebBrowser("file:///" + Systems.Directories.TempGameFiles_HTML(GameCode) + "\\description.html", null)
            {
                Dock = DockStyle.Fill
            };
            BrowserHost.Controls.Add(Browser);

            // Desabilitar menu de contexto
            Browser.MenuHandler = new Systems.IwP_Main_Security.CustomMenuHandler();

            // Atualiza informações do jogo
            UpdateGameInfo();
        }

        /// <summary>
        /// Atualizar informações do jogo
        /// </summary>
        void UpdateGameInfo()
        {
            // Informações do jogo
            Systems.GameInformation gi = DevDatabase.GameInfo(GameCode);

            // Atualiza preço
            GamePrice = gi.Price;

            // Carregar imagem do jogo
            GameImage.Load(gi.Image);

            // Atualiza aprovação
            Approved = bool.Parse(gi.ApprovedGame);

            // Atualiza link de pagamento
            GameBuyLink = gi.GameBuyLink;

            // Atualiza a descrição do jogo
            GameDescription = gi.Description;

            // Valida acquisição do jogo
            ValidateAcquisition();
        }

        /// <summary>
        /// Validar aquisição do jogo
        /// </summary>
        void ValidateAcquisition()
        {
            // Verifica se o usuário é um dos desenvolvedores
            if (IsTheDev)
            {
                // Habilitar edição do jogo
                UpdateGameInfoButton.Visible = true;
                UpdateGameInfoButton.Enabled = true;

                // Verificar se o jogo precisa de aprovação
                if (!Approved)
                {
                    // Exibir status de aprovação
                    HiddenGame.Visible = true;
                    ObtainingApproval.Visible = true;
                }
                else
                {
                    // Não Exibir status de aprovação
                    HiddenGame.Visible = false;
                    ObtainingApproval.Visible = false;
                }
            }
            else
            {
                // Desabilita edição do jogo
                UpdateGameInfoButton.Visible = false;
                UpdateGameInfoButton.Enabled = false;

                // Não exibir status de aprovação
                HiddenGame.Visible = false;
                ObtainingApproval.Visible = false;
            }

            // Valida se o usuário possui o jogo
            this.HasGame = GameDatabase.HasGame(GameCode);

            // Se o usuário possuir o jogo, desabilitar visualização do botão de compra
            if (this.HasGame)
            {
                // Desabilitar botão de compra
                BuyGame.Visible = false;
                BuyGame.Enabled = false;

                // Habilitar botão de jogar
                PlayGame.Enabled = true;
                PlayGame.Visible = true;
            }
            else
            {
                // Habilitar botão de compra
                BuyGame.Visible = true;
                BuyGame.Enabled = true;

                // Verifica se o jogo não é gratuito
                if (GamePrice == "0")
                {
                    // Alterar texto do botão e incluir preço
                    BuyGame.Text = "GRAB FOR\nFREE!";
                }
                else
                {
                    // Alterar texto do botão e incluir preço
                    BuyGame.Text += "\nR$" + GamePrice;
                }

                // Posição do botão de compra é a mesma do de jogar
                BuyGame.Location = PlayGame.Location;

                // Desabilitar botão de jogar
                PlayGame.Enabled = false;
                PlayGame.Visible = false;
            }

            // Se o desenvolvedor for verificado, exibir
            VerifiedDeveloper.Visible = DevVerified;

            // Atualiza descrição do jogo
            UpdateBrowserHTML();
        }

        /// <summary>
        /// Atualizar HTML do browser de descrição
        /// </summary>
        void UpdateBrowserHTML(string upd = null)
        {
            // Adicionar HTML à descrição do jogo
            if (!GameDescription.ToLower().Contains("html"))
            {
                // Criar HTML
                GameDescription = "<html><body>" + GameDescription + "</body></html>";

                // Verifica se o desenvolvedor possui selo de verificação
                if (!DevVerified)
                    GameDescription = GameDescription.Replace("<a", "<span");
            }
            else
            {
                // Verifica se o desenvolvedor possui selo de verificação
                if (!DevVerified)
                    GameDescription = GameDescription.Replace("<a", "<span");
            }

            // Criar html do jogo
            File.WriteAllText(Systems.Directories.TempGameFiles_HTML(GameCode) + "\\description.html", GameDescription);

            // Verifica a necessidade de carregar o browser com o arquivo
            if(upd == null)
                // Carrega browser
                Browser.Load("file:///" + Systems.Directories.TempGameFiles_HTML(GameCode) + "\\description.html");
        }

        private void BuyGame_Click(object sender, EventArgs e)
        {
            // Atualizar as informações do jogo
            UpdateGameInfo();

            // Criar nova instância de janela de compra
            Hosts.BuyPage bp = new Hosts.BuyPage { GameCode = this.GameCode, GameName = this.GameName.Text, Link = GameBuyLink, GamePrice = this.GamePrice };
            
            if(bp.ShowDialog() == DialogResult.OK)
            {
                // Atualiza informações do jogo
                UpdateGameInfo();
            }
        }

        private void PlayGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GameDatabase.AdquireInfo("DEVELOPERNAME"));
        }

        private void UpdateGameInfoButton_Click(object sender, EventArgs e)
        {
            // Criar janela do editor
            Hosts.Secondary.HostSelf_GameEditor editor = new Hosts.Secondary.HostSelf_GameEditor { GameCode = this.GameCode, BoxShot = this.BoxShot, GamePrice = this.GamePrice, GameBuyLink = this.GameBuyLink, 
                GameDescription = this.GameDescription, _Developer = Developer.Text, _GameName = this.GameName.Text, GameDeveloper = Developer.Text };
            if (editor.ShowDialog() == DialogResult.OK)
            {
                // Atualizar as informações do jogo
                UpdateGameInfo();
            }
        }
    }
}

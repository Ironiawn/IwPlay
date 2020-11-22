using System;
using CefSharp;
using CefSharp.WinForms;
using System.Windows.Forms;
using DBCS = IwPlay.Systems.IwP_Main_Database;
using System.Drawing;

namespace IwPlay.Hosts
{
    public partial class BuyPage : Form
    {
        /// <summary>
        /// Link de abertura
        /// </summary>
        public string Link;

        /// <summary>
        /// Nome do jogo
        /// </summary>
        public string GameName;

        /// <summary>
        /// Código de identificação do jogo
        /// </summary>
        public string GameCode;

        /// <summary>
        /// Preço do jogo (para compra com e-Wallet)
        /// </summary>
        public string GamePrice;

        /// <summary>
        /// Meio de pagamento utilizado
        /// </summary>
        protected internal string PaymentMethod = null;

        public BuyPage()
        {
            InitializeComponent();
        }

        ChromiumWebBrowser Browser;

        private void Host_Load(object sender, EventArgs e)
        {
            // Verificar se não é jogo gratuito
            if (GamePrice != "FREE")
            {
                // Checar se o usuário possui fundos
                if (float.Parse(DBCS.UserInfo.Wallet) < float.Parse(GamePrice))
                {
                    // Desabilitar botão de compra via e-Wallet e label de exibição de preço e valor disponível em carteira
                    BuyUsingFunds.Dispose();
                    CurrentFunds.Dispose();

                    // Alterar tamanho do browser
                    BrowserHost.Dock = DockStyle.Fill;
                }
                else
                {
                    // Exibir valor da e-Wallet e preço do jogo
                    CurrentFunds.Text = $"Your PlayFunds (IP$): {DBCS.UserInfo.Wallet}\nGame Price: BRL{GamePrice}";
                }
            }
            else
            {
                // Desabilitar botão de compra via e-Wallet e label de exibição de preço e valor disponível em carteira
                BuyUsingFunds.Dispose();
                CurrentFunds.Dispose();
                
                // Alterar tamanho do browser
                BrowserHost.Dock = DockStyle.Fill;
            }

            // Setar nome do jogo
            Text += " | " + GameName;

            // Criar browser
            Browser = new ChromiumWebBrowser(Link, null)
            {
                Dock = DockStyle.Fill
            };
            BrowserHost.Controls.Add(Browser);

            // Criar leitor de URL
            Browser.LoadingStateChanged += Browser_LoadingStateChanged;

            // Desabilitar menu de contexto
            Browser.MenuHandler = new Systems.IwP_Main_Security.CustomMenuHandler();
        }

        private async void Browser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            // Verifica se o browser parou de carregar
            if (e.IsLoading)
                return;

            // Adquire a URL atual
            string URL = e.Browser.MainFrame.Url;

            // Adquirir meio de pagamento
            if (Link.ToLower().Contains("mercado"))
                PaymentMethod = "MercadoPago";
            else
            if(Link.ToLower().Contains("paypal"))
                PaymentMethod = "PayPal";
            else
            if (Link.ToLower().Contains("pagseguro"))
                PaymentMethod = "PagSeguro";
            else
                PaymentMethod = "Other";

            // Verifica se a URL é a de pagamentos
            if (URL.ToLower().Contains("games.payment"))
            {
                // Adquire texto HTML
                string HTML = await e.Browser.MainFrame.GetSourceAsync();

                // Verifica se o HTML retornou "aguarde"
                if (HTML.ToLower().Contains("please wait"))
                {
                    // Carregar página de inserção
                    Browser.Load($"ipsvr.ironiawn.com.br/games/games.payment.php?sid={DBCS.UserInfo.SessionID}&" +
                        $"user={DBCS.UserInfo.Username}&gc={GameCode}&m={PaymentMethod}&p={GamePrice}");
                }else
                    if(HTML.ToLower().Contains("ok"))
                {
                    // Retornar dialog result ok
                    DialogResult = DialogResult.OK;
                   
                    // Sair do formulário
                    Sair();
                }else
                    if(HTML.ToLower().Contains("invalid session"))
                {
                    // Carregar página de inserção
                    Browser.Load($"ipsvr.ironiawn.com.br/games/games.payment.php?sid={DBCS.UserInfo.SessionID}&" +
                        $"user={DBCS.UserInfo.Username}&gc={GameCode}&m={PaymentMethod}&p={GamePrice}");
                }
            }
        }

        void Sair()
        {
            //Check if invoke requied if so return - as i will be recalled in correct thread
            if (Systems.IwP_Main_Security.ControlInvokeRequired(this, () => Sair())) return;

            Close();
        }
        private void BuyPage_Leave(object sender, EventArgs e)
        {
            // Sair do Cef
            Cef.PreShutdown();
        }

        void BuyItem(object sender, EventArgs e)
        {
            // Criar janela de mensagem customizada para confirmação do usuário
            IwP_CustomMessage ICM = new IwP_CustomMessage();

            // Setar meio de pagamento
            PaymentMethod = "IwPlay Funds";

            // Se o preço for 0
            if (GamePrice == "0")
                PaymentMethod += " FREE";
            else
                PaymentMethod += " PAID";

            // Checar se o usuário possui fundos
            if (float.Parse(DBCS.UserInfo.Wallet) >= float.Parse(GamePrice))
            {
                // Tentar comprar o jogo
                if (DBCS.UserInfo.CompraItem(float.Parse(GamePrice)))
                {
                    // Carregar página de inserção
                    Browser.Load($"ipsvr.ironiawn.com.br/games/games.payment?sid={DBCS.UserInfo.SessionID}&" +
                        $"user={DBCS.UserInfo.Username}&gc={GameCode}&m={PaymentMethod}&p={GamePrice}");
                }
                else
                {
                    // Criar janela de mensagem customizada
                    // Carregar imagem
                    ICM._Image = Image.FromFile(@"brw\sad.brw");
                    ICM._Title = "NOT ENOUGH IP$";
                    ICM._Description = $"You don't have enough credits\nto buy the item! :(";

                    // Exibir janela
                    ICM.ShowDialog();
                }
            }
            else
            {
                // Criar janela de mensagem customizada
                // Carregar imagem
                ICM._Image = Image.FromFile(@"brw\sad.brw");
                ICM._Title = "NOT ENOUGH IP$";
                ICM._Description = $"You don't have enough credits\nto buy the item! :(";

                // Exibir janela
                ICM.ShowDialog();
            }
        }

        private void BuyUsingFunds_Click(object sender, EventArgs e)
        {
            /*
            // Verifica a confirmação do usuário
            if (MessageBox.Show($"Are you sure?\nCurrent credits: IP${DBCS.UserInfo.Wallet}\nItem price: {GamePrice}", "IwPlay - Confirm Transaction", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            */

            // Criar janela de mensagem customizada para confirmação do usuário
            IwP_CustomMessage ICM = new IwP_CustomMessage();

            // Carregar imagem
            ICM._Image = Image.FromFile(@"brw\ips_coin.brw");
            ICM._Title = $"BUY ITEM FOR {GamePrice}";
            ICM._Description = $"Are you sure?\nYour Wallet: IP${DBCS.UserInfo.Wallet}";
            ICM.BackColor = Color.BlueViolet;
            ICM.CallFor = BuyItem;
            ICM.ButtonMessage = "BUY";

            // Exibir janela
            ICM.Show();

        }
    }
}

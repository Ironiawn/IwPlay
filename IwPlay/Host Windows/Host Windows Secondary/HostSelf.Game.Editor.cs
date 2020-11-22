using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameDatabase = IwPlay.Systems.IwP_Main_Database.DevInfo;
using BaiqiSoft.HtmlEditorControl;


namespace IwPlay.Hosts.Secondary
{
    public partial class HostSelf_GameEditor : Form
    {
        /// <summary>
        /// Código IwPlay do jogo
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
        /// Nome do jogo
        /// </summary>
        public string _GameName = string.Empty;

        /// <summary>
        /// Editor HTML
        /// </summary>
        MstHtmlEditor HTMLEditor = new MstHtmlEditor();

        /// <summary>
        /// Desenvolvedor do jogo
        /// </summary>
        public string _Developer = string.Empty;

        /// <summary>
        /// Link de compra do jogo
        /// </summary>
        public string GameBuyLink = string.Empty;

        /// <summary>
        /// Descrição do jogo em HTML
        /// </summary>
        public string GameDescription = string.Empty;

        /// <summary>
        /// Desenvolvedor(es) do jogo
        /// </summary>
        public string GameDeveloper = string.Empty;

        public HostSelf_GameEditor()
        {
            InitializeComponent();
        }

        private void CurrentGamePriceInput_TextChanged(object sender, EventArgs e)
        {
            // Habilitar botão de atualização
            UpdateGame.Enabled = true;
        }

        private void UpdateGamePriceButton_Click(object sender, EventArgs e)
        {
            // Indicador de revisão
            bool PendingApproval = false;

            // Verifica se a descrição do jogo foi alterada
            if (HTMLEditor.BodyHTML != GameDescription)
            {
                // Remover qualquer tag html da descrição para nova atualização no elemento de página
                string NewHTML = HTMLEditor.BodyHTML;
                NewHTML = NewHTML.Replace("<html>", "");
                NewHTML = NewHTML.Replace("</html>", "");

                // Tentar atualizar informação de preço do jogo
                if (!GameDatabase.UpdateInfo("GAMEDESCRIPTION", NewHTML, GameCode, GameDeveloper))
                {
                    // Mostrar uma mensagem de atualização não efetuada!
                    MessageBox.Show("Error while updating your game description!\nPlease try again.", "IwPlay - Game Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Verifica se a imagem do jogo foi alterada
            if (GameImageLink.Text.Trim() != BoxShot)
            { 
                // Tentar atualizar informação de preço do jogo
                if (!GameDatabase.UpdateInfo("GAMEIMAGE", GameImageLink.Text.Trim(), GameCode, GameDeveloper))
                {
                    // Mostrar uma mensagem de atualização não efetuada!
                    MessageBox.Show("Error while updating your game image link!\nPlease try again.", "IwPlay - Game Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Verifica se o link foi alterado
            if (GameBuyLink != CurrentPaymentLinkInput.Text.Trim())
            {
                // Tentar atualizar informação de link de pagamento do jogo
                if (!GameDatabase.UpdateInfo("GAMEBUYID", CurrentPaymentLinkInput.Text.Trim(), GameCode, GameDeveloper))
                {
                    // Mostrar uma mensagem de atualização não efetuada!
                    MessageBox.Show("Error while updating your game payment link!\nPlease try again.", "IwPlay - Game Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    // O jogo estará pendente aprovação IwPlay
                    PendingApproval = true;
            }

            // Verifica se o preço foi alterado
            if (GamePrice != CurrentGamePriceInput.Text.Trim())
            {
                // Tentar dar parse no texto de preço
                try
                {
                    // Verifica se o indicador de gratuidade está checado
                    if (!CheckFreeGame.Checked)
                    {
                        double p = double.Parse(CurrentGamePriceInput.Text.Trim());
                    }

                    // Tentar atualizar informação de preço do jogo
                    if (!GameDatabase.UpdateInfo("GAMEPRICE", CurrentGamePriceInput.Text == "FREE" ? "0" : CurrentGamePriceInput.Text.Trim(), GameCode, GameDeveloper))
                    {
                        // Mostrar uma mensagem de atualização não efetuada!
                        MessageBox.Show("Error while updating your game price!\nPlease try again.", "IwPlay - Game Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        // O jogo estará pendente aprovação IwPlay
                        PendingApproval = true;
                }
                catch
                {
                    // Preço inválido!
                    MessageBox.Show("The new price is invalid, please check and try again!", "IwPlay - Game Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }


            /*
            // Exibe mensagem de atualizado
            MessageBox.Show("Game updated!\nINSTRUCTIONS\n\n# Now the game will be reviewed by us and can be available again up to 3 business days, ok? #\n\n- Updated the price? The payment link must be updated too.\n- Updated the payment link? Same for above, but for price." +
                "\n- Updated description? IwPlay removes href links, be aware!", "IwPlay - Game Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            */

            // Criar janela de mensagem customizada
            IwP_CustomMessage ICM = new IwP_CustomMessage
            {
                // Carregar imagem
                _Image = PendingApproval? Image.FromFile(@"brw\submit_approval.brw") : Image.FromFile(@"brw\positive.brw"),
                _Title = PendingApproval ? "SENT TO REVIEW": "GAME UPDATED",
                _Description = PendingApproval? "The game has been submited to\nreview. We'll notify you on your\ne-mail!\n\nGame is now hidden from public." : "The game has been updated and\nis currently visible for public!"
            };

            // Exibir janela customizada
            ICM.ShowDialog();

            // Resultado OK
            DialogResult = DialogResult.OK;
        }

        private void HostSelf_Load(object sender, EventArgs e)
        {
            // Criar editor HTML
            EditorHandler.Controls.Add(HTMLEditor);

            // Carregar nome do jogo
            GameName.Text = _GameName;

            // Carregar desenvolvedor
            Developer.Text = _Developer;

            // Carregar imagem do jogo
            GameImage.Load(BoxShot);
            GameImageLink.Text = BoxShot;

            // Carregar descrição do jogo no editor de HTML
            HTMLEditor.InsertHtml(GameDescription);
            HTMLEditor.Dock = DockStyle.Fill;
            HTMLEditor.HtmlChanged += CurrentGamePriceInput_TextChanged;

            // Atualizar descrição interna do jogo com o bodyHTML
            GameDescription = HTMLEditor.BodyHTML;

            // Carregar preço do jogo
            CurrentGamePriceInput.Text = GamePrice;

            // Verifica se o preço é gratuito
            if(GamePrice == "0")
            {
                // Desabilita edição de preço
                CurrentGamePriceInput.Enabled = false;

                // Altera preço
                CurrentGamePriceInput.Text = "FREE";

                // Checar marcador de gratuidade
                CheckFreeGame.Checked = true;

                // Desabilita alteração de link de pagamento
                CurrentPaymentLinkInput.Enabled = false;

                // Define texto do link de pagamento
                CurrentPaymentLinkInput.Text = "-";
            }
            else
            {
                // Desmarcar gratuidade
                CheckFreeGame.Checked = false;

                // Altera preço
                CurrentGamePriceInput.Text = GamePrice;

                // Habilita edição de preço
                CurrentGamePriceInput.Enabled = true;

                // Habilita alteração de link de pagamento
                CurrentPaymentLinkInput.Enabled = true;

                // Verifica se o link de compra não é a aprovação da IwPlay
                if(GameBuyLink.ToLower().Contains("ipsvr"))
                    // Define texto do link de pagamento
                    CurrentPaymentLinkInput.Text = "-";
                else
                    // Define texto do link de pagamento
                    CurrentPaymentLinkInput.Text = GameBuyLink;
            }

            // Desabilitar botão de update
            UpdateGame.Enabled = false;
        }
        private void CheckFreeGame_MouseClick(object sender, MouseEventArgs e)
        {
            // Verifica se o controle está ativo
            if (CheckFreeGame.Checked)
            {
                // Desabilita edição de preço
                CurrentGamePriceInput.Enabled = false;

                // Altera preço
                CurrentGamePriceInput.Text = "FREE";

                // Desabilita alteração de link de pagamento
                CurrentPaymentLinkInput.Enabled = false;

                // Define texto do link de pagamento
                CurrentPaymentLinkInput.Text = "-";
            }
            else
            {
                // Habilita edição de preço
                CurrentGamePriceInput.Enabled = true;

                // Altera preço
                CurrentGamePriceInput.Text = "0";

                // Habilita alteração de link de pagamento
                CurrentPaymentLinkInput.Enabled = true;
            }
        }

        private void HostSelf_Leave(object sender, EventArgs e)
        {

        }

        private void CurrentPaymentLinkInput_TextChanged(object sender, EventArgs e)
        {
            // Habilitar botão de atualização
            UpdateGame.Enabled = true;
        }

        private void GameImageLink_TextChanged(object sender, EventArgs e)
        {
            // Habilitar botão de atualização
            UpdateGame.Enabled = true;
        }
    }
}

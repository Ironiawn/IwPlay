using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserDB = IwPlay.Systems.IwP_Main_Database.UserInfo;
using DevDB = IwPlay.Systems.IwP_Main_Database.DevInfo;
using DG.MiniHTMLTextBox;

namespace IwPlay.Hosts.Secondary
{
    public partial class HostSelf_GameEditor_Insert : Form
    {

        /// <summary>
        /// O usuário deverá verificar as informações inseridas antes de enviar o jogo para análise
        /// </summary>
        private bool Verified = false;


        public HostSelf_GameEditor_Insert()
        {
            InitializeComponent();
        }

        private void HostSelf_Load(object sender, EventArgs e)
        {
            // Inserir os desenvolvedores no combo de seletor
            foreach (string s in UserDB.Desenvolvedor) DeveloperFilter.Items.Add(s.ToUpper());
            // Obrigar selecionar desenvolvedor
            DeveloperFilter.SelectedItem = DeveloperFilter.Items[0];
        }

        private void InsertGame_Click(object sender, EventArgs e)
        {
            // O jogo foi validado?
            if (!Verified)
            {
                // Exibe mensagem de erro e retorna
                Systems.Functions.ExibeMensagem("OOPS!", "Hey, verify and sync your game\nbefore trying to send!", @"brw\closed_road.brw");
                return;
            }
        }

        private void UpdateLinks_Click(object sender, EventArgs e)
        {
            // Atualizar imagem do jogo
            try
            {
                // Carregar imagem disponibilizada
                GameImage.Load(GameImageLink.Text);

                // Remover qualquer tag html da descrição para nova atualização no elemento de página
                string NewHTML = HTMLEditor.Text;
                NewHTML = NewHTML.Replace("<html>", "");
                NewHTML = NewHTML.Replace("</html>", "");

                // Verificar se o link começa com http ou https
                // Verificar se o nome do jogo possui 5 ou mais caracteres
                if (!CurrentPaymentLinkInput.Text.ToLower().Contains("http") || !CurrentPaymentLinkInput.Text.ToLower().Contains("https") || GameNameInput.Text.Length < 5)
                    throw new Exception();

                // Jogo verificado!
                Verified = true;
            }
            catch
            {
                // Zerar validação
                Verified = false;

                // Exibe mensagem de erro
                Systems.Functions.ExibeMensagem("SOMETHING ISN'T RIGHT", "Hey, check the input data\nand try again!", @"brw\closed_road.brw");
            }
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
    }
}

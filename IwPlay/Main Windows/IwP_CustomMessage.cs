using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IwPlay
{
    public partial class IwP_CustomMessage : Form
    {
        public IwP_CustomMessage()
        {
            InitializeComponent();
        }

        public Image _Image;
        public string _Title;
        public string _Description;
        /// <summary>
        /// Ação para ser chamada ao clique do botão
        /// </summary>
        public EventHandler CallFor = null;
        /// <summary>
        /// Texto to botão de
        /// </summary>
        public string ButtonMessage = null;

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Fechar diálogo
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void IwP_CustomMessage_Load(object sender, EventArgs e)
        {
            // Carregar objetos
            ImageShow.Image = _Image;
            Title.Text = _Title;
            Message.Text = _Description;

            // Verificar se não há ações para serem adicionadas no botão
            if(CallFor == null || ButtonMessage == null)
            {
                // Desabilitar botão de ação
                ActionButton.Visible = false;
                ActionButton.Enabled = false;
            }
            else
            {
                // Altera texto do botão de ação
                ActionButton.Text = ButtonMessage;
                ActionButton.Click += CallFor;

                // Valor de diálogo como OK
                DialogResult = DialogResult.OK;
            }
        }
    }
}

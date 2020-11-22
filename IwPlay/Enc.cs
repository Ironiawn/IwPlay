using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.Encryption;
using IwPlay.Systems;

namespace IwPlay
{
    public partial class Enc : Form
    {
        public Enc()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            tbText.Text = AESEncryption.Encrypt(tbText.Text, "5@&_1R0N14WN");
        }

        private void Enc_Load(object sender, EventArgs e)
        {

        }
    }
}

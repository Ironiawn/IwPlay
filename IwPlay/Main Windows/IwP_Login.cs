using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database = IwPlay.Systems.IwP_Main_Database;

namespace IwPlay
{
    public partial class IwP_Login : Form
    {
        public IwP_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Desabilitar feedback de login
            lbLoginFeedback.Visible = false;

            // Alterar o texto do botão para informar status
            btnLogin.Text = "WAIT..";

            // Parar thread
            System.Threading.Thread.Sleep(200);

            // Valida informações antes de continuar
            if (tbUsername.Text.Length < 4 || tbPassword.Text.Length < 9)
            {
                // Alterar texto de feedback
                lbLoginFeedback.Text = "Please provide a valid username/password!";

                // Exibir texto de feedback
                lbLoginFeedback.Visible = true;

                // Alterar texto do botão para status original
                btnLogin.Text = "LOGIN";
                return;
            }

            // Validar o login
            Database.Connection.RetCodes validaLogin = Database.Connection.LoginUser(tbUsername.Text, tbPassword.Text);

            // Tenta efetuar o login utilizando os dados inseridos
            if (validaLogin == Database.Connection.RetCodes.SUCCESS)
            {
                // Esconder janela atual
                Hide();

                // Criar novo form com base na Home
                var homeForm = new IwP_Home();
                homeForm.Closed += (s, args) => Close();

                // Exibir Home form
                homeForm.Show();
            }
            else
            if (validaLogin == Database.Connection.RetCodes.PASSWORD)
            {
                // Criar janela de mensagem customizada
                IwP_CustomMessage ICM = new IwP_CustomMessage
                {
                    // Carregar imagem
                    _Image = Image.FromFile(@"brw\wrong_pass.brw"),
                    _Title = "WRONG PASSWORD",
                    _Description = $"The provided password\ndoesn't match our records!\nD'you remember it?"
                };

                // Exibir janela
                ICM.ShowDialog();
            }
            else
            if (validaLogin == Database.Connection.RetCodes.VALIDATION)
            {
                // Criar janela de mensagem customizada
                IwP_CustomMessage ICM = new IwP_CustomMessage
                {
                    // Carregar imagem
                    _Image = Image.FromFile(@"brw\important_mail.brw"),
                    _Title = "UNVERIFIED ACCOUNT",
                    _Description = $"The account {tbUsername.Text.ToUpper()}\nhasn't been activated yet!\nPlease check your e-mail."
                };

                // Exibir janela
                ICM.ShowDialog();
            }
            else
            if (validaLogin == Database.Connection.RetCodes.BANNED)
            {
                // Criar janela de mensagem customizada
                IwP_CustomMessage ICM = new IwP_CustomMessage
                {
                    // Carregar imagem
                    _Image = Image.FromFile(@"brw\closed_road.brw"),
                    _Title = "SUSPENDED ACCOUNT",
                    _Description = $"The account {tbUsername.Text.ToUpper()}\nhas been suspended!\nPlease contact IwPlay Support\nfor more details."
                };

                // Exibir janela
                ICM.ShowDialog();
            }
            else
            if (validaLogin == Database.Connection.RetCodes.NSU)
            {
                // Criar janela de mensagem customizada
                IwP_CustomMessage ICM = new IwP_CustomMessage
                {
                    // Carregar imagem
                    _Image = Image.FromFile(@"brw\no_user.brw"),
                    _Title = "ACCOUNT NOT FOUND",
                    _Description = $"The account {tbUsername.Text.ToUpper()}\ndoesn't exists!\n\nYou can create one!!"
                };

                // Exibir janela
                ICM.ShowDialog();
            }
            else
            {
                // Alterar texto de feedback
                lbLoginFeedback.Text = "Something isn't right!";

                // Exibir texto de feedback
                lbLoginFeedback.Visible = true;
            }

            // Alterar texto do botão para status original
            btnLogin.Text = "LOGIN";
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Esconder form atual
            Hide();

            // Criar nova form
            var rgrForm = new IwP_Register();
            rgrForm.Closed += (s, args) => Close();

            // Abrir form
            rgrForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(System.Net.WebClient wc = new System.Net.WebClient())
            {
                var data = new NameValueCollection
                {
                    ["AAA"] = "UAC"
                };

                wc.Headers.Add("user-agent", "IwPlayCLI");
                var ss = wc.UploadValues("https://ipsvr.ironiawn.com.br/users/users.test.php", "POST", data);
                string sss = Encoding.UTF8.GetString(ss);

                MessageBox.Show(sss);
            }
        }

        private void IwP_Login_Load(object sender, EventArgs e)
        {
            Systems.AppActions.CreateGameConfig("teste", "ninfo", "oi");
        }
    }
}

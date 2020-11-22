using System;
using System.Collections.Generic;
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
    public partial class IwP_Register : Form
    {
        public IwP_Register()
        {
            InitializeComponent();
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Voltar para a janela de login
        /// </summary>
        private void pbBack_Click(object sender, EventArgs e)
        {
            // Esconder janela atual
            Hide();

            // Criar novo form com base na login
            var lgnForm = new IwP_Login();
            lgnForm.Closed += (s, args) => Close();

            // Exibir login form
            lgnForm.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Compara os valores de senhas
            if (tbPassword.Text == tbConfirmPassword.Text)
            {
                // Verifica se os campos contém um número mínimo de caracteres
                if (tbPassword.Text.Length >= 9 && tbEmail.Text.Length >= 6
                    && tbUsername.Text.Length >= 4)
                {
                    // Criar validação e adquirir retorno
                    Database.Connection.RetCodes validaCreation = Database.Connection.CreateUser(tbUsername.Text, tbPassword.Text, tbEmail.Text);

                    // Criar usuário
                    if (validaCreation == Database.Connection.RetCodes.SUCCESS)
                    {
                        // Criar janela de mensagem customizada
                        IwP_CustomMessage ICM = new IwP_CustomMessage
                        {
                            // Carregar imagem
                            _Image = Image.FromFile(@"brw\new_user.brw"),
                            _Title = "ACCOUNT CREATED",
                            _Description = $"The account {tbUsername.Text.ToUpper()}\nhas been created!\nCheck the provided e-mail to\nactivate it."
                        };

                        // Exibir janela customizada
                        ICM.ShowDialog();

                        // Esconder janela atual
                        Hide();

                        // Criar novo form com base na login
                        var lgnForm = new IwP_Login();
                        lgnForm.Closed += (s, args) => Close();

                        // Exibir login form
                        lgnForm.Show();
                    }
                    else
                    if (validaCreation == Database.Connection.RetCodes.ALREADY_USER)
                    {
                        // Criar janela de mensagem customizada
                        IwP_CustomMessage ICM = new IwP_CustomMessage
                        {
                            // Carregar imagem
                            _Image = Image.FromFile(@"brw\sad.brw"),
                            _Title = "WHAAT?!",
                            _Description = $"The account {tbUsername.Text.ToUpper()}\nalready exists on our database!"
                        };

                        // Exibir janela
                        ICM.ShowDialog();
                    }
                    else
                    if (validaCreation == Database.Connection.RetCodes.ALREADY_MAIL)
                    {
                        // Criar janela de mensagem customizada
                        IwP_CustomMessage ICM = new IwP_CustomMessage
                        {
                            // Carregar imagem
                            _Image = Image.FromFile(@"brw\sad.brw"),
                            _Title = "WHAAT?!",
                            _Description = $"The provided e-mail already exists\non our database!"
                        };

                        // Exibir janela
                        ICM.ShowDialog();
                    }
                    else
                    if (validaCreation == Database.Connection.RetCodes.ERROR_SENDMAIL)
                    {
                        // Criar janela de mensagem customizada
                        IwP_CustomMessage ICM = new IwP_CustomMessage
                        {
                            // Carregar imagem
                            _Image = Image.FromFile(@"brw\sad.brw"),
                            _Title = "WHAAT?!",
                            _Description = $"Something unexpected happened!!\nError while sending the activation\ne-mail. :(\nTry again.. please?"
                        };

                        // Exibir janela
                        ICM.ShowDialog();
                    }
                    else
                    if (validaCreation == Database.Connection.RetCodes.ERROR_CREATEQUERY)
                    {
                        // Criar janela de mensagem customizada
                        IwP_CustomMessage ICM = new IwP_CustomMessage
                        {
                            // Carregar imagem
                            _Image = Image.FromFile(@"brw\sad.brw"),
                            _Title = "WHAAT?!",
                            _Description = $"Something unexpected happened!!\nError while creating your account :(\nTry again.. please?"
                        };

                        // Exibir janela
                        ICM.ShowDialog();
                    }
                    else
                    {
                        // Criar janela de mensagem customizada
                        IwP_CustomMessage ICM = new IwP_CustomMessage
                        {
                            // Carregar imagem
                            _Image = Image.FromFile(@"brw\sad.brw"),
                            _Title = "WHAAT?!",
                            _Description = $"Something unexpected happened!!\nA server error occured!\n\nContact us if persists."
                        };

                        // Exibir janela
                        ICM.ShowDialog();
                    }
                }
                else
                {
                    // Criar janela de mensagem customizada
                    IwP_CustomMessage ICM = new IwP_CustomMessage
                    {
                        // Carregar imagem
                        _Image = Image.FromFile(@"brw\closed_road.brw"),
                        _Title = "CHECK THE FIELDS",
                        _Description = $"Hmm some fields doesn't meet\nthe minimum requirements!\n\nTry again.. please?"
                    };

                    // Exibir janela
                    ICM.ShowDialog();
                }
            }
            else
            {

                // Criar janela de mensagem customizada
                IwP_CustomMessage ICM = new IwP_CustomMessage
                {
                    // Carregar imagem
                    _Image = Image.FromFile(@"brw\wrong_pass.brw"),
                    _Title = "CHECK THE PASSWORD",
                    _Description = $"The password confirmation isn't right!\n\nTry again.. please?"
                };

                // Exibir janela
                ICM.ShowDialog();
            }
        }
    }
}

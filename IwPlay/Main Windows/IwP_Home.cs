using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using IwPlay.Systems;
using System.Windows.Forms;
using CefSharp;
using Database = IwPlay.Systems.IwP_Main_Database;

namespace IwPlay
{
    public partial class IwP_Home : Form
    {
        public IwP_Home()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Setores disponíveis na IwPlay
        /// </summary>
        private enum Setores
        {
            /// <summary>
            /// Setor padrão, inicial
            /// </summary>
            None,
            /// <summary>
            /// Setor de compras
            /// </summary>
            Shop,
            /// <summary>
            /// Setor da biblioteca do usuário
            /// </summary>
            Library
        };
        /// <summary>
        /// Setor atual do usuário
        /// </summary>
        Setores SetorAtual = Setores.None;

        /// <summary>
        /// Atualizar setor atual
        /// </summary>
        /// <param name="novoSetor">Novo setor</param>
        private void UpdateSector(Setores novoSetor)
        {
            // Verifica se o novo setor já não está ativo
            if (novoSetor == SetorAtual)
                return;

            // Dispose em todos os controles
            foreach(Control z in Host.Controls)
                z.Dispose();

            // Zerar controles
            Host.Controls.Clear();

            // Percorrer setores
            switch(novoSetor)
            {
                // Setor de shopping
                case Setores.Shop:
                    var HostPages = new Hosts.HostPages();
                    Host.Controls.Add(HostPages);
                    break;
                case Setores.Library:
                    // Sair do Cef
                    Cef.PreShutdown();
                    var HostGames = new Hosts.HostLibrary();
                    Host.Controls.Add(HostGames);
                    break;
            }
        }

        private void IwP_Home_Load(object sender, EventArgs e)
        {
            // Carregar dados do usuário
            lbUserDetails.Text = Database.UserInfo.Username;
            pbUserPic.Load(Database.UserInfo.AdquireInfo("USERIMG"));

            // Adquirir nomes de desenvolvedor do usuário
            List<Database.DevInfo._DeveloperInfo> DevNames = Database.DevInfo.DeveloperInfo;

            // Verifica se o usuário possui nomes de desenvolvedor
            if(DevNames.Count > 0)
                // Usuário é desenvolvedor, exibir!
                lbUserDetails.Text += " (Dev)";

            // Adquirir balanço da carteira do usuário
            string Balance = Database.UserInfo.Wallet;

            // Verifica se o usuário possui valores
            if (float.Parse(Balance) >= 1)
                WalletBalance.Text = $"${Balance}";
            else
            {
                // Desativar imagem e label de exibição de carteira
                WalletBalance.Visible = false;
                WalletPic.Visible = false;
            }

            // Criar timer para adquirir dados do servidor em tempo real
            Timer UpdateStatus = new Timer();
            UpdateStatus.Interval = 2000;
            UpdateStatus.Tick += UpdateStatus_Tick;
            UpdateStatus.Start();

            // Novo setor
            UpdateSector(Setores.Shop);
        }

        private void UpdateStatus_Tick(object sender, EventArgs e)
        {
            // Adquirir balanço da carteira do usuário
            string Balance = Database.UserInfo.Wallet;

            // Verifica se o usuário possui valores
            if (float.Parse(Balance) >= 1)
                WalletBalance.Text = $"${Balance}";
            else
            {
                // Desativar imagem e label de exibição de carteira
                WalletBalance.Visible = false;
                WalletPic.Visible = false;
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // Setor de shopping
            UpdateSector(Setores.Shop);
        }

        private void btnUserLibrary_Click(object sender, EventArgs e)
        {
            // Setor de jogos
            UpdateSector(Setores.Library);
        }

        private void IwP_Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Deslogar
            Database.UserInfo.Deslogar();
        }
    }
}

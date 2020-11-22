using System;

namespace IwPlay
{
    partial class HostSelf
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostSelf));
            this.GameImage = new System.Windows.Forms.PictureBox();
            this.GameName = new System.Windows.Forms.Label();
            this.Developer = new System.Windows.Forms.Label();
            this.PlayGame = new System.Windows.Forms.Button();
            this.BuyGame = new System.Windows.Forms.Button();
            this.HiddenGame = new System.Windows.Forms.PictureBox();
            this.ObtainingApproval = new System.Windows.Forms.Label();
            this.UpdateGameInfoButton = new System.Windows.Forms.Button();
            this.BrowserHost = new System.Windows.Forms.Panel();
            this.VerifiedDeveloper = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GameImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HiddenGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerifiedDeveloper)).BeginInit();
            this.SuspendLayout();
            // 
            // GameImage
            // 
            this.GameImage.Location = new System.Drawing.Point(3, 3);
            this.GameImage.Name = "GameImage";
            this.GameImage.Size = new System.Drawing.Size(236, 309);
            this.GameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameImage.TabIndex = 0;
            this.GameImage.TabStop = false;
            // 
            // GameName
            // 
            this.GameName.AutoSize = true;
            this.GameName.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameName.Location = new System.Drawing.Point(245, 3);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(174, 32);
            this.GameName.TabIndex = 1;
            this.GameName.Text = "%GameName%";
            // 
            // Developer
            // 
            this.Developer.AutoSize = true;
            this.Developer.Font = new System.Drawing.Font("Segoe UI Semibold", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Developer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Developer.Location = new System.Drawing.Point(245, 35);
            this.Developer.Name = "Developer";
            this.Developer.Size = new System.Drawing.Size(160, 31);
            this.Developer.TabIndex = 2;
            this.Developer.Text = "%Developer%";
            // 
            // PlayGame
            // 
            this.PlayGame.BackColor = System.Drawing.Color.Red;
            this.PlayGame.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PlayGame.FlatAppearance.BorderSize = 3;
            this.PlayGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.PlayGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.PlayGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayGame.Font = new System.Drawing.Font("Ink Free", 16F);
            this.PlayGame.ForeColor = System.Drawing.Color.White;
            this.PlayGame.Image = ((System.Drawing.Image)(resources.GetObject("PlayGame.Image")));
            this.PlayGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlayGame.Location = new System.Drawing.Point(35, 318);
            this.PlayGame.Name = "PlayGame";
            this.PlayGame.Size = new System.Drawing.Size(170, 50);
            this.PlayGame.TabIndex = 12;
            this.PlayGame.Text = "Play Game";
            this.PlayGame.UseVisualStyleBackColor = false;
            this.PlayGame.Click += new System.EventHandler(this.PlayGame_Click);
            // 
            // BuyGame
            // 
            this.BuyGame.BackColor = System.Drawing.Color.DodgerBlue;
            this.BuyGame.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BuyGame.FlatAppearance.BorderSize = 3;
            this.BuyGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BuyGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.BuyGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyGame.Font = new System.Drawing.Font("Arial", 12F);
            this.BuyGame.ForeColor = System.Drawing.Color.White;
            this.BuyGame.Image = ((System.Drawing.Image)(resources.GetObject("BuyGame.Image")));
            this.BuyGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuyGame.Location = new System.Drawing.Point(35, 374);
            this.BuyGame.Name = "BuyGame";
            this.BuyGame.Size = new System.Drawing.Size(170, 50);
            this.BuyGame.TabIndex = 13;
            this.BuyGame.Text = "Buy Game";
            this.BuyGame.UseVisualStyleBackColor = false;
            this.BuyGame.Click += new System.EventHandler(this.BuyGame_Click);
            // 
            // HiddenGame
            // 
            this.HiddenGame.Image = ((System.Drawing.Image)(resources.GetObject("HiddenGame.Image")));
            this.HiddenGame.Location = new System.Drawing.Point(86, 430);
            this.HiddenGame.Name = "HiddenGame";
            this.HiddenGame.Size = new System.Drawing.Size(64, 64);
            this.HiddenGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HiddenGame.TabIndex = 15;
            this.HiddenGame.TabStop = false;
            // 
            // ObtainingApproval
            // 
            this.ObtainingApproval.AutoSize = true;
            this.ObtainingApproval.Font = new System.Drawing.Font("Arial", 12F);
            this.ObtainingApproval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ObtainingApproval.Location = new System.Drawing.Point(32, 497);
            this.ObtainingApproval.Name = "ObtainingApproval";
            this.ObtainingApproval.Size = new System.Drawing.Size(184, 54);
            this.ObtainingApproval.TabIndex = 16;
            this.ObtainingApproval.Text = "OBTAINING APPROVAL!\r\nVISIBLE ONLY BY \r\nDEVELOPER";
            this.ObtainingApproval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateGameInfoButton
            // 
            this.UpdateGameInfoButton.BackColor = System.Drawing.Color.Purple;
            this.UpdateGameInfoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.UpdateGameInfoButton.FlatAppearance.BorderSize = 3;
            this.UpdateGameInfoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.UpdateGameInfoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.UpdateGameInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateGameInfoButton.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.UpdateGameInfoButton.ForeColor = System.Drawing.Color.White;
            this.UpdateGameInfoButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateGameInfoButton.Image")));
            this.UpdateGameInfoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateGameInfoButton.Location = new System.Drawing.Point(740, 3);
            this.UpdateGameInfoButton.Name = "UpdateGameInfoButton";
            this.UpdateGameInfoButton.Size = new System.Drawing.Size(120, 55);
            this.UpdateGameInfoButton.TabIndex = 17;
            this.UpdateGameInfoButton.Text = "Update\r\nGame Info";
            this.UpdateGameInfoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateGameInfoButton.UseVisualStyleBackColor = false;
            this.UpdateGameInfoButton.Click += new System.EventHandler(this.UpdateGameInfoButton_Click);
            // 
            // BrowserHost
            // 
            this.BrowserHost.Location = new System.Drawing.Point(245, 65);
            this.BrowserHost.Name = "BrowserHost";
            this.BrowserHost.Size = new System.Drawing.Size(615, 486);
            this.BrowserHost.TabIndex = 18;
            // 
            // VerifiedDeveloper
            // 
            this.VerifiedDeveloper.BackColor = System.Drawing.Color.Transparent;
            this.VerifiedDeveloper.Image = ((System.Drawing.Image)(resources.GetObject("VerifiedDeveloper.Image")));
            this.VerifiedDeveloper.Location = new System.Drawing.Point(207, 318);
            this.VerifiedDeveloper.Name = "VerifiedDeveloper";
            this.VerifiedDeveloper.Size = new System.Drawing.Size(32, 32);
            this.VerifiedDeveloper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VerifiedDeveloper.TabIndex = 19;
            this.VerifiedDeveloper.TabStop = false;
            this.VerifiedDeveloper.Visible = false;
            // 
            // HostSelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.VerifiedDeveloper);
            this.Controls.Add(this.BrowserHost);
            this.Controls.Add(this.UpdateGameInfoButton);
            this.Controls.Add(this.ObtainingApproval);
            this.Controls.Add(this.HiddenGame);
            this.Controls.Add(this.BuyGame);
            this.Controls.Add(this.PlayGame);
            this.Controls.Add(this.Developer);
            this.Controls.Add(this.GameName);
            this.Controls.Add(this.GameImage);
            this.Name = "HostSelf";
            this.Size = new System.Drawing.Size(870, 557);
            this.Load += new System.EventHandler(this.HostSelf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GameImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HiddenGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerifiedDeveloper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox GameImage;
        public System.Windows.Forms.Label GameName;
        public System.Windows.Forms.Label Developer;
        private System.Windows.Forms.Button PlayGame;
        private System.Windows.Forms.Button BuyGame;
        private System.Windows.Forms.PictureBox HiddenGame;
        public System.Windows.Forms.Label ObtainingApproval;
        private System.Windows.Forms.Button UpdateGameInfoButton;
        private System.Windows.Forms.Panel BrowserHost;
        private System.Windows.Forms.PictureBox VerifiedDeveloper;
    }
}

namespace IwPlay
{
    partial class IwP_Login
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lbTitle;
            System.Windows.Forms.Label lbUsername;
            System.Windows.Forms.Label lbPassword;
            System.Windows.Forms.Label lbCopyright;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IwP_Login));
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbClose = new System.Windows.Forms.PictureBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbLoginFeedback = new System.Windows.Forms.Label();
            lbTitle = new System.Windows.Forms.Label();
            lbUsername = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            lbCopyright = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.BackColor = System.Drawing.Color.Transparent;
            lbTitle.Font = new System.Drawing.Font("Ink Free", 40F);
            lbTitle.ForeColor = System.Drawing.Color.White;
            lbTitle.Location = new System.Drawing.Point(12, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(197, 67);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "IwPlay";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.BackColor = System.Drawing.Color.Transparent;
            lbUsername.Font = new System.Drawing.Font("Ink Free", 15F);
            lbUsername.ForeColor = System.Drawing.Color.White;
            lbUsername.Location = new System.Drawing.Point(19, 89);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new System.Drawing.Size(95, 25);
            lbUsername.TabIndex = 3;
            lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.BackColor = System.Drawing.Color.Transparent;
            lbPassword.Font = new System.Drawing.Font("Ink Free", 15F);
            lbPassword.ForeColor = System.Drawing.Color.White;
            lbPassword.Location = new System.Drawing.Point(19, 150);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(93, 25);
            lbPassword.TabIndex = 4;
            lbPassword.Text = "Password";
            // 
            // lbCopyright
            // 
            lbCopyright.AutoSize = true;
            lbCopyright.BackColor = System.Drawing.Color.Transparent;
            lbCopyright.Font = new System.Drawing.Font("Ink Free", 15F);
            lbCopyright.ForeColor = System.Drawing.Color.White;
            lbCopyright.Location = new System.Drawing.Point(19, 297);
            lbCopyright.Name = "lbCopyright";
            lbCopyright.Size = new System.Drawing.Size(237, 25);
            lbCopyright.TabIndex = 5;
            lbCopyright.Text = "© 2013 - 2020 Ironiawn";
            // 
            // tbUsername
            // 
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(24, 117);
            this.tbUsername.MaxLength = 20;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(315, 26);
            this.tbUsername.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(24, 178);
            this.tbPassword.MaxLength = 50;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(315, 26);
            this.tbPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightCyan;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Ink Free", 15F);
            this.btnLogin.ForeColor = System.Drawing.Color.Gray;
            this.btnLogin.Location = new System.Drawing.Point(24, 241);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(121, 43);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbClose
            // 
            this.lbClose.BackColor = System.Drawing.Color.Transparent;
            this.lbClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbClose.BackgroundImage")));
            this.lbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbClose.Location = new System.Drawing.Point(328, 9);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(32, 32);
            this.lbClose.TabIndex = 7;
            this.lbClose.TabStop = false;
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.LightCyan;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Ink Free", 15F);
            this.btnRegister.ForeColor = System.Drawing.Color.Gray;
            this.btnRegister.Location = new System.Drawing.Point(218, 241);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(121, 43);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "SIGN UP";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lbLoginFeedback
            // 
            this.lbLoginFeedback.AutoSize = true;
            this.lbLoginFeedback.BackColor = System.Drawing.Color.Transparent;
            this.lbLoginFeedback.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.lbLoginFeedback.ForeColor = System.Drawing.Color.Red;
            this.lbLoginFeedback.Location = new System.Drawing.Point(20, 218);
            this.lbLoginFeedback.Name = "lbLoginFeedback";
            this.lbLoginFeedback.Size = new System.Drawing.Size(322, 20);
            this.lbLoginFeedback.TabIndex = 9;
            this.lbLoginFeedback.Text = "User or password is incorrect! Try again.";
            this.lbLoginFeedback.Visible = false;
            // 
            // IwP_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(372, 343);
            this.Controls.Add(this.lbLoginFeedback);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lbClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(lbCopyright);
            this.Controls.Add(lbPassword);
            this.Controls.Add(lbUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IwP_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IwPlay - Login";
            this.Load += new System.EventHandler(this.IwP_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox lbClose;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lbLoginFeedback;
    }
}


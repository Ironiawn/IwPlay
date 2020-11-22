namespace IwPlay
{
    partial class IwP_Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lbTitle;
            System.Windows.Forms.Label lbPassword;
            System.Windows.Forms.Label lbUsername;
            System.Windows.Forms.Label lbConfirmPassword;
            System.Windows.Forms.Label lbEmail;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IwP_Register));
            this.lbClose = new System.Windows.Forms.PictureBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pbBack = new System.Windows.Forms.PictureBox();
            lbTitle = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            lbUsername = new System.Windows.Forms.Label();
            lbConfirmPassword = new System.Windows.Forms.Label();
            lbEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
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
            lbTitle.TabIndex = 1;
            lbTitle.Text = "IwPlay";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.BackColor = System.Drawing.Color.Transparent;
            lbPassword.Font = new System.Drawing.Font("Ink Free", 15F);
            lbPassword.ForeColor = System.Drawing.Color.White;
            lbPassword.Location = new System.Drawing.Point(19, 139);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(93, 25);
            lbPassword.TabIndex = 12;
            lbPassword.Text = "Password";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.BackColor = System.Drawing.Color.Transparent;
            lbUsername.Font = new System.Drawing.Font("Ink Free", 15F);
            lbUsername.ForeColor = System.Drawing.Color.White;
            lbUsername.Location = new System.Drawing.Point(19, 78);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new System.Drawing.Size(95, 25);
            lbUsername.TabIndex = 11;
            lbUsername.Text = "Username";
            // 
            // lbConfirmPassword
            // 
            lbConfirmPassword.AutoSize = true;
            lbConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            lbConfirmPassword.Font = new System.Drawing.Font("Ink Free", 15F);
            lbConfirmPassword.ForeColor = System.Drawing.Color.White;
            lbConfirmPassword.Location = new System.Drawing.Point(19, 200);
            lbConfirmPassword.Name = "lbConfirmPassword";
            lbConfirmPassword.Size = new System.Drawing.Size(163, 25);
            lbConfirmPassword.TabIndex = 14;
            lbConfirmPassword.Text = "Confirm Password";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.BackColor = System.Drawing.Color.Transparent;
            lbEmail.Font = new System.Drawing.Font("Ink Free", 15F);
            lbEmail.ForeColor = System.Drawing.Color.White;
            lbEmail.Location = new System.Drawing.Point(19, 262);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(58, 25);
            lbEmail.TabIndex = 16;
            lbEmail.Text = "Email";
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
            this.lbClose.TabIndex = 8;
            this.lbClose.TabStop = false;
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(24, 167);
            this.tbPassword.MaxLength = 50;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(315, 26);
            this.tbPassword.TabIndex = 2;
            // 
            // tbUsername
            // 
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(24, 106);
            this.tbUsername.MaxLength = 20;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(315, 26);
            this.tbUsername.TabIndex = 1;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbConfirmPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmPassword.Location = new System.Drawing.Point(24, 228);
            this.tbConfirmPassword.MaxLength = 50;
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.Size = new System.Drawing.Size(315, 26);
            this.tbConfirmPassword.TabIndex = 3;
            // 
            // tbEmail
            // 
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(24, 290);
            this.tbEmail.MaxLength = 150;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(315, 26);
            this.tbEmail.TabIndex = 4;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.LightCyan;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Ink Free", 15F);
            this.btnRegister.ForeColor = System.Drawing.Color.Gray;
            this.btnRegister.Location = new System.Drawing.Point(81, 327);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(201, 43);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pbBack
            // 
            this.pbBack.BackColor = System.Drawing.Color.Transparent;
            this.pbBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBack.BackgroundImage")));
            this.pbBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBack.Location = new System.Drawing.Point(290, 9);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(32, 32);
            this.pbBack.TabIndex = 18;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // IwP_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(372, 382);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(lbEmail);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(lbConfirmPassword);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(lbPassword);
            this.Controls.Add(lbUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lbClose);
            this.Controls.Add(lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IwP_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IwPlay - Register";
            ((System.ComponentModel.ISupportInitialize)(this.lbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lbClose;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.PictureBox pbBack;
    }
}
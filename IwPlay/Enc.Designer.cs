namespace IwPlay
{
    partial class Enc
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
            System.Windows.Forms.Label lbUsername;
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            lbUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.White;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Ink Free", 15F);
            this.btnEncrypt.Location = new System.Drawing.Point(17, 69);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(143, 43);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Criptografar!";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.BackColor = System.Drawing.Color.Transparent;
            lbUsername.Font = new System.Drawing.Font("Ink Free", 15F);
            lbUsername.ForeColor = System.Drawing.Color.White;
            lbUsername.Location = new System.Drawing.Point(12, 9);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new System.Drawing.Size(62, 25);
            lbUsername.TabIndex = 8;
            lbUsername.Text = "Texto";
            // 
            // tbText
            // 
            this.tbText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbText.Location = new System.Drawing.Point(17, 37);
            this.tbText.MaxLength = 999999;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(938, 26);
            this.tbText.TabIndex = 1;
            // 
            // Enc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(970, 135);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(lbUsername);
            this.Controls.Add(this.tbText);
            this.Name = "Enc";
            this.Text = "Enc";
            this.Load += new System.EventHandler(this.Enc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox tbText;
    }
}
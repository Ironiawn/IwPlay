namespace IwPlay.Hosts.Secondary
{
    partial class HostSelf_GameEditor
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
            System.Windows.Forms.Label CurrentPaymentLinkLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostSelf_GameEditor));
            this.Developer = new System.Windows.Forms.Label();
            this.GameName = new System.Windows.Forms.Label();
            this.GameImage = new System.Windows.Forms.PictureBox();
            this.GamePriceLabel = new System.Windows.Forms.Label();
            this.CurrentGamePriceInput = new System.Windows.Forms.TextBox();
            this.UpdateGame = new System.Windows.Forms.Button();
            this.CheckFreeGame = new System.Windows.Forms.CheckBox();
            this.CurrentPaymentLinkInput = new System.Windows.Forms.TextBox();
            this.EditorHandler = new System.Windows.Forms.Panel();
            CurrentPaymentLinkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GameImage)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentPaymentLinkLabel
            // 
            CurrentPaymentLinkLabel.AutoSize = true;
            CurrentPaymentLinkLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CurrentPaymentLinkLabel.Location = new System.Drawing.Point(7, 408);
            CurrentPaymentLinkLabel.Name = "CurrentPaymentLinkLabel";
            CurrentPaymentLinkLabel.Size = new System.Drawing.Size(200, 30);
            CurrentPaymentLinkLabel.TabIndex = 23;
            CurrentPaymentLinkLabel.Text = "Current Payment Link";
            // 
            // Developer
            // 
            this.Developer.AutoSize = true;
            this.Developer.Font = new System.Drawing.Font("Arial", 14F);
            this.Developer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Developer.Location = new System.Drawing.Point(238, 31);
            this.Developer.Name = "Developer";
            this.Developer.Size = new System.Drawing.Size(132, 22);
            this.Developer.TabIndex = 17;
            this.Developer.Text = "%Developer%";
            // 
            // GameName
            // 
            this.GameName.AutoSize = true;
            this.GameName.Font = new System.Drawing.Font("Arial", 18F);
            this.GameName.Location = new System.Drawing.Point(238, 4);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(182, 27);
            this.GameName.TabIndex = 16;
            this.GameName.Text = "%GameName%";
            // 
            // GameImage
            // 
            this.GameImage.Location = new System.Drawing.Point(1, 4);
            this.GameImage.Name = "GameImage";
            this.GameImage.Size = new System.Drawing.Size(236, 309);
            this.GameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameImage.TabIndex = 15;
            this.GameImage.TabStop = false;
            // 
            // GamePriceLabel
            // 
            this.GamePriceLabel.AutoSize = true;
            this.GamePriceLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePriceLabel.Location = new System.Drawing.Point(7, 467);
            this.GamePriceLabel.Name = "GamePriceLabel";
            this.GamePriceLabel.Size = new System.Drawing.Size(185, 30);
            this.GamePriceLabel.TabIndex = 19;
            this.GamePriceLabel.Text = "Current Game Price";
            // 
            // CurrentGamePriceInput
            // 
            this.CurrentGamePriceInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentGamePriceInput.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentGamePriceInput.Location = new System.Drawing.Point(12, 500);
            this.CurrentGamePriceInput.MaxLength = 20;
            this.CurrentGamePriceInput.Name = "CurrentGamePriceInput";
            this.CurrentGamePriceInput.Size = new System.Drawing.Size(76, 29);
            this.CurrentGamePriceInput.TabIndex = 20;
            this.CurrentGamePriceInput.Text = "9,90";
            this.CurrentGamePriceInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CurrentGamePriceInput.TextChanged += new System.EventHandler(this.CurrentGamePriceInput_TextChanged);
            // 
            // UpdateGame
            // 
            this.UpdateGame.BackColor = System.Drawing.Color.Blue;
            this.UpdateGame.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.UpdateGame.Enabled = false;
            this.UpdateGame.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.UpdateGame.FlatAppearance.BorderSize = 3;
            this.UpdateGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.UpdateGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UpdateGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateGame.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateGame.ForeColor = System.Drawing.Color.White;
            this.UpdateGame.Image = ((System.Drawing.Image)(resources.GetObject("UpdateGame.Image")));
            this.UpdateGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateGame.Location = new System.Drawing.Point(688, 4);
            this.UpdateGame.Name = "UpdateGame";
            this.UpdateGame.Size = new System.Drawing.Size(170, 55);
            this.UpdateGame.TabIndex = 21;
            this.UpdateGame.Text = "Update\r\nGame Information";
            this.UpdateGame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateGame.UseVisualStyleBackColor = false;
            this.UpdateGame.Click += new System.EventHandler(this.UpdateGamePriceButton_Click);
            // 
            // CheckFreeGame
            // 
            this.CheckFreeGame.AutoSize = true;
            this.CheckFreeGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckFreeGame.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckFreeGame.Location = new System.Drawing.Point(94, 501);
            this.CheckFreeGame.Name = "CheckFreeGame";
            this.CheckFreeGame.Size = new System.Drawing.Size(98, 25);
            this.CheckFreeGame.TabIndex = 22;
            this.CheckFreeGame.Text = "Free Game";
            this.CheckFreeGame.UseVisualStyleBackColor = true;
            this.CheckFreeGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckFreeGame_MouseClick);
            // 
            // CurrentPaymentLinkInput
            // 
            this.CurrentPaymentLinkInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentPaymentLinkInput.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPaymentLinkInput.Location = new System.Drawing.Point(12, 441);
            this.CurrentPaymentLinkInput.MaxLength = 20;
            this.CurrentPaymentLinkInput.Name = "CurrentPaymentLinkInput";
            this.CurrentPaymentLinkInput.Size = new System.Drawing.Size(220, 29);
            this.CurrentPaymentLinkInput.TabIndex = 24;
            this.CurrentPaymentLinkInput.Text = "-";
            this.CurrentPaymentLinkInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CurrentPaymentLinkInput.TextChanged += new System.EventHandler(this.CurrentPaymentLinkInput_TextChanged);
            // 
            // EditorHandler
            // 
            this.EditorHandler.Location = new System.Drawing.Point(243, 65);
            this.EditorHandler.Name = "EditorHandler";
            this.EditorHandler.Size = new System.Drawing.Size(615, 492);
            this.EditorHandler.TabIndex = 25;
            // 
            // HostSelf_GameEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 569);
            this.Controls.Add(this.EditorHandler);
            this.Controls.Add(this.CurrentPaymentLinkInput);
            this.Controls.Add(CurrentPaymentLinkLabel);
            this.Controls.Add(this.CheckFreeGame);
            this.Controls.Add(this.UpdateGame);
            this.Controls.Add(this.CurrentGamePriceInput);
            this.Controls.Add(this.GamePriceLabel);
            this.Controls.Add(this.Developer);
            this.Controls.Add(this.GameName);
            this.Controls.Add(this.GameImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HostSelf_GameEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IwPlay - Game Editor";
            this.Load += new System.EventHandler(this.HostSelf_Load);
            this.Leave += new System.EventHandler(this.HostSelf_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.GameImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label Developer;
        public System.Windows.Forms.Label GameName;
        public System.Windows.Forms.PictureBox GameImage;
        public System.Windows.Forms.Label GamePriceLabel;
        private System.Windows.Forms.TextBox CurrentGamePriceInput;
        private System.Windows.Forms.Button UpdateGame;
        private System.Windows.Forms.CheckBox CheckFreeGame;
        private System.Windows.Forms.TextBox CurrentPaymentLinkInput;
        private System.Windows.Forms.Panel EditorHandler;
    }
}
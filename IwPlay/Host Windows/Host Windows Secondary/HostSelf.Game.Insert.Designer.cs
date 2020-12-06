
namespace IwPlay.Hosts.Secondary
{
    partial class HostSelf_GameEditor_Insert
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
            System.Windows.Forms.Label GameImageLabel;
            System.Windows.Forms.Label CurrentPaymentLinkLabel;
            System.Windows.Forms.Label GameNameLabel;
            System.Windows.Forms.Label DeveloperLabel;
            System.Windows.Forms.Label GameDescriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostSelf_GameEditor_Insert));
            this.GameImageLink = new System.Windows.Forms.TextBox();
            this.CurrentPaymentLinkInput = new System.Windows.Forms.TextBox();
            this.CheckFreeGame = new System.Windows.Forms.CheckBox();
            this.CurrentGamePriceInput = new System.Windows.Forms.TextBox();
            this.GamePriceLabel = new System.Windows.Forms.Label();
            this.GameImage = new System.Windows.Forms.PictureBox();
            this.GameNameInput = new System.Windows.Forms.TextBox();
            this.DeveloperFilter = new System.Windows.Forms.ComboBox();
            this.InsertGame = new System.Windows.Forms.Button();
            this.UpdateLinks = new System.Windows.Forms.Button();
            this.HTMLEditor = new DG.MiniHTMLTextBox.MiniHTMLTextBox();
            GameImageLabel = new System.Windows.Forms.Label();
            CurrentPaymentLinkLabel = new System.Windows.Forms.Label();
            GameNameLabel = new System.Windows.Forms.Label();
            DeveloperLabel = new System.Windows.Forms.Label();
            GameDescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GameImage)).BeginInit();
            this.SuspendLayout();
            // 
            // GameImageLabel
            // 
            GameImageLabel.AutoSize = true;
            GameImageLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            GameImageLabel.Location = new System.Drawing.Point(9, 321);
            GameImageLabel.Name = "GameImageLabel";
            GameImageLabel.Size = new System.Drawing.Size(166, 30);
            GameImageLabel.TabIndex = 34;
            GameImageLabel.Text = "Game Image Link";
            // 
            // CurrentPaymentLinkLabel
            // 
            CurrentPaymentLinkLabel.AutoSize = true;
            CurrentPaymentLinkLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CurrentPaymentLinkLabel.Location = new System.Drawing.Point(9, 386);
            CurrentPaymentLinkLabel.Name = "CurrentPaymentLinkLabel";
            CurrentPaymentLinkLabel.Size = new System.Drawing.Size(200, 30);
            CurrentPaymentLinkLabel.TabIndex = 32;
            CurrentPaymentLinkLabel.Text = "Current Payment Link";
            // 
            // GameNameLabel
            // 
            GameNameLabel.AutoSize = true;
            GameNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            GameNameLabel.Location = new System.Drawing.Point(240, 9);
            GameNameLabel.Name = "GameNameLabel";
            GameNameLabel.Size = new System.Drawing.Size(140, 30);
            GameNameLabel.TabIndex = 36;
            GameNameLabel.Text = "Product Name";
            // 
            // DeveloperLabel
            // 
            DeveloperLabel.AutoSize = true;
            DeveloperLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DeveloperLabel.Location = new System.Drawing.Point(484, 9);
            DeveloperLabel.Name = "DeveloperLabel";
            DeveloperLabel.Size = new System.Drawing.Size(178, 30);
            DeveloperLabel.TabIndex = 38;
            DeveloperLabel.Text = "Select a Developer";
            // 
            // GameDescriptionLabel
            // 
            GameDescriptionLabel.AutoSize = true;
            GameDescriptionLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            GameDescriptionLabel.Location = new System.Drawing.Point(240, 73);
            GameDescriptionLabel.Name = "GameDescriptionLabel";
            GameDescriptionLabel.Size = new System.Drawing.Size(169, 30);
            GameDescriptionLabel.TabIndex = 40;
            GameDescriptionLabel.Text = "Game Description";
            // 
            // GameImageLink
            // 
            this.GameImageLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameImageLink.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameImageLink.Location = new System.Drawing.Point(14, 354);
            this.GameImageLink.MaxLength = 1500;
            this.GameImageLink.Name = "GameImageLink";
            this.GameImageLink.Size = new System.Drawing.Size(220, 29);
            this.GameImageLink.TabIndex = 2;
            this.GameImageLink.Text = "-";
            this.GameImageLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CurrentPaymentLinkInput
            // 
            this.CurrentPaymentLinkInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentPaymentLinkInput.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPaymentLinkInput.Location = new System.Drawing.Point(14, 419);
            this.CurrentPaymentLinkInput.MaxLength = 1500;
            this.CurrentPaymentLinkInput.Name = "CurrentPaymentLinkInput";
            this.CurrentPaymentLinkInput.Size = new System.Drawing.Size(220, 29);
            this.CurrentPaymentLinkInput.TabIndex = 3;
            this.CurrentPaymentLinkInput.Text = "-";
            this.CurrentPaymentLinkInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CheckFreeGame
            // 
            this.CheckFreeGame.AutoSize = true;
            this.CheckFreeGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckFreeGame.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckFreeGame.Location = new System.Drawing.Point(96, 479);
            this.CheckFreeGame.Name = "CheckFreeGame";
            this.CheckFreeGame.Size = new System.Drawing.Size(98, 25);
            this.CheckFreeGame.TabIndex = 5;
            this.CheckFreeGame.Text = "Free Game";
            this.CheckFreeGame.UseVisualStyleBackColor = true;
            this.CheckFreeGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckFreeGame_MouseClick);
            // 
            // CurrentGamePriceInput
            // 
            this.CurrentGamePriceInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentGamePriceInput.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentGamePriceInput.Location = new System.Drawing.Point(14, 478);
            this.CurrentGamePriceInput.MaxLength = 20;
            this.CurrentGamePriceInput.Name = "CurrentGamePriceInput";
            this.CurrentGamePriceInput.Size = new System.Drawing.Size(76, 29);
            this.CurrentGamePriceInput.TabIndex = 4;
            this.CurrentGamePriceInput.Text = "9,90";
            this.CurrentGamePriceInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GamePriceLabel
            // 
            this.GamePriceLabel.AutoSize = true;
            this.GamePriceLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePriceLabel.Location = new System.Drawing.Point(9, 445);
            this.GamePriceLabel.Name = "GamePriceLabel";
            this.GamePriceLabel.Size = new System.Drawing.Size(185, 30);
            this.GamePriceLabel.TabIndex = 31;
            this.GamePriceLabel.Text = "Current Game Price";
            // 
            // GameImage
            // 
            this.GameImage.Image = ((System.Drawing.Image)(resources.GetObject("GameImage.Image")));
            this.GameImage.Location = new System.Drawing.Point(3, 9);
            this.GameImage.Name = "GameImage";
            this.GameImage.Size = new System.Drawing.Size(236, 309);
            this.GameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameImage.TabIndex = 30;
            this.GameImage.TabStop = false;
            // 
            // GameNameInput
            // 
            this.GameNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameNameInput.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameNameInput.Location = new System.Drawing.Point(245, 42);
            this.GameNameInput.MaxLength = 1500;
            this.GameNameInput.Name = "GameNameInput";
            this.GameNameInput.Size = new System.Drawing.Size(220, 29);
            this.GameNameInput.TabIndex = 1;
            this.GameNameInput.Text = "-";
            // 
            // DeveloperFilter
            // 
            this.DeveloperFilter.BackColor = System.Drawing.Color.White;
            this.DeveloperFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeveloperFilter.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeveloperFilter.ForeColor = System.Drawing.Color.Black;
            this.DeveloperFilter.FormattingEnabled = true;
            this.DeveloperFilter.ItemHeight = 25;
            this.DeveloperFilter.Location = new System.Drawing.Point(489, 38);
            this.DeveloperFilter.Name = "DeveloperFilter";
            this.DeveloperFilter.Size = new System.Drawing.Size(271, 33);
            this.DeveloperFilter.TabIndex = 7;
            // 
            // InsertGame
            // 
            this.InsertGame.BackColor = System.Drawing.Color.Blue;
            this.InsertGame.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.InsertGame.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.InsertGame.FlatAppearance.BorderSize = 3;
            this.InsertGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.InsertGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InsertGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertGame.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertGame.ForeColor = System.Drawing.Color.White;
            this.InsertGame.Image = ((System.Drawing.Image)(resources.GetObject("InsertGame.Image")));
            this.InsertGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InsertGame.Location = new System.Drawing.Point(775, 16);
            this.InsertGame.Name = "InsertGame";
            this.InsertGame.Size = new System.Drawing.Size(139, 55);
            this.InsertGame.TabIndex = 41;
            this.InsertGame.Text = "Set up Game";
            this.InsertGame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InsertGame.UseVisualStyleBackColor = false;
            this.InsertGame.Click += new System.EventHandler(this.InsertGame_Click);
            // 
            // UpdateLinks
            // 
            this.UpdateLinks.BackColor = System.Drawing.Color.DarkSlateGray;
            this.UpdateLinks.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.UpdateLinks.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.UpdateLinks.FlatAppearance.BorderSize = 3;
            this.UpdateLinks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.UpdateLinks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UpdateLinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateLinks.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateLinks.ForeColor = System.Drawing.Color.White;
            this.UpdateLinks.Image = ((System.Drawing.Image)(resources.GetObject("UpdateLinks.Image")));
            this.UpdateLinks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateLinks.Location = new System.Drawing.Point(54, 510);
            this.UpdateLinks.Name = "UpdateLinks";
            this.UpdateLinks.Size = new System.Drawing.Size(180, 55);
            this.UpdateLinks.TabIndex = 42;
            this.UpdateLinks.Text = "Verify and\r\nSync Information";
            this.UpdateLinks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateLinks.UseVisualStyleBackColor = false;
            this.UpdateLinks.Click += new System.EventHandler(this.UpdateLinks_Click);
            // 
            // HTMLEditor
            // 
            this.HTMLEditor.IllegalPatterns = new string[] {
        "<script.*?>",
        "<\\w+\\s+.*?(j|java|vb|ecma)script:.*?>",
        "<\\w+(\\s+|\\s+.*?\\s+)on\\w+\\s*=.+?>",
        "</?input.*?>"};
            this.HTMLEditor.Location = new System.Drawing.Point(245, 106);
            this.HTMLEditor.Name = "HTMLEditor";
            this.HTMLEditor.Padding = new System.Windows.Forms.Padding(1);
            this.HTMLEditor.Size = new System.Drawing.Size(667, 459);
            this.HTMLEditor.TabIndex = 43;
            this.HTMLEditor.Text = "<P style=\"COLOR: red\"><STRONG>Insert your game description here!</STRONG></P>";
            // 
            // HostSelf_GameEditor_Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 569);
            this.Controls.Add(this.HTMLEditor);
            this.Controls.Add(this.UpdateLinks);
            this.Controls.Add(this.InsertGame);
            this.Controls.Add(GameDescriptionLabel);
            this.Controls.Add(this.DeveloperFilter);
            this.Controls.Add(DeveloperLabel);
            this.Controls.Add(this.GameNameInput);
            this.Controls.Add(GameNameLabel);
            this.Controls.Add(this.GameImageLink);
            this.Controls.Add(GameImageLabel);
            this.Controls.Add(this.CurrentPaymentLinkInput);
            this.Controls.Add(CurrentPaymentLinkLabel);
            this.Controls.Add(this.CheckFreeGame);
            this.Controls.Add(this.CurrentGamePriceInput);
            this.Controls.Add(this.GamePriceLabel);
            this.Controls.Add(this.GameImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HostSelf_GameEditor_Insert";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IwPlay - Game Editor";
            this.Load += new System.EventHandler(this.HostSelf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GameImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GameImageLink;
        private System.Windows.Forms.TextBox CurrentPaymentLinkInput;
        private System.Windows.Forms.CheckBox CheckFreeGame;
        private System.Windows.Forms.TextBox CurrentGamePriceInput;
        public System.Windows.Forms.Label GamePriceLabel;
        public System.Windows.Forms.PictureBox GameImage;
        private System.Windows.Forms.TextBox GameNameInput;
        private System.Windows.Forms.ComboBox DeveloperFilter;
        private System.Windows.Forms.Button InsertGame;
        private System.Windows.Forms.Button UpdateLinks;
        private DG.MiniHTMLTextBox.MiniHTMLTextBox HTMLEditor;
    }
}
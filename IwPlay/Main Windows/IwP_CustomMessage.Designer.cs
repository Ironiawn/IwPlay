namespace IwPlay
{
    partial class IwP_CustomMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IwP_CustomMessage));
            this.ImageShow = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.Label();
            this.ActionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageShow
            // 
            this.ImageShow.Location = new System.Drawing.Point(13, 13);
            this.ImageShow.Name = "ImageShow";
            this.ImageShow.Size = new System.Drawing.Size(140, 141);
            this.ImageShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageShow.TabIndex = 0;
            this.ImageShow.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(436, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 9;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(170, 13);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(142, 25);
            this.Title.TabIndex = 10;
            this.Title.Text = "%WindowTitle%";
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Message.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.Location = new System.Drawing.Point(170, 56);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(178, 25);
            this.Message.TabIndex = 11;
            this.Message.Text = "%WindowMessage%";
            // 
            // ActionButton
            // 
            this.ActionButton.BackColor = System.Drawing.Color.LightCyan;
            this.ActionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActionButton.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionButton.ForeColor = System.Drawing.Color.Gray;
            this.ActionButton.Location = new System.Drawing.Point(290, 111);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(178, 43);
            this.ActionButton.TabIndex = 12;
            this.ActionButton.Text = "%ActionMessage%";
            this.ActionButton.UseVisualStyleBackColor = false;
            // 
            // IwP_CustomMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 166);
            this.Controls.Add(this.ActionButton);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ImageShow);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IwP_CustomMessage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IwPlay - Message";
            this.Load += new System.EventHandler(this.IwP_CustomMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnClose;
        protected internal System.Windows.Forms.Label Title;
        protected internal System.Windows.Forms.Label Message;
        protected internal System.Windows.Forms.PictureBox ImageShow;
        private System.Windows.Forms.Button ActionButton;
    }
}
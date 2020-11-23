namespace IwPlay
{
    partial class IwP_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IwP_Home));
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.lbUserDetails = new System.Windows.Forms.Label();
            this.pbUserPic = new System.Windows.Forms.PictureBox();
            this.btnUserLibrary = new System.Windows.Forms.Button();
            this.Host = new System.Windows.Forms.Panel();
            this.WalletPic = new System.Windows.Forms.PictureBox();
            this.WalletBalance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WalletPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbClose.BackgroundImage")));
            this.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Location = new System.Drawing.Point(1384, 12);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(32, 32);
            this.pbClose.TabIndex = 9;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pbMinimize
            // 
            this.pbMinimize.BackColor = System.Drawing.Color.Transparent;
            this.pbMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMinimize.BackgroundImage")));
            this.pbMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimize.Location = new System.Drawing.Point(1346, 12);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(32, 32);
            this.pbMinimize.TabIndex = 10;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.LightCyan;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Ink Free", 15F);
            this.btnHome.ForeColor = System.Drawing.Color.Gray;
            this.btnHome.Location = new System.Drawing.Point(12, 98);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(170, 55);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "IwPlay";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lbUserDetails
            // 
            this.lbUserDetails.AutoSize = true;
            this.lbUserDetails.BackColor = System.Drawing.Color.Transparent;
            this.lbUserDetails.Font = new System.Drawing.Font("Ink Free", 14F);
            this.lbUserDetails.ForeColor = System.Drawing.Color.White;
            this.lbUserDetails.Location = new System.Drawing.Point(94, 13);
            this.lbUserDetails.Name = "lbUserDetails";
            this.lbUserDetails.Size = new System.Drawing.Size(141, 23);
            this.lbUserDetails.TabIndex = 12;
            this.lbUserDetails.Text = "%UserDetails%";
            // 
            // pbUserPic
            // 
            this.pbUserPic.Location = new System.Drawing.Point(24, 13);
            this.pbUserPic.Name = "pbUserPic";
            this.pbUserPic.Size = new System.Drawing.Size(64, 64);
            this.pbUserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserPic.TabIndex = 14;
            this.pbUserPic.TabStop = false;
            // 
            // btnUserLibrary
            // 
            this.btnUserLibrary.BackColor = System.Drawing.Color.LightCyan;
            this.btnUserLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserLibrary.Font = new System.Drawing.Font("Ink Free", 15F);
            this.btnUserLibrary.ForeColor = System.Drawing.Color.Gray;
            this.btnUserLibrary.Location = new System.Drawing.Point(12, 159);
            this.btnUserLibrary.Name = "btnUserLibrary";
            this.btnUserLibrary.Size = new System.Drawing.Size(170, 55);
            this.btnUserLibrary.TabIndex = 15;
            this.btnUserLibrary.Text = "Library";
            this.btnUserLibrary.UseVisualStyleBackColor = false;
            this.btnUserLibrary.Click += new System.EventHandler(this.btnUserLibrary_Click);
            // 
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(188, 50);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(1228, 623);
            this.Host.TabIndex = 16;
            // 
            // WalletPic
            // 
            this.WalletPic.Image = ((System.Drawing.Image)(resources.GetObject("WalletPic.Image")));
            this.WalletPic.Location = new System.Drawing.Point(12, 654);
            this.WalletPic.Name = "WalletPic";
            this.WalletPic.Size = new System.Drawing.Size(24, 24);
            this.WalletPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WalletPic.TabIndex = 17;
            this.WalletPic.TabStop = false;
            // 
            // WalletBalance
            // 
            this.WalletBalance.AutoSize = true;
            this.WalletBalance.BackColor = System.Drawing.Color.Transparent;
            this.WalletBalance.Font = new System.Drawing.Font("Ink Free", 14F);
            this.WalletBalance.ForeColor = System.Drawing.Color.White;
            this.WalletBalance.Location = new System.Drawing.Point(42, 654);
            this.WalletBalance.Name = "WalletBalance";
            this.WalletBalance.Size = new System.Drawing.Size(55, 23);
            this.WalletBalance.TabIndex = 18;
            this.WalletBalance.Text = "IP$0";
            // 
            // IwP_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1424, 685);
            this.Controls.Add(this.WalletBalance);
            this.Controls.Add(this.WalletPic);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.btnUserLibrary);
            this.Controls.Add(this.pbUserPic);
            this.Controls.Add(this.lbUserDetails);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.pbMinimize);
            this.Controls.Add(this.pbClose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IwP_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IwPlay Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IwP_Home_FormClosing);
            this.Load += new System.EventHandler(this.IwP_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WalletPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lbUserDetails;
        private System.Windows.Forms.PictureBox pbUserPic;
        private System.Windows.Forms.Button btnUserLibrary;
        private System.Windows.Forms.Panel Host;
        private System.Windows.Forms.Label WalletBalance;
        private System.Windows.Forms.PictureBox WalletPic;
    }
}
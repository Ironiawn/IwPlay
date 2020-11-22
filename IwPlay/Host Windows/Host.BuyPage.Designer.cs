namespace IwPlay.Hosts
{
    partial class BuyPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyPage));
            this.BrowserHost = new System.Windows.Forms.Panel();
            this.BuyUsingFunds = new System.Windows.Forms.Button();
            this.CurrentFunds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BrowserHost
            // 
            this.BrowserHost.Location = new System.Drawing.Point(0, 73);
            this.BrowserHost.Name = "BrowserHost";
            this.BrowserHost.Size = new System.Drawing.Size(944, 490);
            this.BrowserHost.TabIndex = 0;
            // 
            // BuyUsingFunds
            // 
            this.BuyUsingFunds.BackColor = System.Drawing.Color.DodgerBlue;
            this.BuyUsingFunds.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BuyUsingFunds.FlatAppearance.BorderSize = 3;
            this.BuyUsingFunds.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BuyUsingFunds.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.BuyUsingFunds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyUsingFunds.Font = new System.Drawing.Font("Arial", 12F);
            this.BuyUsingFunds.ForeColor = System.Drawing.Color.White;
            this.BuyUsingFunds.Image = ((System.Drawing.Image)(resources.GetObject("BuyUsingFunds.Image")));
            this.BuyUsingFunds.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuyUsingFunds.Location = new System.Drawing.Point(12, 12);
            this.BuyUsingFunds.Name = "BuyUsingFunds";
            this.BuyUsingFunds.Size = new System.Drawing.Size(186, 55);
            this.BuyUsingFunds.TabIndex = 14;
            this.BuyUsingFunds.Text = "Buy using\r\nPlayFunds!";
            this.BuyUsingFunds.UseVisualStyleBackColor = false;
            this.BuyUsingFunds.Click += new System.EventHandler(this.BuyUsingFunds_Click);
            // 
            // CurrentFunds
            // 
            this.CurrentFunds.AutoSize = true;
            this.CurrentFunds.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentFunds.ForeColor = System.Drawing.Color.White;
            this.CurrentFunds.Location = new System.Drawing.Point(225, 12);
            this.CurrentFunds.Name = "CurrentFunds";
            this.CurrentFunds.Size = new System.Drawing.Size(104, 18);
            this.CurrentFunds.TabIndex = 15;
            this.CurrentFunds.Text = "%CurFunds%";
            // 
            // BuyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(942, 563);
            this.Controls.Add(this.CurrentFunds);
            this.Controls.Add(this.BuyUsingFunds);
            this.Controls.Add(this.BrowserHost);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuyPage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IwPlay - Game Buy";
            this.Load += new System.EventHandler(this.Host_Load);
            this.Leave += new System.EventHandler(this.BuyPage_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BrowserHost;
        private System.Windows.Forms.Button BuyUsingFunds;
        private System.Windows.Forms.Label CurrentFunds;
    }
}
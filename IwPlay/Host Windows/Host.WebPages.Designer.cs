namespace IwPlay.Hosts
{
    partial class HostPages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostPages));
            this.BrowserHost = new System.Windows.Forms.Panel();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbForward = new System.Windows.Forms.PictureBox();
            this.pbReload = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReload)).BeginInit();
            this.SuspendLayout();
            // 
            // BrowserHost
            // 
            this.BrowserHost.Location = new System.Drawing.Point(0, 38);
            this.BrowserHost.Name = "BrowserHost";
            this.BrowserHost.Size = new System.Drawing.Size(1228, 585);
            this.BrowserHost.TabIndex = 0;
            // 
            // pbBack
            // 
            this.pbBack.BackColor = System.Drawing.Color.Transparent;
            this.pbBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBack.BackgroundImage")));
            this.pbBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBack.Location = new System.Drawing.Point(3, 3);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(32, 32);
            this.pbBack.TabIndex = 19;
            this.pbBack.TabStop = false;
            // 
            // pbForward
            // 
            this.pbForward.BackColor = System.Drawing.Color.Transparent;
            this.pbForward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbForward.BackgroundImage")));
            this.pbForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbForward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbForward.Location = new System.Drawing.Point(41, 3);
            this.pbForward.Name = "pbForward";
            this.pbForward.Size = new System.Drawing.Size(32, 32);
            this.pbForward.TabIndex = 20;
            this.pbForward.TabStop = false;
            // 
            // pbReload
            // 
            this.pbReload.BackColor = System.Drawing.Color.Transparent;
            this.pbReload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbReload.BackgroundImage")));
            this.pbReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbReload.Location = new System.Drawing.Point(79, 3);
            this.pbReload.Name = "pbReload";
            this.pbReload.Size = new System.Drawing.Size(32, 32);
            this.pbReload.TabIndex = 21;
            this.pbReload.TabStop = false;
            // 
            // HostPages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pbReload);
            this.Controls.Add(this.pbForward);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.BrowserHost);
            this.DoubleBuffered = true;
            this.Name = "HostPages";
            this.Size = new System.Drawing.Size(1228, 623);
            this.Load += new System.EventHandler(this.Host_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReload)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BrowserHost;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbForward;
        private System.Windows.Forms.PictureBox pbReload;
    }
}

namespace IwPlay.Hosts
{
    partial class HostLibrary
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
        [System.STAThread]
        private void InitializeComponent()
        {
            System.Windows.Forms.Label FilterLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostLibrary));
            this.Flow = new System.Windows.Forms.FlowLayoutPanel();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.lbLoading = new System.Windows.Forms.Label();
            this.Filter = new System.Windows.Forms.ComboBox();
            FilterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // FilterLabel
            // 
            FilterLabel.AutoSize = true;
            FilterLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            FilterLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            FilterLabel.ForeColor = System.Drawing.Color.White;
            FilterLabel.Location = new System.Drawing.Point(4, 4);
            FilterLabel.Name = "FilterLabel";
            FilterLabel.Size = new System.Drawing.Size(66, 30);
            FilterLabel.TabIndex = 3;
            FilterLabel.Text = "Show ";
            // 
            // Flow
            // 
            this.Flow.AutoScroll = true;
            this.Flow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Flow.BackColor = System.Drawing.Color.Black;
            this.Flow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Flow.Location = new System.Drawing.Point(0, 43);
            this.Flow.Name = "Flow";
            this.Flow.Size = new System.Drawing.Size(1228, 580);
            this.Flow.TabIndex = 0;
            this.Flow.WrapContents = false;
            // 
            // pbLoading
            // 
            this.pbLoading.Image = ((System.Drawing.Image)(resources.GetObject("pbLoading.Image")));
            this.pbLoading.Location = new System.Drawing.Point(340, 53);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(460, 460);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLoading.TabIndex = 1;
            this.pbLoading.TabStop = false;
            // 
            // lbLoading
            // 
            this.lbLoading.AutoSize = true;
            this.lbLoading.BackColor = System.Drawing.Color.Black;
            this.lbLoading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbLoading.Font = new System.Drawing.Font("Ink Free", 25F);
            this.lbLoading.ForeColor = System.Drawing.Color.White;
            this.lbLoading.Location = new System.Drawing.Point(385, 541);
            this.lbLoading.Name = "lbLoading";
            this.lbLoading.Size = new System.Drawing.Size(357, 42);
            this.lbLoading.TabIndex = 2;
            this.lbLoading.Text = "Loading IwPlay Library";
            // 
            // Filter
            // 
            this.Filter.BackColor = System.Drawing.Color.White;
            this.Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Filter.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter.ForeColor = System.Drawing.Color.Black;
            this.Filter.FormattingEnabled = true;
            this.Filter.Items.AddRange(new object[] {
            "ITEMS THAT I BOUGHT",
            "MY PUBLISHED ITEMS",
            "ITEMS THAT IS PENDING APPROVAL",
            "ALL MY DEV. ITEMS",
            "ALL GAMES"});
            this.Filter.Location = new System.Drawing.Point(66, 4);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(365, 33);
            this.Filter.TabIndex = 1;
            this.Filter.SelectedIndexChanged += new System.EventHandler(this.Filter_SelectedIndexChanged);
            // 
            // HostLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.Filter);
            this.Controls.Add(FilterLabel);
            this.Controls.Add(this.lbLoading);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.Flow);
            this.DoubleBuffered = true;
            this.Name = "HostLibrary";
            this.Size = new System.Drawing.Size(1228, 623);
            this.Load += new System.EventHandler(this.Host_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Flow;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.Label lbLoading;
        private System.Windows.Forms.ComboBox Filter;
    }
}

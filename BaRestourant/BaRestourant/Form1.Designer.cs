namespace BaRestourant
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsiMasalar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSiparisler = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiAyarlar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiMenuAyarlari = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiMasaAyarlari = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiMasalar,
            this.tsiSiparisler,
            this.tsiAyarlar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsiMasalar
            // 
            this.tsiMasalar.Name = "tsiMasalar";
            this.tsiMasalar.Size = new System.Drawing.Size(60, 20);
            this.tsiMasalar.Text = "Masalar";
            // 
            // tsiSiparisler
            // 
            this.tsiSiparisler.Name = "tsiSiparisler";
            this.tsiSiparisler.Size = new System.Drawing.Size(66, 20);
            this.tsiSiparisler.Text = "Siparişler";
            // 
            // tsiAyarlar
            // 
            this.tsiAyarlar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiMenuAyarlari,
            this.tsiMasaAyarlari});
            this.tsiAyarlar.Name = "tsiAyarlar";
            this.tsiAyarlar.Size = new System.Drawing.Size(56, 20);
            this.tsiAyarlar.Text = "Ayarlar";
            // 
            // tsiMenuAyarlari
            // 
            this.tsiMenuAyarlari.Name = "tsiMenuAyarlari";
            this.tsiMenuAyarlari.Size = new System.Drawing.Size(148, 22);
            this.tsiMenuAyarlari.Text = "Menu Ayarları";
            this.tsiMenuAyarlari.Click += new System.EventHandler(this.tsiMenuAyarlari_Click);
            // 
            // tsiMasaAyarlari
            // 
            this.tsiMasaAyarlari.Name = "tsiMasaAyarlari";
            this.tsiMasaAyarlari.Size = new System.Drawing.Size(148, 22);
            this.tsiMasaAyarlari.Text = "Masa Ayarları";
            this.tsiMasaAyarlari.Click += new System.EventHandler(this.tsiMasaAyarlari_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 351);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsiMasalar;
        private System.Windows.Forms.ToolStripMenuItem tsiSiparisler;
        private System.Windows.Forms.ToolStripMenuItem tsiAyarlar;
        private System.Windows.Forms.ToolStripMenuItem tsiMenuAyarlari;
        private System.Windows.Forms.ToolStripMenuItem tsiMasaAyarlari;
    }
}


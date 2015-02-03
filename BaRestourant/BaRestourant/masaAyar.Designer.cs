namespace BaRestourant
{
    partial class masaAyar
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
            this.components = new System.ComponentModel.Container();
            this.cmsMasaAyar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsiYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiYeniMasa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMasaAyar.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsMasaAyar
            // 
            this.cmsMasaAyar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiYeni,
            this.tsiDuzenle});
            this.cmsMasaAyar.Name = "cmsMasaAyar";
            this.cmsMasaAyar.Size = new System.Drawing.Size(153, 70);
            // 
            // tsiYeni
            // 
            this.tsiYeni.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiYeniMasa});
            this.tsiYeni.Name = "tsiYeni";
            this.tsiYeni.Size = new System.Drawing.Size(152, 22);
            this.tsiYeni.Text = "Yeni";
            // 
            // tsiYeniMasa
            // 
            this.tsiYeniMasa.Name = "tsiYeniMasa";
            this.tsiYeniMasa.Size = new System.Drawing.Size(102, 22);
            this.tsiYeniMasa.Text = "Masa";
            this.tsiYeniMasa.Click += new System.EventHandler(this.tsiYeniMasa_Click);
            // 
            // tsiDuzenle
            // 
            this.tsiDuzenle.Name = "tsiDuzenle";
            this.tsiDuzenle.Size = new System.Drawing.Size(152, 22);
            this.tsiDuzenle.Text = "Düzenle";
            this.tsiDuzenle.Click += new System.EventHandler(this.tsiDuzenle_Click);
            // 
            // masaAyar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 343);
            this.Name = "masaAyar";
            this.Text = "masaAyar";
            this.Load += new System.EventHandler(this.masaAyar_Load);
            this.cmsMasaAyar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmsMasaAyar;
        private System.Windows.Forms.ToolStripMenuItem tsiYeni;
        private System.Windows.Forms.ToolStripMenuItem tsiYeniMasa;
        private System.Windows.Forms.ToolStripMenuItem tsiDuzenle;
    }
}
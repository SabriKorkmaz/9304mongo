namespace BaRestourant
{
    partial class adisyonFormu
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
            this.lbxSiparisler = new System.Windows.Forms.ListBox();
            this.cmbUrunler = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnMasaAc = new System.Windows.Forms.Button();
            this.grpSiparis = new System.Windows.Forms.GroupBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.grpSiparis.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxSiparisler
            // 
            this.lbxSiparisler.FormattingEnabled = true;
            this.lbxSiparisler.Location = new System.Drawing.Point(145, 19);
            this.lbxSiparisler.Name = "lbxSiparisler";
            this.lbxSiparisler.Size = new System.Drawing.Size(169, 277);
            this.lbxSiparisler.TabIndex = 0;
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.Location = new System.Drawing.Point(6, 48);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(121, 21);
            this.cmbUrunler.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(20, 143);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(2, 11);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 23);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Masa Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnMasaAc
            // 
            this.btnMasaAc.Location = new System.Drawing.Point(2, 46);
            this.btnMasaAc.Name = "btnMasaAc";
            this.btnMasaAc.Size = new System.Drawing.Size(75, 23);
            this.btnMasaAc.TabIndex = 4;
            this.btnMasaAc.Text = "Masa Aç";
            this.btnMasaAc.UseVisualStyleBackColor = true;
            this.btnMasaAc.Click += new System.EventHandler(this.btnMasaAc_Click);
            // 
            // grpSiparis
            // 
            this.grpSiparis.Controls.Add(this.txtAdet);
            this.grpSiparis.Controls.Add(this.lbxSiparisler);
            this.grpSiparis.Controls.Add(this.btnEkle);
            this.grpSiparis.Controls.Add(this.cmbUrunler);
            this.grpSiparis.Location = new System.Drawing.Point(129, 12);
            this.grpSiparis.Name = "grpSiparis";
            this.grpSiparis.Size = new System.Drawing.Size(342, 329);
            this.grpSiparis.TabIndex = 5;
            this.grpSiparis.TabStop = false;
            this.grpSiparis.Text = "Sipariş İşlemleri";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(7, 88);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(57, 20);
            this.txtAdet.TabIndex = 3;
            // 
            // adisyonFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 456);
            this.Controls.Add(this.grpSiparis);
            this.Controls.Add(this.btnMasaAc);
            this.Controls.Add(this.btnKapat);
            this.Name = "adisyonFormu";
            this.Load += new System.EventHandler(this.adisyonFormu_Load);
            this.grpSiparis.ResumeLayout(false);
            this.grpSiparis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxSiparisler;
        private System.Windows.Forms.ComboBox cmbUrunler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnMasaAc;
        private System.Windows.Forms.GroupBox grpSiparis;
        private System.Windows.Forms.TextBox txtAdet;
    }
}
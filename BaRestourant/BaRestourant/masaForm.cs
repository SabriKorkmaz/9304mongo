using BaRestourant.Models;
using BaRestourant.Service;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaRestourant
{
    public partial class masaForm : Form
    {

        private Button buton;
        private bool yeniKayitmi;
        private masaAyar eklenecekYer;
        private MongoProvider provider = new MongoProvider();
        public masaForm(masaAyar control)
        {
            InitializeComponent();
            buton = new Button();
            eklenecekYer = control;
            yeniKayitmi = true;
        }
        
        public masaForm(masaAyar control,Button tiklanan)
        {
            InitializeComponent();
            eklenecekYer = control;
            this.buton = tiklanan;
            yeniKayitmi = false;
            ObjectId masaId = (ObjectId)tiklanan.Tag;
            Masa ms = provider.Masa.Find(masaId);
            txtMasaAdi.Text = ms.Ad;
        }


        private void masaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(yeniKayitmi)
            {
                Masa ms = new Masa();
                ms.Ad = txtMasaAdi.Text;
                ms.Top = 10;
                ms.Left = 10;
                provider.Masa.Insert(ms);
                buton.Text = ms.Ad;
                buton.Tag = ms.Id;
                buton.Top = ms.Top;
                buton.Left = ms.Left;
           //     buton.Click += eklenecekYer.btn_Click;
                buton.MouseDown += eklenecekYer.btn_MouseDown;
                buton.MouseUp += eklenecekYer.btn_MouseUp;
                buton.MouseMove += eklenecekYer.btn_MouseMove;
                eklenecekYer.Controls.Add(buton);
              
            }
            else
            {
                buton.Text = txtMasaAdi.Text;
            }
            this.Close();

        }

    
    }
}

using BaRestourant.Models;
using BaRestourant.Service;
using MongoDB.Driver.Builders;
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
    public partial class menuAyar : Form
    {
        MongoProvider provider = new MongoProvider();
        List<Urun> urnList;
        bool isUpdate;
        public menuAyar()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(!isUpdate)
            {
                Urun urn = new Urun();
                urn.Ad = txtUrunAd.Text;
                decimal tempValue = 0;
                decimal.TryParse(txtUrunFiyat.Text, out tempValue);
                urn.Fiyat = tempValue;
                provider.Urun.Insert(urn);
                urnList.Add(urn);
                lbxUrunler.DataSource = urnList.ToList();
            }
            else
            {
                 decimal tempVal = 0;
                decimal.TryParse(txtUrunFiyat.Text,out tempVal);
                Urun urn = lbxUrunler.SelectedItem as Urun;
               var builder = Update<Urun>.Set(x => x.Ad, txtUrunAd.Text)
                             .Set(x => x.Fiyat, tempVal);
               provider.Urun.Update(builder, urn.Id);
               isUpdate = false;
               btnKaydet.Text = "Kaydet";

            }
       
         
        }

        private void menuAyar_Load(object sender, EventArgs e)
        {
            urnList = provider.Urun.Get();
            lbxUrunler.DataSource = urnList;
        }

        private void lbxUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Urun selected = lbxUrunler.SelectedItem as Urun;
            txtUrunAd.Text = selected.Ad;
            txtUrunFiyat.Text = selected.Fiyat.ToString();
        }

        private void tsmDuzenle_Click(object sender, EventArgs e)
        {
            isUpdate = true;
            btnKaydet.Text = "Düzenle";
          
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek istediğinize eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result==DialogResult.Yes)
            {
                Urun urn = lbxUrunler.SelectedItem as Urun;
                provider.Urun.Remove(urn.Id);
                urnList.Remove(urn);
                lbxUrunler.DataSource = urnList.ToList();
            }
        }
    }
}

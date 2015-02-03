using BaRestourant.Models;
using BaRestourant.Service;
using BaRestourant.Types;
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
    public partial class adisyonFormu : Form
    {

        Button tiklanan;
        Masa secilen;
        List<AdisyonDetayType> detaylar;
        MongoProvider provider = new MongoProvider();
        Adisyon ads;
        public adisyonFormu(Button btn)
        {
            InitializeComponent();
            secilen = btn.Tag as Masa;
            tiklanan = btn;
            ads = provider.Adisyon.FirstOrDefault(x => x.MasaId == secilen.Id && x.Aktifmi);
        }

        private void adisyonFormu_Load(object sender, EventArgs e)
        {
            List<Urun> urnListesi = provider.Urun.Get();
            cmbUrunler.DataSource = urnListesi;
            if (!secilen.MasaDolumu)
            {
                btnKapat.Enabled = grpSiparis.Enabled = false;

            }
            else
            {
                btnMasaAc.Enabled = false;

            }
            DetayDoldur();
        }

        private void DetayDoldur()
        {
            if (ads != null)
            {
                detaylar = provider.AdisyonDetay.Get<AdisyonDetayType>(x => x.AdisyonId == ads.Id,
                   x => new AdisyonDetayType
                   {
                       Id = x.Id,
                       Adet = x.Adet,
                       ToplamTutar = x.ToplamTutar,
                       UrunAdi = provider.Urun.FirstOrDefault(z => z.Id == x.UrunId).Ad,
                   });
                lbxSiparisler.DataSource = detaylar;
            }
            else
            {
                detaylar = new List<AdisyonDetayType>();
            }

        }

        private void btnMasaAc_Click(object sender, EventArgs e)
        {
            grpSiparis.Enabled = true;
            tiklanan.BackColor = Color.Red;
            secilen.MasaDolumu = true;
            var builder = Update<Masa>.Set(x => x.MasaDolumu, true);
            provider.Masa.Update(builder, secilen.Id);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urun urn = cmbUrunler.SelectedItem as Urun;

            if (!(provider.Adisyon.Any(x => x.MasaId == secilen.Id)))
            {
                ads = new Adisyon();
                ads.Aktifmi = true;
                ads.MasaId = secilen.Id;
                ads.Tarih = DateTime.Now;
                ads.ToplamTutar = urn.Fiyat * Convert.ToInt32(txtAdet.Text);
                provider.Adisyon.Insert(ads);


            }

            AdisyonDetay detay = provider.AdisyonDetay.FirstOrDefault(x => x.AdisyonId == ads.Id && x.UrunId == urn.Id);

            if (detay != null)
            {
                var builder = Update<AdisyonDetay>.
                    Set(x => x.Adet, detay.Adet + Convert.ToInt32(txtAdet.Text))
                    .Set(x => x.ToplamTutar, detay.ToplamTutar + (Convert.ToInt32(txtAdet.Text) * urn.Fiyat));
                provider.AdisyonDetay.Update(builder, detay.Id);
                var eskiDetay = detaylar.FirstOrDefault(x => x.Id == detay.Id);
                eskiDetay.Adet = Convert.ToInt32(txtAdet.Text);
                lbxSiparisler.DataSource = detaylar.ToList();

            }
            else
            {
                detay = new AdisyonDetay();
                detay.Adet = Convert.ToInt32(txtAdet.Text);
                detay.AdisyonId = ads.Id;
                detay.UrunId = urn.Id;
                detay.ToplamTutar = detay.Adet * urn.Fiyat;
                provider.AdisyonDetay.Insert(detay);
                AdisyonDetayType type = new AdisyonDetayType
                {
                    Adet = Convert.ToInt32(txtAdet.Text),
                    Id = detay.Id,
                    UrunAdi = urn.Ad,
                    ToplamTutar = detay.Adet * urn.Fiyat,
                };
                detaylar.Add(type);
                lbxSiparisler.DataSource = detaylar.ToList();
            }


        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            
            decimal toplamTutar =0;
            foreach(var item in detaylar)
            {
                toplamTutar+=item.ToplamTutar;
            }

            string onayText = String.Format("{0} ₺ ödeme alındı mı?",toplamTutar);
            DialogResult result = MessageBox.Show(onayText,"Onay",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(result==DialogResult.Yes)
            {
                KasaHareket haraket = new KasaHareket();
                haraket.GirenPara = toplamTutar;
                haraket.Time = DateTime.Now;
                provider.KasaHaraket.Insert(haraket);
                tiklanan.BackColor = Color.Green;
                var builder = Update<Masa>.Set(x => x.MasaDolumu, false);
                provider.Masa.Update(builder, secilen.Id);
                var adisyonBuilder = Update<Adisyon>.Set(x => x.Aktifmi, false);
                provider.Adisyon.Update(adisyonBuilder, ads.Id);
                tiklanan.Tag = secilen;
                this.Close();
            }
        }
    }
}

using BaRestourant.Models;
using BaRestourant.Service;
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
    public partial class MainForm : Form
    {


        MongoProvider provider = new MongoProvider();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<Masa> masaListesi = provider.Masa.Get();
            foreach (var item in masaListesi)
            {
                Button btn = new Button();
                btn.BackColor = item.MasaDolumu ? Color.Red : Color.Green;
                btn.Text = item.Ad;
                btn.Left = item.Left;
                btn.Top = item.Top;
                btn.Tag = item;
                btn.Click += btn_Click;
                this.Controls.Add(btn);
            }

        }

        void btn_Click(object sender, EventArgs e)
        {
            Button tiklanan = sender as Button;
            adisyonFormu form = new adisyonFormu(tiklanan);
            form.ShowDialog();
        }
    }
}

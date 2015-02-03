using BaRestourant.Models;
using BaRestourant.Service;
using MongoDB.Bson;
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
    public partial class masaAyar : Form
    {

        private MongoProvider provider = new MongoProvider();

        bool isDragging = false;
        Point ofSet;
        Button lastSelected;
        public masaAyar()
        {
            InitializeComponent();

        }

        private void masaAyar_Load(object sender, EventArgs e)
        {
          
            MasaDoldur();
        }

        private void MasaDoldur()
        {
            List<Masa> masaList = provider.Masa.Get();
            foreach (var item in masaList)
            {
                Button btn = new Button();
                btn.Left = item.Left;
                btn.Text = item.Ad;
                btn.Top = item.Top;
                btn.Tag = item.Id;
                btn.ContextMenuStrip = cmsMasaAyar;
                btn.MouseDown += btn_MouseDown;
                btn.MouseMove += btn_MouseMove;
                btn.MouseUp += btn_MouseUp;
           //     btn.Click += btn_Click;
                this.Controls.Add(btn);
            }

        }

        //public void btn_Click(object sender, EventArgs e)
        //{
        //    var mouseEvent = e as MouseEventArgs;
        //    if(mouseEvent.Button== MouseButtons.Right)
        //    {
        //        lastSelected = sender as Button;
        //    }
        //}

        public void btn_MouseUp(object sender, MouseEventArgs e)
        {
            Button buton = sender as Button;
            var builder = Update<Masa>
                .Set(x => x.Left, buton.Left)
                .Set(x => x.Top, buton.Top);
            ObjectId id = (ObjectId)buton.Tag;

            provider.Masa.Update(builder, id);
            isDragging = false;
        }

        public void btn_MouseMove(object sender, MouseEventArgs e)
        {
            Button secilen = sender as Button;
            if (isDragging)
            {
                Point newPoint = secilen.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(ofSet);
                secilen.Location = newPoint;
            }

        }

        public void btn_MouseDown(object sender, MouseEventArgs e)
        {
            Button tiklanan = sender as Button;
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;

                Point startPosition = tiklanan.PointToScreen(new Point(e.X, e.Y));
                ofSet = new Point();
                ofSet.X = tiklanan.Location.X - startPosition.X;
                ofSet.Y = tiklanan.Location.Y - startPosition.Y;

            }
            else if(e.Button==MouseButtons.Right)
            {
                lastSelected = tiklanan;
            }

        }

        private void tsiYeniMasa_Click(object sender, EventArgs e)
        {
            masaForm masa = new masaForm(this);
            masa.ShowDialog();
        }

        private void tsiDuzenle_Click(object sender, EventArgs e)
        {
            masaForm masa = new masaForm(this, lastSelected);
            masa.ShowDialog();
        }

    
    }
}

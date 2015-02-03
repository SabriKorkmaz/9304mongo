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
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void tsiMasaAyarlari_Click(object sender, EventArgs e)
        {
            masaAyar ms = new masaAyar();
            ms.MdiParent = this;
            ms.Show();
        }

        private void tsiMenuAyarlari_Click(object sender, EventArgs e)
        {
            menuAyar ma = new menuAyar();
            ma.MdiParent = this;
            ma.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            frm.MdiParent = this;
            frm.Show();

        }
    }
}

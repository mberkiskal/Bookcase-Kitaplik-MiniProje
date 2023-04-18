using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p24Kitaplik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KitapVT vts = new KitapVT();
        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vts.liste();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kitap ktpsinif = new Kitap();
            ktpsinif.Ad=txtAd.Text;
            ktpsinif.Yazar=txtYazar.Text;
            vts.kitapekle(ktpsinif);
            MessageBox.Show("Kitap Eklendi!","İşlem Başarılı",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

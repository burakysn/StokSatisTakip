using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyon
{
    public partial class Form_Ana : Form
    {

        public static string baglanti= "Data Source=BURAK\\SQLEXPRESS;Initial Catalog=otomasyon;Integrated Security=True";

        public Form_Ana()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frm_kullanici_giris kc = new frm_kullanici_giris();
            kc.ShowDialog();
        }

        private void müşteriBİlgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musteritakip a = new musteritakip();
            a.ShowDialog();
        }

        private void müşteriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_musteri_listele a = new frm_musteri_listele();
            a.ShowDialog();
        }

        private void ürünListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_urun_kayit a = new frm_urun_kayit();
            a.ShowDialog();
        }

        private void ürünListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_urun_listele a = new frm_urun_listele();
            a.ShowDialog();
        }

        private void kullanıcıBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_kullanici_listele a = new frm_kullanici_listele();
            a.ShowDialog();
        }

        private void kULLANICIKAYITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_kullanici_kayit a = new frm_kullanici_kayit();
            a.ShowDialog();
        }

        private void kategoriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_kategori_kayit a = new frm_kategori_kayit();
            a.ShowDialog();
        }

        private void kategoriListeisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_kategori_listele a = new frm_kategori_listele();
            a.ShowDialog();
        }

        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_satis a = new frm_satis();
            a.ShowDialog();
        }
    }
}

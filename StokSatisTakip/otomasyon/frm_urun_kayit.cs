using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace otomasyon
{
    public partial class frm_urun_kayit : Form
    {
        public frm_urun_kayit()
        {
            InitializeComponent();
        }

        private void BTN_KYT_Click(object sender, EventArgs e)
        {
            string sql = "insert into urun values('" + txt_urunadi.Text + "','" + txt_marka.Text + "','" + txt_utarih.Text + "','" + txt_ttarih.Text + "','" + txt_fiyat.Text + "')";
            SqlConnection baglan = new SqlConnection(Form_Ana.baglanti);
            baglan.Open();

            SqlCommand cmd = new SqlCommand(sql, baglan);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            baglan.Close();
            MessageBox.Show("Kayıt Yapıldı");

            txt_urunadi.Text = "";
            txt_marka.Text = "";
            txt_utarih.Text = "";
            txt_ttarih.Text = "";
            txt_fiyat.Text = "";
        }
    }
}

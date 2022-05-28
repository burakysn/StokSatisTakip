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
    public partial class musteritakip : Form
    {
        public musteritakip()
        {
            InitializeComponent();
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            string sql = "insert into musteri values('" + txt_adi.Text + "','"+txt_soyadi.Text+"','" + txt_tel.Text + "','"+txt_tc.Text+"','"+txt_adres.Text+"')";
            SqlConnection baglan = new SqlConnection(Form_Ana.baglanti);
            baglan.Open();
            
            SqlCommand cmd = new SqlCommand(sql, baglan);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            baglan.Close();
            MessageBox.Show("Kayıt Yapıldı");

            txt_adi.Text = "";
            txt_soyadi.Text = "";
            txt_tel.Text = "";
            txt_tc.Text = "";
            txt_adres.Text = "";

        }
    }
}

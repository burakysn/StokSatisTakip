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
    public partial class frm_kategori_kayit : Form
    {
        public frm_kategori_kayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into kategori values('" + txt_tur.Text + "','" + txt_adi.Text + "')";
            SqlConnection baglan = new SqlConnection(Form_Ana.baglanti);
            baglan.Open();

            SqlCommand cmd = new SqlCommand(sql, baglan);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            baglan.Close();
            MessageBox.Show("Kayıt Yapıldı.");

            txt_tur.Text = "";
            txt_adi.Text = "";

        }
    }
}

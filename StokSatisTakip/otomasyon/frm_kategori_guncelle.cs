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
    public partial class frm_kategori_guncelle : Form
    {
        public int k_id;
        public frm_kategori_guncelle()
        {
            InitializeComponent();
        }

        private void frm_kategori_guncelle_Load(object sender, EventArgs e)
        {

            string sql = "Select * from kategori where k_id='" + k_id + "'";
            SqlConnection sqlconn = new SqlConnection(Form_Ana.baglanti);
            sqlconn.Open();
            SqlCommand cmd = new SqlCommand(sql, sqlconn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows == true)
            {
                txt_turu.Text = Convert.ToString(rd["k_turu"]);
                txt_turu.Text = Convert.ToString(rd["k_adi"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "update kategori set k_turu='" + txt_turu.Text + "' , " + " k_adi='" + txt_adi.Text + "' ";

            SqlConnection baglan = new SqlConnection(Form_Ana.baglanti);
            baglan.Open();
            SqlCommand cmd = new SqlCommand(sql, baglan);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            baglan.Close();
            this.Close();
        }
    }
}

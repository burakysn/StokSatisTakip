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
    public partial class frm_kullanici_guncelle : Form
    {

        public int a_id;
        public frm_kullanici_guncelle()
        {
            InitializeComponent();
        }

        private void frm_kullanici_guncelle_Load(object sender, EventArgs e)
        {
            string sql = " select * from admin where a_id='" + a_id + "' ";
            SqlConnection sqlconn = new SqlConnection(Form_Ana.baglanti);
            sqlconn.Open();
            SqlCommand cmd = new SqlCommand(sql, sqlconn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows == true)
            {
                txt_kad.Text = Convert.ToString(rd["a_ad"]);
                txt_ksifre.Text = Convert.ToString(rd["a_sifre"]);

                txt_kad.Text = "";
                txt_ksifre.Text = "";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "update admin set a_ad='" + txt_kad.Text + "' , " + " a_sifre='" + txt_ksifre.Text + "' where a_id="+a_id;

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

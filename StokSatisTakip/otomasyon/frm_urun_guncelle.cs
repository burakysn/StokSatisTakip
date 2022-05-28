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
    public partial class frm_urun_guncelle : Form
    {
        public int u_id;
        
        public frm_urun_guncelle()
        {
            InitializeComponent();
        }

        private void frm_urun_guncelle_Load(object sender, EventArgs e)
        {
            string sql = " select * from urun where u_id='" + u_id + "' ";
            SqlConnection sqlconn = new SqlConnection(Form_Ana.baglanti);
            sqlconn.Open();
            SqlCommand cmd = new SqlCommand(sql, sqlconn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows == true)
            {
                txt_urunadi.Text = Convert.ToString(rd["u_adi"]);
                txt_marka.Text = Convert.ToString(rd["u_marka"]);
                txt_utarih.Text = Convert.ToString(rd["u_uretim"]);
                txt_ttarih.Text = Convert.ToString(rd["u_tuketim"]);
                txt_fiyat.Text = Convert.ToString(rd["u_fiyat"]);

                txt_urunadi.Text = "";
                txt_marka.Text = "";
                txt_utarih.Text = "";
                txt_ttarih.Text = "";
                txt_fiyat.Text = "";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = " update urun set u_adi='" + txt_urunadi.Text + "' , " + " u_marka='" + txt_marka.Text + "' , u_uretim='" + txt_utarih.Text + "' , " + " u_tuketim='" + txt_ttarih.Text + "' ,u_fiyat='" + txt_fiyat.Text + "' where u_id=" + u_id;

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

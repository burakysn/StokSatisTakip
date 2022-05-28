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
    public partial class frm_musteri_guncelle : Form
    {
        public int m_id;

        public frm_musteri_guncelle()
        {
            InitializeComponent();
        }

        private void frm_musteri_guncelle_Load(object sender, EventArgs e)
        {
            string sql = " select * from musteri where m_id='" + m_id + "' ";
            SqlConnection sqlconn = new SqlConnection(Form_Ana.baglanti);
            sqlconn.Open();
            SqlCommand cmd = new SqlCommand(sql, sqlconn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows == true)
            {
                txt_adi.Text = Convert.ToString(rd["m_adi"]);
                txt_soyadi.Text = Convert.ToString(rd["m_soyadi"]);
                txt_tel.Text = Convert.ToString(rd["m_tel"]);
                txt_tc.Text = Convert.ToString(rd["m_tc"]);
                txt_adres.Text = Convert.ToString(rd["m_adres"]);

                txt_adi.Text = "";
                txt_soyadi.Text = "";
                txt_tel.Text = "";
                txt_tc.Text = "";
                txt_adres.Text = "";


            }

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string sql = " update musteri set m_adi='" + txt_adi.Text + "' , " +" m_soyadi='" + txt_soyadi.Text + "' , m_tel='" + txt_tel.Text + "' , " +" m_tc='" + txt_tc.Text + "' ,m_adres='"+txt_adres.Text+"' where m_id=" + m_id;

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

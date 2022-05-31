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
    public partial class frm_satis : Form
    {
        public frm_satis()
        {
            InitializeComponent();
        }
        public void fnk_liste_doldur()
        {
            string sql = " select m_id as 'Müşteri No' , m_adi as 'ADI', " +
            " m_soyadi as 'SOYADI', m_tel as 'Tel',m_tc as 'TC', " + "m_adres as 'ADRES'"
           +
            " from musteri ";
            SqlConnection con = new SqlConnection(Form_Ana.baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        public void fnk_listele_doldur1()
        {
            string sql = "Select u_id as 'ÜRÜN NO' , u_adi as 'ÜRÜN ADI' , u_marka as 'MARKA' , u_uretim as 'ÜRETİM TARİHİ' , u_tuketim as 'TÜKETİM TARİHİ' , u_fiyat as 'FİYAT' " + "from urun";
            SqlConnection con = new SqlConnection(Form_Ana.baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            con.Close();
        }
        public void fnk_satis_listele()
        {
            string sql = " select " +
            " satis.s_id as 'Satış No' , musteri.m_adi as 'ADI' ,  " +
            " urun.u_adi as 'ÜRÜN ADI' , satis.s_adet as 'Adet' ,  urun.u_fiyat as 'FİYAT' , (urun.u_fiyat*satis.s_adet) as 'TUTAR'  from satis " +
            " left join musteri on satis.s_m_id=musteri.m_id " +
            " left join urun on urun.u_id=satis.s_u_id";

            SqlConnection con = new SqlConnection(Form_Ana.baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
            con.Close();
        }

        private void frm_satis_Load(object sender, EventArgs e)
        {
            fnk_listele_doldur1();
            fnk_liste_doldur();
            fnk_satis_listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int musteriid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Müşteri No"].Value);
            int urunid = Convert.ToInt32(dataGridView2.CurrentRow.Cells["ÜRÜN No"].Value);
            if((musteriid>0)&&(urunid>0))
            {
                string sql = " insert into satis values('" + musteriid + "','" + urunid + "','" + Convert.ToInt32(txt_satis.Text) + "') ";

                SqlConnection baglan = new SqlConnection(Form_Ana.baglanti);
                baglan.Open();
                SqlCommand cmd = new SqlCommand(sql, baglan);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglan.Close();
                MessageBox.Show("Satış Yapıldı");
                fnk_satis_listele();
            }
            else
            {
                MessageBox.Show("Lütfen Müşteri veya Ürün Seçiniz!!!");
            }
        }
    }
}

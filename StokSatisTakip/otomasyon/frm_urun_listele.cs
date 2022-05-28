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
    public partial class frm_urun_listele : Form
    {
        public void fnk_listele_doldur1()
        {
            string sql = "Select u_id as 'ÜRÜN NO' , u_adi as 'ÜRÜN ADI' , u_marka as 'MARKA' , u_uretim as 'ÜRETİM TARİHİ' , u_tuketim as 'TÜKETİM TARİHİ' , u_fiyat as 'FİYAT' "+ "from urun";
            SqlConnection con = new SqlConnection(Form_Ana.baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        public frm_urun_listele()
        {
            InitializeComponent();
        }

        private void frm_urun_listele_Load(object sender, EventArgs e)
        {
            fnk_listele_doldur1();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int urunid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ÜRÜN NO"].Value);
            string sql = " delete from urun where u_id=" + urunid;

            SqlConnection baglan = new SqlConnection(Form_Ana.baglanti);
            baglan.Open();
            SqlCommand cmd = new SqlCommand(sql, baglan);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            baglan.Close();
            fnk_listele_doldur1();
            MessageBox.Show("Silme İşlemi Tamamlandı");
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int urunid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ÜRÜN NO"].Value);
            frm_urun_guncelle a = new frm_urun_guncelle();
            a.u_id = urunid;
            a.ShowDialog();
        }

        private void frm_urun_listele_Activated(object sender, EventArgs e)
        {
            fnk_listele_doldur1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(Form_Ana.baglanti);
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from urun where u_id like '%" + txt_ara.Text + "%' ", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();



        }
    }
}

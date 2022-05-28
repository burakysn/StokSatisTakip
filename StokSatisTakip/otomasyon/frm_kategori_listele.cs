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
    public partial class frm_kategori_listele : Form
    {

        public void fnk_listele_doldur()
        {
            string sql = "Select k_id as 'Kategori No' , k_turu as 'Ktaregori Türü' , k_adi as 'Kategori Adı'" + "from kategori";
            SqlConnection con = new SqlConnection(Form_Ana.baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }
        public frm_kategori_listele()
        {
            InitializeComponent();
        }

        private void frm_kategori_listele_Load(object sender, EventArgs e)
        {
            fnk_listele_doldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(Form_Ana.baglanti);
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from kategori where k_id like '%"+txt_arama.Text+"%'", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int kategoriid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Kategori no"].Value);
            string sql = "delete from kategori where k_id=" + kategoriid;

            SqlConnection baglan = new SqlConnection(Form_Ana.baglanti);
            baglan.Open();
            SqlCommand cmd = new SqlCommand(sql, baglan);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            baglan.Close();
            fnk_listele_doldur();
            MessageBox.Show("Silme İşlemş Tamamlandı");
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int kategoriid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Kategori no"].Value);
            frm_kategori_guncelle a = new frm_kategori_guncelle();
            a.k_id = kategoriid;
            a.ShowDialog();
        }

        private void frm_kategori_listele_Activated(object sender, EventArgs e)
        {
            fnk_listele_doldur();
        }
    }
}

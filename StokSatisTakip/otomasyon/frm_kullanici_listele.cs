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
    public partial class frm_kullanici_listele : Form
    {
        public void fnk_liste_doldur()
        {
            string sql = "Select a_id as 'ADMİN NO' , a_ad as 'KULLANICI ADI' , a_sifre as 'KULLANICI ŞİFRE'"+"from admin";
            SqlConnection con = new SqlConnection(Form_Ana.baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        public frm_kullanici_listele()
        {
            InitializeComponent();
        }

        private void frm_kullanici_listele_Load(object sender, EventArgs e)
        {
            fnk_liste_doldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(Form_Ana.baglanti);
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from admin where a_id like '%" + txt_ara.Text + "%'", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int adminid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ADMİN NO"].Value);
            string sql = " delete from admin where a_id=" + adminid;

            SqlConnection baglan = new SqlConnection(Form_Ana.baglanti);
            baglan.Open();
            SqlCommand cmd = new SqlCommand(sql, baglan);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            baglan.Close();
            fnk_liste_doldur();
            MessageBox.Show("Silme İşlemi Tamamlandı");
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int adminid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ADMİN NO"].Value);
            frm_kullanici_guncelle a = new frm_kullanici_guncelle();
            a.a_id = adminid;
            a.ShowDialog();
        }

        private void frm_kullanici_listele_Activated(object sender, EventArgs e)
        {
            fnk_liste_doldur();
        }
    }
}

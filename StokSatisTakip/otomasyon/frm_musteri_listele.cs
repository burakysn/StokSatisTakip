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
    public partial class frm_musteri_listele : Form
    {
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

        public frm_musteri_listele()
        {
            InitializeComponent();
        }

        private void frm_musteri_listele_Load(object sender, EventArgs e)
        {
            fnk_liste_doldur();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int musteriid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Müşteri No"].Value);
            string sql = " delete from musteri where m_id=" + musteriid;

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
            int musteriid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Müşteri No"].Value);
            frm_musteri_guncelle a = new frm_musteri_guncelle();
            a.m_id = musteriid;
            a.ShowDialog();
        }

        private void frm_musteri_listele_Activated(object sender, EventArgs e)
        {
            fnk_liste_doldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(Form_Ana.baglanti);
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from musteri where m_id like '%" + textBox1.Text + "%' ", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();


        }
    }
}

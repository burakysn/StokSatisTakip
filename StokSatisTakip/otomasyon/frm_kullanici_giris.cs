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
    public partial class frm_kullanici_giris : Form
    {
        public frm_kullanici_giris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(Form_Ana.baglanti);

        private void btn_giris_Click(object sender, EventArgs e)
        {
            try
            {

                baglanti.Open();
                string sql = "Select * from admin where a_ad=@adi and a_sifre=@sifresi";
                SqlParameter prm1 = new SqlParameter("adi", txt_kullanici.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", txt_sifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {

                    this.Close();
                }
            }
            catch(Exception)
            
            {
                MessageBox.Show("Bilgiler Yanlış");
            }
        }

        private void frm_kullanici_giris_Load(object sender, EventArgs e)
        {
            txt_sifre.PasswordChar = '*';

        }
    }
}

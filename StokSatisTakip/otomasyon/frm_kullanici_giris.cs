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
        private void btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (txt_kullanici.Text == "" || txt_sifre.Text == "") 
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız");
            }
            else { 
            baglanti.Open();

            string user;
            string password;
            user = txt_kullanici.Text;
            password = txt_sifre.Text;

            SqlCommand komut = new SqlCommand("select * from admin where a_ad='" + user + "' and a_sifre='" + password + "' ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                
                this.Close();

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Girişi");
            }
            baglanti.Close();
            }
        }

        private void frm_kullanici_giris_Load(object sender, EventArgs e)
        {
            txt_sifre.PasswordChar = '*';

        }

       
    }
}

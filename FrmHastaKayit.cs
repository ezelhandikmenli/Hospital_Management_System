using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace Hospital_Management_System
{
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnKayitYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Convert.ToString(txtBoxAd.Text));
            komut.Parameters.AddWithValue("@p2", Convert.ToString(txtBoxSoyad.Text));
            komut.Parameters.AddWithValue("@p3", Convert.ToString(mskTc.Text));
            komut.Parameters.AddWithValue("@p4", Convert.ToString(mskTelefon.Text));
            komut.Parameters.AddWithValue("@p5", Convert.ToString(txtBoxSifre.Text));
            komut.Parameters.AddWithValue("@p6", Convert.ToString(cmbCinsiyet.Text));
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir Şifreniz:" + txtBoxSifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtBoxAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

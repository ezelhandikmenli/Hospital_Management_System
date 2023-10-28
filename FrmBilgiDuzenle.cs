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

namespace Hospital_Management_System
{
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string TCno;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskTc.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",mskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtBoxAd.Text = dr[1].ToString();
                txtBoxSoyad.Text = dr[2].ToString();
                mskTelefon.Text = dr[4].ToString();
                txtBoxSifre.Text = dr[5].ToString();
                cmbCinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTc=@p6",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtBoxAd.Text);
            komut2.Parameters.AddWithValue("@p2", txtBoxSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", mskTelefon.Text);
            komut2.Parameters.AddWithValue("@p4", txtBoxSifre.Text);
            komut2.Parameters.AddWithValue("@p5", cmbCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", mskTc.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }
    }
}

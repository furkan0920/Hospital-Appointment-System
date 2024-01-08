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

namespace HastaneRandevu
{
    public partial class Frmbilgiduzenle : Form
    {
        public Frmbilgiduzenle()
        {
            InitializeComponent();
        }
        public string TCno;

        sqlbaglanti bgl=new sqlbaglanti();
        private void Frmbilgiduzenle_Load(object sender, EventArgs e)
        {
            msktc.Text = TCno;
            SqlCommand komut=new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtad.Text = dr[1].ToString();
                txtsoyad.Text = dr[2].ToString();
                msktel.Text = dr[4].ToString();
                txtsifre.Text= dr[5].ToString();
                cmbcinsiyet.Text= dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtad.Text);
            komut2.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut2.Parameters.AddWithValue("@p3", msktel.Text);
            komut2.Parameters.AddWithValue("@p4",txtsifre.Text);
            komut2.Parameters.AddWithValue("@p5",cmbcinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6",msktc.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

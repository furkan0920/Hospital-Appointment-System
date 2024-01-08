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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl=new sqlbaglanti();
        private void linkuye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frmhastauye fr=new Frmhastauye();
            fr.Show();

        }

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar Where HastaTC=@p1 and HastaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr=komut.ExecuteReader();
            if (dr.Read())
            {
                Frmhastadetay fr = new Frmhastadetay();
                fr.tc = msktc.Text;  
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatali TC & Şifre");
            }
            bgl.baglanti().Close();
        }
    }
}

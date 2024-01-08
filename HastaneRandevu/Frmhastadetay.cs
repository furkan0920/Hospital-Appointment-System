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
    public partial class Frmhastadetay : Form
    {
        public Frmhastadetay()
        {
            InitializeComponent();
        }

        public string tc;

        sqlbaglanti bgl = new sqlbaglanti();
        private void Frmhastadetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc;
            //ad soyad çekme
            SqlCommand komut=new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] +" "+ dr[1];
            }
            bgl.baglanti().Close();

            //randevu geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC=" + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource= dt;



            //bransları çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2=komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1",cmbbrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbdoktor.Items.Add(dr3[0]+" " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans='" + cmbbrans.Text+"'"+"and RandevuDoktor='"+cmbbrans.Text+"' and RandevuDurum=0",bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void lnkbilgi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frmbilgiduzenle fr = new Frmbilgiduzenle();
            fr.TCno = lbltc.Text;
            fr.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnrandevu_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Randevular Set RandevuDurum=1,HastaTC=@p1,HastaSikayet=@p2 where Randevuid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            komut.Parameters.AddWithValue("@p2", rctsikayet.Text);
            komut.Parameters.AddWithValue("@p3", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alindi","Uyari",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

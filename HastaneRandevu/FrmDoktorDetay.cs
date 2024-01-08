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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frmdoktorbilgiduzenle frd=new Frmdoktorbilgiduzenle();
            frd.TCNO = lbltc.Text;
            frd.Show();
        }
        sqlbaglanti bgl=new sqlbaglanti();
        public string TC;
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = TC;

            //doktor ad soyad
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read())
            {
                lbladsoyad.Text = rdr[0] + " " + rdr[1];
            }
            bgl.baglanti().Close();


            //randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor='" + lbladsoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnduyuru_Click(object sender, EventArgs e)
        {
            FrmDuyurular frd = new FrmDuyurular();
            frd.Show();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchdetay.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}

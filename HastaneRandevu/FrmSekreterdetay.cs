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
    public partial class FrmSekreterdetay : Form
    {
        public FrmSekreterdetay()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        
        public string TCnumara;
        sqlbaglanti bgl = new sqlbaglanti();
        private void FrmSekreterdetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = TCnumara;
            
            //Adsoyad
            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lbladsoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            //branşları  datagride aktarma
            DataTable dt1=new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar",bgl.baglanti());
            da.Fill(dt1);
            dataGridView2.DataSource= dt1;


            //doktorları listeye aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select(DoktorAd+' '+DoktorSoyad) as 'Doktorlar',Doktorbrans From Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView3.DataSource= dt2;

            //bransı comboca aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
                

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular(RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values(@r1,@r2,@r3,@r4)",bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", msktarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", msksaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3",cmbbrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmbdoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Olusturuldu");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {

        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                cmbdoktor.Items.Add(dr[0] + " " + dr[1]);
               
            }
            bgl.baglanti().Close();
        }

        private void btnolustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", richTextBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru olusturdu");
        }

        private void btndoktorpaneli_Click(object sender, EventArgs e)
        {
            Frmdoktorpaneli drp = new Frmdoktorpaneli();
            drp.Show();
        }

        private void btnbrans_Click(object sender, EventArgs e)
        {
            Frmbrans frb=new Frmbrans();
            frb.Show();
        }

        private void btnrandevu_Click(object sender, EventArgs e)
        {
            Frmrandevulistesi frr=new Frmrandevulistesi();
            frr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular frd = new FrmDuyurular();
            frd.Show();
        }
    }
}

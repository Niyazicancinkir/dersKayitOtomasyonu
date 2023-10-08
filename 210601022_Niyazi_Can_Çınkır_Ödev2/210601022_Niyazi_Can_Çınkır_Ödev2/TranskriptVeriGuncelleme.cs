using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _210601022_Niyazi_Can_Çınkır_Ödev2
{
    public partial class TranskriptVeriGuncelleme : Form
    {
        public TranskriptVeriGuncelleme()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=DataBaseTranskrip;User Id=postgres;Password=1234");

        private void TranskriptVeriGuncelleme_Load(object sender, EventArgs e)
        {
            verileri_goster("select * from DERS order by harf_notu  ");
        }
        public void verileri_goster(string txt)
        {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader dr = komut.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvGenel.DataSource = dt;
            }
            komut.Dispose();
            conn.Close();
        }
 

        private void btnIptalTranskriptVeriGuncellemeSayfasi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVeriGuncelle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Güncellemek istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                conn.Open();
                NpgsqlCommand komut_guncelle = new NpgsqlCommand();
                komut_guncelle.Connection = conn;

                komut_guncelle.CommandText = "update DERS set kod=@kod, ad=@ad, harf_notu=@harfNotu, ogretim_uyesi= @ogretimUyesi,kredi=@kredi, donem=@donem, akts=@akts where kod = @veriKod";
                komut_guncelle.Parameters.AddWithValue("@kod", txtKod.Text);
                komut_guncelle.Parameters.AddWithValue("@ad", txtAd.Text);
                komut_guncelle.Parameters.AddWithValue("@harfNotu", txtHarfNotu.Text);
                komut_guncelle.Parameters.AddWithValue("@ogretimUyesi", txtOgretimUyesi.Text);
                komut_guncelle.Parameters.AddWithValue("@kredi", Convert.ToInt32(txtKredi.Text));
                komut_guncelle.Parameters.AddWithValue("@donem", txtDonem.Text);
                komut_guncelle.Parameters.AddWithValue("@akts", Convert.ToInt32(txtAkts.Text));
                komut_guncelle.Parameters.AddWithValue("@veriKod", txtSilinecekVeri.Text);
                komut_guncelle.CommandType = CommandType.Text;
                komut_guncelle.ExecuteNonQuery();

                 conn.Close();
                 verileri_goster("select * from DERS  order by harf_notu  ");
                
                if(MessageBox.Show("Dikkat İşlem Başarıyla Tamamlandı.\n Başka Bir Güncelleme yapacak mısınız?", "Başarılı", MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.No)
                    {
                    this.Close();
                }
              



               
              
            }
        }

        private void btnTablodaGoster_Click(object sender, EventArgs e)
        {

            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;
            komut.CommandText = "select * from DERS where kod Like '" + txtSilinecekVeri.Text + "'";
            NpgsqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAkts.Text = dr["akts"].ToString();
                txtDonem.Text = dr["donem"].ToString();
                txtHarfNotu.Text = dr["harf_notu"].ToString();
                txtKredi.Text = dr["kredi"].ToString();
                txtOgretimUyesi.Text = dr["ogretim_uyesi"].ToString();
                txtKod.Text = dr["kod"].ToString();
                txtAd.Text = dr["ad"].ToString();
            }
            komut.Dispose();
            conn.Close();

              
            verileri_goster("select * from DERS where kod Like '" + txtSilinecekVeri.Text + "'");
             
        }
    }
}

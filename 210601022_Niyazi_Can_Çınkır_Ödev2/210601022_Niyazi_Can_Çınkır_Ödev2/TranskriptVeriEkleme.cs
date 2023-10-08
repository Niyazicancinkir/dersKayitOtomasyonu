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

namespace _210601022_Niyazi_Can_Çınkır_Ödev2
{
    public partial class TranskriptVeriEkleme : Form
    {
        public TranskriptVeriEkleme()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=proje;User Id=postgres;Password=1234");

        private void TranskriptVeriEkleme_Load(object sender, EventArgs e)
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

        private void btnVeriEkle_Click(object sender, EventArgs e)
        {     if(MessageBox.Show("Veri Eklemek Üzeresin \n Onaylıyor Musunuz.","Dikkat",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
{

                conn.Open();
                NpgsqlCommand komut_ekle = new NpgsqlCommand();
                komut_ekle.Connection = conn;

                komut_ekle.Parameters.AddWithValue("@kod", txtKod.Text);
                komut_ekle.Parameters.AddWithValue("@ad", txtAd.Text);
                komut_ekle.Parameters.AddWithValue("@harf_notu", txtHarfNotu.Text);
                komut_ekle.Parameters.AddWithValue("@ogretim_uyesi", txtOgretimUyesi.Text);
                komut_ekle.Parameters.AddWithValue("@kredi", Convert.ToInt32(txtKredi.Text));
                komut_ekle.Parameters.AddWithValue("@donem", txtDonem.Text);
                komut_ekle.Parameters.AddWithValue("@akts", Convert.ToInt32(txtAkts.Text));
                komut_ekle.CommandType = CommandType.Text;
                komut_ekle.CommandText = "insert into DERS (kod, ad, harf_notu, ogretim_uyesi,kredi,donem,akts) values (@kod, @ad, @harf_notu, @ogretim_uyesi, @kredi,@donem,@akts)";

                NpgsqlDataReader dr = komut_ekle.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dgvGenel.DataSource = dt;

                }
                conn.Close();
                komut_ekle.Dispose();
                verileri_goster("select * from DERS order by harf_notu  ");

               if( MessageBox.Show("Başarıyla Tabloya Veriniz Eklendi.\n Yeni Veri Eklemek ister misiniz?", "Başarılı", MessageBoxButtons.YesNo, MessageBoxIcon.Information)  == DialogResult.No)
                {
                    this.Close();
                }
               
            }
        }

        private void btnIptalTranskriptVeriEklemeSayfasi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

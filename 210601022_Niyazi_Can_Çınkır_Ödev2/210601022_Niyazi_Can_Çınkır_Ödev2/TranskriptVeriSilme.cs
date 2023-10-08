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
    public partial class TranskriptVeriSilme : Form
    {
        public TranskriptVeriSilme()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=DataBaseTranskrip;User Id=postgres;Password=1234");

        private void TranskriptVeriSilme_Load(object sender, EventArgs e)
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

        private void btnVeriSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Veri Silmek Üzeresin!\nSilinmeyi Onaylıyor Musun?", "Dikkat", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {



                conn.Open();
                NpgsqlCommand komut_sil = new NpgsqlCommand();
                komut_sil.Connection = conn;
                komut_sil.Parameters.AddWithValue("@txtSilinecekVeri", txtSilinecekVeri.Text);

                komut_sil.CommandType = CommandType.Text;
                komut_sil.CommandText = "delete from DERS where kod = @txtSilinecekVeri";

                NpgsqlDataReader dr = komut_sil.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dgvGenel.DataSource = dt;
                }
                komut_sil.Dispose();
                

                conn.Close();
                verileri_goster("select * from DERS order by harf_notu  ");
                
               if( MessageBox.Show("Silme İşlemi Başarıyla Tamamlandı.\n Yeni Silme İşlemi Yapacak Mısınız?", "BAŞARILI", MessageBoxButtons.YesNo,MessageBoxIcon.Information)== DialogResult.No)
                    {
                    this.Close();
                }
                

                
            }
        }

        private void btnIptalTranskriptVeriSilmeSayfasi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTablodaGoster_Click(object sender, EventArgs e)
        {
            verileri_goster("select * from DERS where kod Like '" + txtSilinecekVeri.Text + "'");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace _210601022_Niyazi_Can_Çınkır_Ödev2
{
    public partial class TranskriptSayfasi : Form
    {
        public TranskriptSayfasi()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=proje;User Id=postgres;Password=1234");

        // Komutlar Burada Tanımlandı 
        public string gnocek = "select  (sum(ders.kredi* notlar.not_deger ) / sum(ders.kredi)) as GANO from ders  Inner join notlar on ders.harf_notu=notlar.harf_notu";
        public string gnocek2101 = "select  (sum(ders.kredi* notlar.not_deger ) / sum(ders.kredi)) as YNO from ders Inner join notlar on ders.harf_notu=notlar.harf_notu where ders.donem='2021/1'";
        public string gnocek2102 = "select  (sum(ders.kredi* notlar.not_deger ) / sum(ders.kredi)) as YNO from ders  Inner join notlar on ders.harf_notu=notlar.harf_notu where ders.donem='2021/2'";
        public string gnocek2201 = "select  (sum(ders.kredi* notlar.not_deger ) / sum(ders.kredi)) as YNO from ders  Inner join notlar on ders.harf_notu=notlar.harf_notu where ders.donem='2022/1'";
        public string gnocek2202 = "select(sum(ders.kredi * notlar.not_deger) / sum(ders.kredi)) as YNO from ders  Inner join notlar on ders.harf_notu=notlar.harf_notu where ders.donem='2022/2'";
        public string Ygnocek2101 = "select  (sum(ders.kredi* notlar.not_deger ) / sum(ders.kredi)) as Gno from ders Inner join notlar on ders.harf_notu=notlar.harf_notu where ders.donem='2021/1'";
        public string Ygnocek2102 = "select  (sum(ders.kredi * notlar.not_deger) / sum(ders.kredi)) as Gno  from ders Inner join notlar on ders.harf_notu = notlar.harf_notu where ders.donem = '2021/1' or ders.donem = '2021/2'";
        public string Ygnocek2201 = "select  (sum(ders.kredi * notlar.not_deger) / sum(ders.kredi)) as Gno from ders Inner join notlar on ders.harf_notu = notlar.harf_notu where ders.donem = '2021/1' or ders.donem = '2021/2' or ders.donem = '2022/1'";
        public string Ygnocek2202 = "select  (sum(ders.kredi * notlar.not_deger) / sum(ders.kredi)) as Gno from ders Inner join notlar on ders.harf_notu = notlar.harf_notu where ders.donem = '2021/1' or ders.donem = '2021/2' or ders.donem = '2022/1' or ders.donem = '2022/2'";


        public string donemderscek2101 = "select * from DERS where donem='2021/1' order by akts desc";
        public string donemderscek2102 = "select * from DERS where donem='2021/2' order by akts desc ";
        public string donemderscek2201 = "select * from DERS where donem='2022/1' order by akts desc";
        public string donemderscek2202 = "select * from DERS where donem='2022/2' order by akts desc";


        public string tablovericekGenel = "select * from DERS  order by harf_notu  ";

        private void TranskriptSayfasi_Load(object sender, EventArgs e)
        {
            verileri_goster(tablovericekGenel);
            GanoHesapla(gnocek, dgvGno);
            GanoHesapla(Ygnocek2101, dgvYGno2101);
            GanoHesapla(Ygnocek2102 , dgvYGno2102);
            GanoHesapla(Ygnocek2201 , dgvYGno2201);
            GanoHesapla(Ygnocek2202 , dgvYGno2202);
            GanoHesapla(gnocek2101, dgvYno2101);
            GanoHesapla(gnocek2102, dgvYno2102);
            GanoHesapla(gnocek2201, dgvYno2201);
            GanoHesapla(gnocek2201, dgvYno2202);
            DonemDersleriBul(donemderscek2101, dgv2101);
            DonemDersleriBul(donemderscek2102, dgv2102);
            DonemDersleriBul(donemderscek2201, dgv2201);
            DonemDersleriBul(donemderscek2202, dgv2202);
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
        public void GanoHesapla(string txt,DataGridView dataGridView)
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
                dataGridView.DataSource = dt;
                }
            komut.Dispose();
            conn.Close();
        }
        public void DonemDersleriBul(string txt, DataGridView dataGridView)
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
                dataGridView.DataSource = dt;
            }
            komut.Dispose();
            conn.Close();
        }
        private void btnVeriEkle_Click(object sender, EventArgs e)
        {
            TranskriptVeriEkleme transkriptVeriEkleme = new TranskriptVeriEkleme();
            transkriptVeriEkleme.ShowDialog();

            verileri_goster(tablovericekGenel);
            GanoHesapla(gnocek, dgvGno);
            GanoHesapla(gnocek2101, dgvYno2101);
            GanoHesapla(gnocek2102, dgvYno2102);
            GanoHesapla(gnocek2201, dgvYno2201);
            DonemDersleriBul(donemderscek2101, dgv2101);
            DonemDersleriBul(donemderscek2102, dgv2102);
            DonemDersleriBul(donemderscek2201, dgv2201);
        }

        private void btnVeriSil_Click(object sender, EventArgs e)
        {
            TranskriptVeriSilme transkriptVeriSilme = new TranskriptVeriSilme();
            transkriptVeriSilme.ShowDialog();

            verileri_goster(tablovericekGenel);
            GanoHesapla(gnocek, dgvGno);
            GanoHesapla(gnocek2101, dgvYno2101);
            GanoHesapla(gnocek2102, dgvYno2102);
            GanoHesapla(gnocek2201, dgvYno2201);
            DonemDersleriBul(donemderscek2101, dgv2101);
            DonemDersleriBul(donemderscek2102, dgv2102);
            DonemDersleriBul(donemderscek2201, dgv2201);
        }

        private void btnVeriGuncelle_Click(object sender, EventArgs e)
        {
            TranskriptVeriGuncelleme transkriptVeriGuncelleme = new TranskriptVeriGuncelleme();
            transkriptVeriGuncelleme.ShowDialog();

            verileri_goster(tablovericekGenel);
            GanoHesapla(gnocek, dgvGno);
            GanoHesapla(gnocek2101, dgvYno2101);
            GanoHesapla(gnocek2102, dgvYno2102);
            GanoHesapla(gnocek2201, dgvYno2201);
            DonemDersleriBul(donemderscek2101, dgv2101);
            DonemDersleriBul(donemderscek2102, dgv2102);
            DonemDersleriBul(donemderscek2201, dgv2201);
        }
            private void btnIptalTranskriptSayfasi_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void btnVeriGoster_Click(object sender, EventArgs e)
        {


            verileri_goster(tablovericekGenel);
            GanoHesapla(gnocek, dgvGno);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnUygulamayiKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
 

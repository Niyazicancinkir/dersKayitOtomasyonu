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
    public partial class GirisSayfasi : Form
    {
        public GirisSayfasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (TxtKullaniciAdi.Text == "210601022@bakircay.edu.tr" && TxtSifre.Text == "1234567890")
            {
                MessageBox.Show("GİRİŞ KABUL EDİLDİ", "GİRİŞ BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainPage mainPage = new MainPage();
                mainPage.ShowDialog();
            } 
            else MessageBox.Show("Kullanıcı Adı veya şifre Hatalı","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            
        }

        private void GirisSayfasi_Load(object sender, EventArgs e)
        {
            TxtKullaniciAdi.Text = "210601022@bakircay.edu.tr";
            TxtSifre.Text = "1234567890";

        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            KayitOl kayitOl = new KayitOl();
            TxtKullaniciAdi = kayitOl.txtKullaniciAdi;
            TxtSifre = kayitOl.txtSifre;
            kayitOl.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             Application.Exit();
        }
    }
}

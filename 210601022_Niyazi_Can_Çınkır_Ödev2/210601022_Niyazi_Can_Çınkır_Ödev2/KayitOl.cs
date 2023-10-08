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
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            string YeniKayitkullaniciAdi = txtKullaniciAdi.Text;
            string YeniKayitSifre = txtSifre.Text;
            string YeniKayitSifreCheck = txtSifreTekrar.Text;
         
            
            if (YeniKayitSifre == YeniKayitSifreCheck)
            {
                lblKayitBasarili.Text = "Yeni Kayit Başarı İle Oluşturuldu";
                lnklblCikis.Text = "Giriş Sayfası ";

                
            }
        }

        private void lnklblCikis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}

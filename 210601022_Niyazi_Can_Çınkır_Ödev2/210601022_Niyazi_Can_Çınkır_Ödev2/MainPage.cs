using Npgsql;

namespace _210601022_Niyazi_Can_Çınkır_Ödev2

{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TranskriptSayfasi transkriptSayfasi = new TranskriptSayfasi();
            transkriptSayfasi.ShowDialog(); 

        }

        private void btnIptaMainPage_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Programdan Çıkmak İstediğine Emin Misin? ", "Çıkış Yapılıyor!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                {
                this.Close();
            } 
            
           
        }

        private void btntest_Click(object sender, EventArgs e)
        {
            FiltrelenmisTranskriptcs filtrelenmisTranskriptcs  = new FiltrelenmisTranskriptcs();
            filtrelenmisTranskriptcs.ShowDialog();
        }
    }
}
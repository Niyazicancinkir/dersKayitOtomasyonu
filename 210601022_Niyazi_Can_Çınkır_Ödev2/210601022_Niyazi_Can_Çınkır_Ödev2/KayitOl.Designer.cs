namespace _210601022_Niyazi_Can_Çınkır_Ödev2
{
    partial class KayitOl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUyeOl = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKayitBasarili = new System.Windows.Forms.Label();
            this.lnklblCikis = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnUyeOl
            // 
            this.btnUyeOl.Location = new System.Drawing.Point(180, 262);
            this.btnUyeOl.Name = "btnUyeOl";
            this.btnUyeOl.Size = new System.Drawing.Size(94, 29);
            this.btnUyeOl.TabIndex = 0;
            this.btnUyeOl.Text = "Üye OL ";
            this.btnUyeOl.UseVisualStyleBackColor = true;
            this.btnUyeOl.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(153, 165);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(196, 27);
            this.txtSifre.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kullanıcı Adi";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(153, 126);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(196, 27);
            this.txtKullaniciAdi.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre";
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Location = new System.Drawing.Point(153, 198);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.PasswordChar = '*';
            this.txtSifreTekrar.Size = new System.Drawing.Size(196, 27);
            this.txtSifreTekrar.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Şifre Tekrar";
            // 
            // lblKayitBasarili
            // 
            this.lblKayitBasarili.AutoSize = true;
            this.lblKayitBasarili.Location = new System.Drawing.Point(79, 362);
            this.lblKayitBasarili.Name = "lblKayitBasarili";
            this.lblKayitBasarili.Size = new System.Drawing.Size(0, 20);
            this.lblKayitBasarili.TabIndex = 12;
            // 
            // lnklblCikis
            // 
            this.lnklblCikis.AutoSize = true;
            this.lnklblCikis.Location = new System.Drawing.Point(221, 321);
            this.lnklblCikis.Name = "lnklblCikis";
            this.lnklblCikis.Size = new System.Drawing.Size(13, 20);
            this.lnklblCikis.TabIndex = 13;
            this.lnklblCikis.TabStop = true;
            this.lnklblCikis.Text = " ";
            this.lnklblCikis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblCikis_LinkClicked);
            // 
            // KayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSifreTekrar);
            this.Controls.Add(this.btnUyeOl);
            this.Controls.Add(this.lnklblCikis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKayitBasarili);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Name = "KayitOl";
            this.Text = "KayitOl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUyeOl;
        private GroupBox groupBox1;
        private Label lblKayitBasarili;
        public LinkLabel lnklblCikis;
        public TextBox txtSifre;
        public Label label2;
        public TextBox txtKullaniciAdi;
        public Label label3;
        public TextBox txtSifreTekrar;
        public Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBakim;
    }
}
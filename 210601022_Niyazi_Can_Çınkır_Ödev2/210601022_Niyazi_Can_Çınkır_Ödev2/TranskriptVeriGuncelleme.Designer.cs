namespace _210601022_Niyazi_Can_Çınkır_Ödev2
{
    partial class TranskriptVeriGuncelleme
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
            this.btnIptalTranskriptVeriGuncellemeSayfasi = new System.Windows.Forms.Button();
            this.txtSilinecekVeri = new System.Windows.Forms.MaskedTextBox();
            this.btnVeriGuncelle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvGenel = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHarfNotu = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDonem = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOgretimUyesi = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAkts = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKredi = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKod = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTablodaGoster = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenel)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIptalTranskriptVeriGuncellemeSayfasi
            // 
            this.btnIptalTranskriptVeriGuncellemeSayfasi.BackColor = System.Drawing.Color.Red;
            this.btnIptalTranskriptVeriGuncellemeSayfasi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIptalTranskriptVeriGuncellemeSayfasi.ForeColor = System.Drawing.Color.White;
            this.btnIptalTranskriptVeriGuncellemeSayfasi.Location = new System.Drawing.Point(952, 530);
            this.btnIptalTranskriptVeriGuncellemeSayfasi.Name = "btnIptalTranskriptVeriGuncellemeSayfasi";
            this.btnIptalTranskriptVeriGuncellemeSayfasi.Size = new System.Drawing.Size(171, 83);
            this.btnIptalTranskriptVeriGuncellemeSayfasi.TabIndex = 25;
            this.btnIptalTranskriptVeriGuncellemeSayfasi.Text = "İptal";
            this.btnIptalTranskriptVeriGuncellemeSayfasi.UseVisualStyleBackColor = false;
            this.btnIptalTranskriptVeriGuncellemeSayfasi.Click += new System.EventHandler(this.btnIptalTranskriptVeriGuncellemeSayfasi_Click);
            // 
            // txtSilinecekVeri
            // 
            this.txtSilinecekVeri.Location = new System.Drawing.Point(79, 112);
            this.txtSilinecekVeri.Name = "txtSilinecekVeri";
            this.txtSilinecekVeri.Size = new System.Drawing.Size(125, 27);
            this.txtSilinecekVeri.TabIndex = 26;
            // 
            // btnVeriGuncelle
            // 
            this.btnVeriGuncelle.BackColor = System.Drawing.Color.LightGreen;
            this.btnVeriGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVeriGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnVeriGuncelle.Location = new System.Drawing.Point(106, 530);
            this.btnVeriGuncelle.Name = "btnVeriGuncelle";
            this.btnVeriGuncelle.Size = new System.Drawing.Size(143, 83);
            this.btnVeriGuncelle.TabIndex = 27;
            this.btnVeriGuncelle.Text = "Veri Güncelle";
            this.btnVeriGuncelle.UseVisualStyleBackColor = false;
            this.btnVeriGuncelle.Click += new System.EventHandler(this.btnVeriGuncelle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(32, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Güncelleştirilecek verinin Kodu ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTablodaGoster);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtSilinecekVeri);
            this.groupBox1.Location = new System.Drawing.Point(45, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 215);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Güncelle";
            // 
            // dgvGenel
            // 
            this.dgvGenel.AllowUserToAddRows = false;
            this.dgvGenel.AllowUserToDeleteRows = false;
            this.dgvGenel.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvGenel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenel.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvGenel.Location = new System.Drawing.Point(33, 12);
            this.dgvGenel.Name = "dgvGenel";
            this.dgvGenel.ReadOnly = true;
            this.dgvGenel.RowHeadersWidth = 51;
            this.dgvGenel.RowTemplate.Height = 29;
            this.dgvGenel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGenel.Size = new System.Drawing.Size(945, 262);
            this.dgvGenel.TabIndex = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHarfNotu);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDonem);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtOgretimUyesi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtAkts);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtKredi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtAd);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtKod);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(425, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 333);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Güncellencek Veriler";
            // 
            // txtHarfNotu
            // 
            this.txtHarfNotu.Location = new System.Drawing.Point(178, 228);
            this.txtHarfNotu.Name = "txtHarfNotu";
            this.txtHarfNotu.Size = new System.Drawing.Size(125, 27);
            this.txtHarfNotu.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "kod";
            // 
            // txtDonem
            // 
            this.txtDonem.Location = new System.Drawing.Point(178, 195);
            this.txtDonem.Name = "txtDonem";
            this.txtDonem.Size = new System.Drawing.Size(125, 27);
            this.txtDonem.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "ad";
            // 
            // txtOgretimUyesi
            // 
            this.txtOgretimUyesi.Location = new System.Drawing.Point(178, 162);
            this.txtOgretimUyesi.Name = "txtOgretimUyesi";
            this.txtOgretimUyesi.Size = new System.Drawing.Size(125, 27);
            this.txtOgretimUyesi.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "kredi";
            // 
            // txtAkts
            // 
            this.txtAkts.Location = new System.Drawing.Point(178, 129);
            this.txtAkts.Name = "txtAkts";
            this.txtAkts.Size = new System.Drawing.Size(125, 27);
            this.txtAkts.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(28, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "akts";
            // 
            // txtKredi
            // 
            this.txtKredi.Location = new System.Drawing.Point(178, 96);
            this.txtKredi.Name = "txtKredi";
            this.txtKredi.Size = new System.Drawing.Size(125, 27);
            this.txtKredi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(28, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "ogretim_uyesi";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(178, 61);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(125, 27);
            this.txtAd.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(28, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "donem";
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(178, 28);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(125, 27);
            this.txtKod.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(28, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 30);
            this.label7.TabIndex = 7;
            this.label7.Text = "harf_notu";
            // 
            // btnTablodaGoster
            // 
            this.btnTablodaGoster.Location = new System.Drawing.Point(79, 164);
            this.btnTablodaGoster.Name = "btnTablodaGoster";
            this.btnTablodaGoster.Size = new System.Drawing.Size(125, 45);
            this.btnTablodaGoster.TabIndex = 29;
            this.btnTablodaGoster.Text = "Tabloda Göster";
            this.btnTablodaGoster.UseVisualStyleBackColor = true;
            this.btnTablodaGoster.Click += new System.EventHandler(this.btnTablodaGoster_Click);
            // 
            // TranskriptVeriGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 625);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnVeriGuncelle);
            this.Controls.Add(this.dgvGenel);
            this.Controls.Add(this.btnIptalTranskriptVeriGuncellemeSayfasi);
            this.Controls.Add(this.groupBox1);
            this.Name = "TranskriptVeriGuncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TranskriptVeriGuncelleme";
            this.Load += new System.EventHandler(this.TranskriptVeriGuncelleme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenel)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnIptalTranskriptVeriGuncellemeSayfasi;
        private MaskedTextBox txtSilinecekVeri;
        private Button btnVeriGuncelle;
        private Label label8;
        private GroupBox groupBox1;
        private DataGridView dgvGenel;
        private GroupBox groupBox2;
        private MaskedTextBox txtHarfNotu;
        private Label label1;
        private MaskedTextBox txtDonem;
        private Label label2;
        private MaskedTextBox txtOgretimUyesi;
        private Label label3;
        private MaskedTextBox txtAkts;
        private Label label4;
        private MaskedTextBox txtKredi;
        private Label label5;
        private MaskedTextBox txtAd;
        private Label label6;
        private MaskedTextBox txtKod;
        private Label label7;
        private Button btnTablodaGoster;
    }
}
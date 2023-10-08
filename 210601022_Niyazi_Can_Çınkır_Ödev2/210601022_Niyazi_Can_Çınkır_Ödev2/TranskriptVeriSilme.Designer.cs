namespace _210601022_Niyazi_Can_Çınkır_Ödev2
{
    partial class TranskriptVeriSilme
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSilinecekVeri = new System.Windows.Forms.MaskedTextBox();
            this.btnVeriSil = new System.Windows.Forms.Button();
            this.btnIptalTranskriptVeriSilmeSayfasi = new System.Windows.Forms.Button();
            this.dgvGenel = new System.Windows.Forms.DataGridView();
            this.btnTablodaGoster = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenel)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTablodaGoster);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSilinecekVeri);
            this.groupBox2.Location = new System.Drawing.Point(84, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 163);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SİL  ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(45, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Silmek İstediğiniz verinin Kodu ";
            // 
            // txtSilinecekVeri
            // 
            this.txtSilinecekVeri.Location = new System.Drawing.Point(93, 84);
            this.txtSilinecekVeri.Name = "txtSilinecekVeri";
            this.txtSilinecekVeri.Size = new System.Drawing.Size(125, 27);
            this.txtSilinecekVeri.TabIndex = 20;
            // 
            // btnVeriSil
            // 
            this.btnVeriSil.BackColor = System.Drawing.Color.LightGreen;
            this.btnVeriSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVeriSil.ForeColor = System.Drawing.Color.White;
            this.btnVeriSil.Location = new System.Drawing.Point(177, 468);
            this.btnVeriSil.Name = "btnVeriSil";
            this.btnVeriSil.Size = new System.Drawing.Size(135, 83);
            this.btnVeriSil.TabIndex = 18;
            this.btnVeriSil.Text = "  veri sil  ";
            this.btnVeriSil.UseVisualStyleBackColor = false;
            this.btnVeriSil.Click += new System.EventHandler(this.btnVeriSil_Click);
            // 
            // btnIptalTranskriptVeriSilmeSayfasi
            // 
            this.btnIptalTranskriptVeriSilmeSayfasi.BackColor = System.Drawing.Color.Red;
            this.btnIptalTranskriptVeriSilmeSayfasi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIptalTranskriptVeriSilmeSayfasi.ForeColor = System.Drawing.Color.White;
            this.btnIptalTranskriptVeriSilmeSayfasi.Location = new System.Drawing.Point(895, 468);
            this.btnIptalTranskriptVeriSilmeSayfasi.Name = "btnIptalTranskriptVeriSilmeSayfasi";
            this.btnIptalTranskriptVeriSilmeSayfasi.Size = new System.Drawing.Size(171, 83);
            this.btnIptalTranskriptVeriSilmeSayfasi.TabIndex = 24;
            this.btnIptalTranskriptVeriSilmeSayfasi.Text = "İptal";
            this.btnIptalTranskriptVeriSilmeSayfasi.UseVisualStyleBackColor = false;
            this.btnIptalTranskriptVeriSilmeSayfasi.Click += new System.EventHandler(this.btnIptalTranskriptVeriSilmeSayfasi_Click);
            // 
            // dgvGenel
            // 
            this.dgvGenel.AllowUserToAddRows = false;
            this.dgvGenel.AllowUserToDeleteRows = false;
            this.dgvGenel.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvGenel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenel.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvGenel.Location = new System.Drawing.Point(40, 12);
            this.dgvGenel.Name = "dgvGenel";
            this.dgvGenel.ReadOnly = true;
            this.dgvGenel.RowHeadersWidth = 51;
            this.dgvGenel.RowTemplate.Height = 29;
            this.dgvGenel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGenel.Size = new System.Drawing.Size(948, 240);
            this.dgvGenel.TabIndex = 25;
            // 
            // btnTablodaGoster
            // 
            this.btnTablodaGoster.Location = new System.Drawing.Point(93, 128);
            this.btnTablodaGoster.Name = "btnTablodaGoster";
            this.btnTablodaGoster.Size = new System.Drawing.Size(125, 29);
            this.btnTablodaGoster.TabIndex = 22;
            this.btnTablodaGoster.Text = "Tabloda Göster";
            this.btnTablodaGoster.UseVisualStyleBackColor = true;
            this.btnTablodaGoster.Click += new System.EventHandler(this.btnTablodaGoster_Click);
            // 
            // TranskriptVeriSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 563);
            this.Controls.Add(this.dgvGenel);
            this.Controls.Add(this.btnIptalTranskriptVeriSilmeSayfasi);
            this.Controls.Add(this.btnVeriSil);
            this.Controls.Add(this.groupBox2);
            this.Name = "TranskriptVeriSilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TranskriptVeriSilme";
            this.Load += new System.EventHandler(this.TranskriptVeriSilme_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private Label label8;
        private MaskedTextBox txtSilinecekVeri;
        private Button btnVeriSil;
        private Button btnIptalTranskriptVeriSilmeSayfasi;
        private DataGridView dgvGenel;
        private Button btnTablodaGoster;
    }
}
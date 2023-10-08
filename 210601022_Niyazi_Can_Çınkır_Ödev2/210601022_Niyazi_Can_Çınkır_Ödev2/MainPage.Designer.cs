namespace _210601022_Niyazi_Can_Çınkır_Ödev2
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTranskriptDuzenle = new System.Windows.Forms.Button();
            this.btnIptaMainPage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTranskriptGor = new System.Windows.Forms.Button();
            this.lbltranskrpt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTranskriptDuzenle
            // 
            this.btnTranskriptDuzenle.BackColor = System.Drawing.Color.Crimson;
            this.btnTranskriptDuzenle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTranskriptDuzenle.Location = new System.Drawing.Point(571, 386);
            this.btnTranskriptDuzenle.Name = "btnTranskriptDuzenle";
            this.btnTranskriptDuzenle.Size = new System.Drawing.Size(220, 99);
            this.btnTranskriptDuzenle.TabIndex = 0;
            this.btnTranskriptDuzenle.Text = "Transkript Düzenle";
            this.btnTranskriptDuzenle.UseVisualStyleBackColor = false;
            this.btnTranskriptDuzenle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIptaMainPage
            // 
            this.btnIptaMainPage.BackColor = System.Drawing.Color.Red;
            this.btnIptaMainPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIptaMainPage.ForeColor = System.Drawing.Color.White;
            this.btnIptaMainPage.Location = new System.Drawing.Point(1237, 488);
            this.btnIptaMainPage.Name = "btnIptaMainPage";
            this.btnIptaMainPage.Size = new System.Drawing.Size(171, 83);
            this.btnIptaMainPage.TabIndex = 25;
            this.btnIptaMainPage.Text = "ÇIKIŞ";
            this.btnIptaMainPage.UseVisualStyleBackColor = false;
            this.btnIptaMainPage.Click += new System.EventHandler(this.btnIptaMainPage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(248, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(903, 67);
            this.label1.TabIndex = 26;
            this.label1.Text = "Transkript Uygulamasına Hoş Geldiniz!";
            // 
            // btnTranskriptGor
            // 
            this.btnTranskriptGor.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTranskriptGor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTranskriptGor.Location = new System.Drawing.Point(571, 281);
            this.btnTranskriptGor.Name = "btnTranskriptGor";
            this.btnTranskriptGor.Size = new System.Drawing.Size(220, 99);
            this.btnTranskriptGor.TabIndex = 27;
            this.btnTranskriptGor.Text = "Transkript  Görüntüle";
            this.btnTranskriptGor.UseVisualStyleBackColor = false;
            this.btnTranskriptGor.Click += new System.EventHandler(this.btntest_Click);
            // 
            // lbltranskrpt
            // 
            this.lbltranskrpt.AutoSize = true;
            this.lbltranskrpt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltranskrpt.Location = new System.Drawing.Point(358, 320);
            this.lbltranskrpt.Name = "lbltranskrpt";
            this.lbltranskrpt.Size = new System.Drawing.Size(159, 20);
            this.lbltranskrpt.TabIndex = 28;
            this.lbltranskrpt.Text = "Transkript Görüntüle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(373, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Transkript Düzenle:";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 583);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltranskrpt);
            this.Controls.Add(this.btnTranskriptGor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIptaMainPage);
            this.Controls.Add(this.btnTranskriptDuzenle);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnTranskriptDuzenle;
        private Button btnIptaMainPage;
        private Label label1;
        private Button btnTranskriptGor;
        private Label lbltranskrpt;
        private Label label2;
    }
}
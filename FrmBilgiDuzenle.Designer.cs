namespace Hospital_Management_System
{
    partial class FrmBilgiDuzenle
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
            this.btnBilgiGuncelle = new System.Windows.Forms.Button();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBilgiGuncelle
            // 
            this.btnBilgiGuncelle.BackColor = System.Drawing.Color.Pink;
            this.btnBilgiGuncelle.Location = new System.Drawing.Point(220, 427);
            this.btnBilgiGuncelle.Name = "btnBilgiGuncelle";
            this.btnBilgiGuncelle.Size = new System.Drawing.Size(158, 42);
            this.btnBilgiGuncelle.TabIndex = 27;
            this.btnBilgiGuncelle.Text = "Bilgi Güncelle";
            this.btnBilgiGuncelle.UseVisualStyleBackColor = false;
            this.btnBilgiGuncelle.Click += new System.EventHandler(this.btnBilgiGuncelle_Click);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(220, 354);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(158, 36);
            this.cmbCinsiyet.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 28);
            this.label6.TabIndex = 25;
            this.label6.Text = "Cinsiyet:";
            // 
            // txtBoxSifre
            // 
            this.txtBoxSifre.Location = new System.Drawing.Point(220, 287);
            this.txtBoxSifre.Name = "txtBoxSifre";
            this.txtBoxSifre.Size = new System.Drawing.Size(158, 36);
            this.txtBoxSifre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Şifre:";
            // 
            // mskTelefon
            // 
            this.mskTelefon.Location = new System.Drawing.Point(220, 230);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(158, 36);
            this.mskTelefon.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 28);
            this.label5.TabIndex = 21;
            this.label5.Text = "Telefon:";
            // 
            // txtBoxSoyad
            // 
            this.txtBoxSoyad.Location = new System.Drawing.Point(220, 103);
            this.txtBoxSoyad.Name = "txtBoxSoyad";
            this.txtBoxSoyad.Size = new System.Drawing.Size(158, 36);
            this.txtBoxSoyad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Soyad:";
            // 
            // txtBoxAd
            // 
            this.txtBoxAd.Location = new System.Drawing.Point(220, 48);
            this.txtBoxAd.Name = "txtBoxAd";
            this.txtBoxAd.Size = new System.Drawing.Size(158, 36);
            this.txtBoxAd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ad:";
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(220, 166);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(158, 36);
            this.mskTc.TabIndex = 3;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "TC Kimlik No:";
            // 
            // FrmBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(504, 540);
            this.Controls.Add(this.btnBilgiGuncelle);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskTelefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmBilgiDuzenle";
            this.Text = "Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.FrmBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBilgiGuncelle;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.Label label1;
    }
}
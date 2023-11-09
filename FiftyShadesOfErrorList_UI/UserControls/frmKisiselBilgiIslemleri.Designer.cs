namespace FiftyShadesOfErrorList_UI.UserControls
{
    partial class frmKisiselBilgiIslemleri
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbEgzersiz = new ComboBox();
            cmbVucutTipi = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label3 = new Label();
            label2 = new Label();
            label11 = new Label();
            label10 = new Label();
            btnGuncelle = new Button();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtBoy = new TextBox();
            txtKilo = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtEposta = new TextBox();
            txtSifre = new TextBox();
            cmbCinsiyet = new ComboBox();
            btnHesabiSil = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbEgzersiz
            // 
            cmbEgzersiz.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEgzersiz.FormattingEnabled = true;
            cmbEgzersiz.Location = new Point(363, 257);
            cmbEgzersiz.Name = "cmbEgzersiz";
            cmbEgzersiz.Size = new Size(205, 23);
            cmbEgzersiz.TabIndex = 10;
            // 
            // cmbVucutTipi
            // 
            cmbVucutTipi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVucutTipi.FormattingEnabled = true;
            cmbVucutTipi.Location = new Point(363, 221);
            cmbVucutTipi.Name = "cmbVucutTipi";
            cmbVucutTipi.Size = new Size(205, 23);
            cmbVucutTipi.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(222, 261);
            label9.Name = "label9";
            label9.Size = new Size(112, 19);
            label9.TabIndex = 8;
            label9.Text = "Egzersiz Sıklığı:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(222, 225);
            label8.Name = "label8";
            label8.Size = new Size(79, 19);
            label8.TabIndex = 9;
            label8.Text = "Vücut Tipi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(222, 186);
            label3.Name = "label3";
            label3.Size = new Size(65, 19);
            label3.TabIndex = 12;
            label3.Text = "Soyisim:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(222, 146);
            label2.Name = "label2";
            label2.Size = new Size(40, 19);
            label2.TabIndex = 13;
            label2.Text = "İsim:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(222, 346);
            label11.Name = "label11";
            label11.Size = new Size(39, 19);
            label11.TabIndex = 16;
            label11.Text = "Kilo:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(222, 308);
            label10.Name = "label10";
            label10.Size = new Size(39, 19);
            label10.TabIndex = 17;
            label10.Text = "Boy:";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.Image = Properties.Resources.MicrosoftTeams_image__11_2;
            btnGuncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuncelle.Location = new Point(417, 511);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(116, 41);
            btnGuncelle.TabIndex = 20;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(363, 145);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(205, 23);
            txtAd.TabIndex = 22;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(363, 182);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(205, 23);
            txtSoyad.TabIndex = 22;
            // 
            // txtBoy
            // 
            txtBoy.Location = new Point(363, 307);
            txtBoy.Name = "txtBoy";
            txtBoy.Size = new Size(205, 23);
            txtBoy.TabIndex = 23;
            // 
            // txtKilo
            // 
            txtKilo.Location = new Point(363, 342);
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(205, 23);
            txtKilo.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(224, 428);
            label6.Name = "label6";
            label6.Size = new Size(44, 19);
            label6.TabIndex = 24;
            label6.Text = "Şifre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(224, 475);
            label4.Name = "label4";
            label4.Size = new Size(65, 19);
            label4.TabIndex = 25;
            label4.Text = "Cinsiyet:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(224, 390);
            label5.Name = "label5";
            label5.Size = new Size(63, 19);
            label5.TabIndex = 26;
            label5.Text = "E-Posta:";
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(363, 390);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(205, 23);
            txtEposta.TabIndex = 23;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(363, 428);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(205, 23);
            txtSifre.TabIndex = 23;
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Location = new Point(363, 471);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(205, 23);
            cmbCinsiyet.TabIndex = 10;
            // 
            // btnHesabiSil
            // 
            btnHesabiSil.BackColor = Color.Transparent;
            btnHesabiSil.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnHesabiSil.Location = new Point(429, 579);
            btnHesabiSil.Name = "btnHesabiSil";
            btnHesabiSil.Size = new Size(89, 22);
            btnHesabiSil.TabIndex = 27;
            btnHesabiSil.Text = "Hesabımı Sil";
            btnHesabiSil.UseVisualStyleBackColor = false;
            btnHesabiSil.Click += btnHesabiSil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(363, 78);
            label1.Name = "label1";
            label1.Size = new Size(165, 25);
            label1.TabIndex = 28;
            label1.Text = "PROFİL AYARLARI";
            // 
            // frmKisiselBilgiIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MicrosoftTeams_image__13_;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(label1);
            Controls.Add(btnHesabiSil);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtSifre);
            Controls.Add(txtEposta);
            Controls.Add(txtKilo);
            Controls.Add(txtBoy);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(btnGuncelle);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbCinsiyet);
            Controls.Add(cmbEgzersiz);
            Controls.Add(cmbVucutTipi);
            Controls.Add(label9);
            Controls.Add(label8);
            Name = "frmKisiselBilgiIslemleri";
            Size = new Size(923, 752);
            Load += frmKisiselBilgiIslemleri_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbEgzersiz;
        private ComboBox cmbVucutTipi;
        private Label label9;
        private Label label8;
        private Label label3;
        private Label label2;
        private Label label11;
        private Label label10;
        private Button btnGuncelle;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtBoy;
        private TextBox txtKilo;
        private Label label6;
        private Label label4;
        private Label label5;
        private TextBox txtEposta;
        private TextBox txtSifre;
        private ComboBox cmbCinsiyet;
        private Button btnHesabiSil;
        private Label label1;
    }
}

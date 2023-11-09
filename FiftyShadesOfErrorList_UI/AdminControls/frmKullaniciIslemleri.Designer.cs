namespace FiftyShadesOfErrorList_UI.UserControls
{
    partial class frmKullaniciIslemleri
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
            fileSystemWatcher1 = new FileSystemWatcher();
            btnTumunuListele = new Button();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            dgvKullanici = new DataGridView();
            cmbEgzersiz = new ComboBox();
            cmbVucutTipi = new ComboBox();
            cmbCinsiyet = new ComboBox();
            dtpDogumTarihi = new DateTimePicker();
            txtSifreKayit = new TextBox();
            txtEpostaKayit = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            label8 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbStatu = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKullanici).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnTumunuListele
            // 
            btnTumunuListele.BackColor = Color.Transparent;
            btnTumunuListele.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTumunuListele.Image = Properties.Resources.MicrosoftTeams_image__7_;
            btnTumunuListele.ImageAlign = ContentAlignment.MiddleLeft;
            btnTumunuListele.Location = new Point(12, 51);
            btnTumunuListele.Name = "btnTumunuListele";
            btnTumunuListele.Size = new Size(124, 42);
            btnTumunuListele.TabIndex = 0;
            btnTumunuListele.Text = "Tümünü Listele";
            btnTumunuListele.TextAlign = ContentAlignment.MiddleRight;
            btnTumunuListele.UseVisualStyleBackColor = false;
            btnTumunuListele.Click += btnTumunuListele_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Transparent;
            btnEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.Image = Properties.Resources.MicrosoftTeams_image__10_;
            btnEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btnEkle.Location = new Point(12, 110);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(124, 42);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle             ";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Transparent;
            btnGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.Image = Properties.Resources.MicrosoftTeams_image__11_;
            btnGuncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuncelle.Location = new Point(12, 175);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(124, 42);
            btnGuncelle.TabIndex = 0;
            btnGuncelle.Text = "Güncelle        ";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Transparent;
            btnSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Image = Properties.Resources.MicrosoftTeams_image__9_;
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.Location = new Point(12, 242);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(124, 42);
            btnSil.TabIndex = 0;
            btnSil.Text = "Sil                 ";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // dgvKullanici
            // 
            dgvKullanici.BackgroundColor = Color.LightGray;
            dgvKullanici.BorderStyle = BorderStyle.None;
            dgvKullanici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKullanici.Location = new Point(3, 382);
            dgvKullanici.Name = "dgvKullanici";
            dgvKullanici.ReadOnly = true;
            dgvKullanici.RowTemplate.Height = 25;
            dgvKullanici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKullanici.Size = new Size(694, 249);
            dgvKullanici.TabIndex = 1;
            dgvKullanici.MouseClick += dgvKullanici_MouseClick;
            // 
            // cmbEgzersiz
            // 
            cmbEgzersiz.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEgzersiz.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEgzersiz.FormattingEnabled = true;
            cmbEgzersiz.Location = new Point(370, 306);
            cmbEgzersiz.Name = "cmbEgzersiz";
            cmbEgzersiz.Size = new Size(171, 23);
            cmbEgzersiz.TabIndex = 8;
            // 
            // cmbVucutTipi
            // 
            cmbVucutTipi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVucutTipi.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbVucutTipi.FormattingEnabled = true;
            cmbVucutTipi.Location = new Point(370, 270);
            cmbVucutTipi.Name = "cmbVucutTipi";
            cmbVucutTipi.Size = new Size(171, 23);
            cmbVucutTipi.TabIndex = 7;
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCinsiyet.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Location = new Point(370, 197);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(171, 23);
            cmbCinsiyet.TabIndex = 5;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDogumTarihi.Location = new Point(370, 231);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(171, 21);
            dtpDogumTarihi.TabIndex = 6;
            // 
            // txtSifreKayit
            // 
            txtSifreKayit.BackColor = Color.White;
            txtSifreKayit.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifreKayit.Location = new Point(370, 153);
            txtSifreKayit.Name = "txtSifreKayit";
            txtSifreKayit.PasswordChar = '*';
            txtSifreKayit.Size = new Size(171, 21);
            txtSifreKayit.TabIndex = 4;
            // 
            // txtEpostaKayit
            // 
            txtEpostaKayit.BackColor = Color.White;
            txtEpostaKayit.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEpostaKayit.Location = new Point(370, 115);
            txtEpostaKayit.Name = "txtEpostaKayit";
            txtEpostaKayit.Size = new Size(171, 21);
            txtEpostaKayit.TabIndex = 3;
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = Color.White;
            txtSoyad.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoyad.Location = new Point(370, 76);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(171, 21);
            txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            txtAd.BackColor = Color.White;
            txtAd.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAd.Location = new Point(370, 36);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(171, 21);
            txtAd.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(252, 155);
            label6.Name = "label6";
            label6.Size = new Size(44, 19);
            label6.TabIndex = 14;
            label6.Text = "Şifre:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(249, 236);
            label7.Name = "label7";
            label7.Size = new Size(103, 19);
            label7.TabIndex = 13;
            label7.Text = "Doğum Tarihi:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(252, 307);
            label9.Name = "label9";
            label9.Size = new Size(112, 19);
            label9.TabIndex = 12;
            label9.Text = "Egzersiz Sıklığı:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(252, 271);
            label8.Name = "label8";
            label8.Size = new Size(79, 19);
            label8.TabIndex = 11;
            label8.Text = "Vücut Tipi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(252, 198);
            label4.Name = "label4";
            label4.Size = new Size(65, 19);
            label4.TabIndex = 10;
            label4.Text = "Cinsiyet:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(252, 117);
            label5.Name = "label5";
            label5.Size = new Size(63, 19);
            label5.TabIndex = 9;
            label5.Text = "E-Posta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(252, 78);
            label3.Name = "label3";
            label3.Size = new Size(65, 19);
            label3.TabIndex = 15;
            label3.Text = "Soyisim:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(252, 38);
            label2.Name = "label2";
            label2.Size = new Size(40, 19);
            label2.TabIndex = 8;
            label2.Text = "İsim:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(252, 342);
            label1.Name = "label1";
            label1.Size = new Size(47, 19);
            label1.TabIndex = 12;
            label1.Text = "Statu:";
            // 
            // cmbStatu
            // 
            cmbStatu.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatu.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbStatu.FormattingEnabled = true;
            cmbStatu.Location = new Point(370, 341);
            cmbStatu.Name = "cmbStatu";
            cmbStatu.Size = new Size(171, 23);
            cmbStatu.TabIndex = 9;
            // 
            // frmKullaniciIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.MicrosoftTeams_image__13_;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(cmbStatu);
            Controls.Add(cmbEgzersiz);
            Controls.Add(cmbVucutTipi);
            Controls.Add(cmbCinsiyet);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(txtSifreKayit);
            Controls.Add(txtEpostaKayit);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvKullanici);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(btnTumunuListele);
            Name = "frmKullaniciIslemleri";
            Size = new Size(700, 634);
            Load += frmKullaniciIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKullanici).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Button btnGuncelle;
        private Button btnEkle;
        private Button btnTumunuListele;
        private DataGridView dgvKullanici;
        private Button btnSil;
        private ComboBox cmbEgzersiz;
        private ComboBox cmbVucutTipi;
        private ComboBox cmbCinsiyet;
        private DateTimePicker dtpDogumTarihi;
        private TextBox txtSifreKayit;
        private TextBox txtEpostaKayit;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private ComboBox cmbStatu;
        private Label label1;
    }
}

namespace FiftyShadesOfErrorList_UI.UserControls
{
    partial class frmBesinIslemleri
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
            btnSil = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            btnTumunuListele = new Button();
            label1 = new Label();
            txtBesinAd = new TextBox();
            label2 = new Label();
            txtMiktar = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtKalori = new TextBox();
            label5 = new Label();
            txtPorsiyon = new TextBox();
            txtBirim = new TextBox();
            label6 = new Label();
            txtKarbonhidrat = new TextBox();
            label7 = new Label();
            txtProtein = new TextBox();
            label8 = new Label();
            txtYag = new TextBox();
            label9 = new Label();
            cmbKategori = new ComboBox();
            pbBesinResim = new PictureBox();
            btnResimSec = new Button();
            dgvBesin = new DataGridView();
            label10 = new Label();
            txtBesinAra = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbBesinResim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBesin).BeginInit();
            SuspendLayout();
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Image = Properties.Resources.MicrosoftTeams_image__9_;
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.Location = new Point(0, 162);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(124, 42);
            btnSil.TabIndex = 1;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackgroundImageLayout = ImageLayout.Center;
            btnGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.Image = Properties.Resources.MicrosoftTeams_image__11_1;
            btnGuncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuncelle.Location = new Point(0, 114);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(124, 42);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.Image = Properties.Resources.MicrosoftTeams_image__10_1;
            btnEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btnEkle.Location = new Point(0, 66);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(124, 42);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnTumunuListele
            // 
            btnTumunuListele.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTumunuListele.Image = Properties.Resources.MicrosoftTeams_image__7_;
            btnTumunuListele.ImageAlign = ContentAlignment.MiddleLeft;
            btnTumunuListele.Location = new Point(3, 18);
            btnTumunuListele.Name = "btnTumunuListele";
            btnTumunuListele.Size = new Size(124, 42);
            btnTumunuListele.TabIndex = 4;
            btnTumunuListele.Text = "Listele";
            btnTumunuListele.UseVisualStyleBackColor = true;
            btnTumunuListele.Click += btnTumunuListele_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(189, 18);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 5;
            label1.Text = "Ad:";
            // 
            // txtBesinAd
            // 
            txtBesinAd.Location = new Point(274, 18);
            txtBesinAd.Name = "txtBesinAd";
            txtBesinAd.Size = new Size(141, 23);
            txtBesinAd.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(189, 47);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 5;
            label2.Text = "Miktar:";
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(274, 47);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(141, 23);
            txtMiktar.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(189, 80);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Birim:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(189, 121);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 5;
            label4.Text = "Kalori:";
            // 
            // txtKalori
            // 
            txtKalori.Location = new Point(274, 121);
            txtKalori.Name = "txtKalori";
            txtKalori.Size = new Size(141, 23);
            txtKalori.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(476, 15);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 5;
            label5.Text = "Porsiyon:";
            // 
            // txtPorsiyon
            // 
            txtPorsiyon.Location = new Point(563, 15);
            txtPorsiyon.Name = "txtPorsiyon";
            txtPorsiyon.Size = new Size(141, 23);
            txtPorsiyon.TabIndex = 5;
            // 
            // txtBirim
            // 
            txtBirim.Location = new Point(274, 80);
            txtBirim.Name = "txtBirim";
            txtBirim.Size = new Size(141, 23);
            txtBirim.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(476, 44);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 5;
            label6.Text = "Karbonhidrat:";
            // 
            // txtKarbonhidrat
            // 
            txtKarbonhidrat.Location = new Point(563, 44);
            txtKarbonhidrat.Name = "txtKarbonhidrat";
            txtKarbonhidrat.Size = new Size(141, 23);
            txtKarbonhidrat.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(476, 73);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 5;
            label7.Text = "Protein:";
            // 
            // txtProtein
            // 
            txtProtein.Location = new Point(563, 73);
            txtProtein.Name = "txtProtein";
            txtProtein.Size = new Size(141, 23);
            txtProtein.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(476, 102);
            label8.Name = "label8";
            label8.Size = new Size(29, 15);
            label8.TabIndex = 5;
            label8.Text = "Yağ:";
            // 
            // txtYag
            // 
            txtYag.Location = new Point(563, 102);
            txtYag.Name = "txtYag";
            txtYag.Size = new Size(141, 23);
            txtYag.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(478, 137);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 5;
            label9.Text = "Kategori:";
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(564, 135);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(140, 23);
            cmbKategori.TabIndex = 9;
            // 
            // pbBesinResim
            // 
            pbBesinResim.Location = new Point(478, 188);
            pbBesinResim.Name = "pbBesinResim";
            pbBesinResim.Size = new Size(133, 103);
            pbBesinResim.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBesinResim.TabIndex = 8;
            pbBesinResim.TabStop = false;
            // 
            // btnResimSec
            // 
            btnResimSec.Location = new Point(629, 206);
            btnResimSec.Name = "btnResimSec";
            btnResimSec.Size = new Size(75, 40);
            btnResimSec.TabIndex = 9;
            btnResimSec.Text = "Resim Seç";
            btnResimSec.UseVisualStyleBackColor = true;
            btnResimSec.Click += btnResimSec_Click;
            // 
            // dgvBesin
            // 
            dgvBesin.BackgroundColor = Color.Silver;
            dgvBesin.BorderStyle = BorderStyle.None;
            dgvBesin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBesin.Location = new Point(0, 317);
            dgvBesin.Name = "dgvBesin";
            dgvBesin.ReadOnly = true;
            dgvBesin.RowTemplate.Height = 25;
            dgvBesin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBesin.Size = new Size(718, 295);
            dgvBesin.TabIndex = 10;
            dgvBesin.MouseClick += dgvBesin_MouseClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 263);
            label10.Name = "label10";
            label10.Size = new Size(62, 15);
            label10.TabIndex = 5;
            label10.Text = "Besin Ara:";
            // 
            // txtBesinAra
            // 
            txtBesinAra.Location = new Point(13, 288);
            txtBesinAra.Name = "txtBesinAra";
            txtBesinAra.Size = new Size(173, 23);
            txtBesinAra.TabIndex = 6;
            txtBesinAra.TextChanged += txtBesinAra_TextChanged;
            // 
            // frmBesinIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.MicrosoftTeams_image__13_;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(dgvBesin);
            Controls.Add(btnResimSec);
            Controls.Add(pbBesinResim);
            Controls.Add(cmbKategori);
            Controls.Add(label3);
            Controls.Add(txtBesinAra);
            Controls.Add(txtYag);
            Controls.Add(txtProtein);
            Controls.Add(txtKarbonhidrat);
            Controls.Add(txtPorsiyon);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtKalori);
            Controls.Add(label7);
            Controls.Add(txtBirim);
            Controls.Add(label6);
            Controls.Add(txtMiktar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtBesinAd);
            Controls.Add(label1);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(btnTumunuListele);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "frmBesinIslemleri";
            Size = new Size(721, 615);
            Load += frmBesinIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)pbBesinResim).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBesin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSil;
        private Button btnGuncelle;
        private Button btnEkle;
        private Button btnTumunuListele;
        private Label label1;
        private TextBox txtBesinAd;
        private Label label2;
        private TextBox txtMiktar;
        private Label label3;
        private Label label4;
        private TextBox txtKalori;
        private Label label5;
        private TextBox txtPorsiyon;
        private TextBox txtBirim;
        private Label label6;
        private TextBox txtKarbonhidrat;
        private Label label7;
        private TextBox txtProtein;
        private Label label8;
        private TextBox txtYag;
        private Label label9;
        private ComboBox cmbKategori;
        private PictureBox pbBesinResim;
        private Button btnResimSec;
        private DataGridView dgvBesin;
        private Label label10;
        private TextBox txtBesinAra;
    }
}

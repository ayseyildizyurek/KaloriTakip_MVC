namespace FiftyShadesOfErrorList_UI.UserControls
{
    partial class frmKategoriIslemleri
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
            txtAd = new TextBox();
            label1 = new Label();
            dgvKategori = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvKategori).BeginInit();
            SuspendLayout();
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Image = Properties.Resources.MicrosoftTeams_image__9_;
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.Location = new Point(13, 236);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(124, 42);
            btnSil.TabIndex = 5;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.Image = Properties.Resources.MicrosoftTeams_image__11_;
            btnGuncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuncelle.Location = new Point(13, 164);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(124, 42);
            btnGuncelle.TabIndex = 6;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.Image = Properties.Resources.MicrosoftTeams_image__10_;
            btnEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btnEkle.Location = new Point(13, 100);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(124, 42);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnTumunuListele
            // 
            btnTumunuListele.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTumunuListele.Image = Properties.Resources.MicrosoftTeams_image__7_;
            btnTumunuListele.ImageAlign = ContentAlignment.MiddleLeft;
            btnTumunuListele.Location = new Point(13, 33);
            btnTumunuListele.Name = "btnTumunuListele";
            btnTumunuListele.Size = new Size(124, 42);
            btnTumunuListele.TabIndex = 8;
            btnTumunuListele.Text = "Listele";
            btnTumunuListele.UseVisualStyleBackColor = true;
            btnTumunuListele.Click += btnTumunuListele_Click;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(271, 30);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(210, 23);
            txtAd.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(173, 33);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 9;
            label1.Text = "Kategori Adı:";
            // 
            // dgvKategori
            // 
            dgvKategori.BackgroundColor = Color.Silver;
            dgvKategori.BorderStyle = BorderStyle.None;
            dgvKategori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKategori.Location = new Point(173, 59);
            dgvKategori.Name = "dgvKategori";
            dgvKategori.ReadOnly = true;
            dgvKategori.RowTemplate.Height = 25;
            dgvKategori.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKategori.Size = new Size(565, 399);
            dgvKategori.TabIndex = 11;
            dgvKategori.MouseClick += dgvKategori_MouseClick;
            // 
            // frmKategoriIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MicrosoftTeams_image__13_;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(dgvKategori);
            Controls.Add(txtAd);
            Controls.Add(label1);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(btnTumunuListele);
            Name = "frmKategoriIslemleri";
            Size = new Size(741, 596);
            Load += frmKategoriIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKategori).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSil;
        private Button btnGuncelle;
        private Button btnEkle;
        private Button btnTumunuListele;
        private TextBox txtAd;
        private Label label1;
        private DataGridView dgvKategori;
    }
}

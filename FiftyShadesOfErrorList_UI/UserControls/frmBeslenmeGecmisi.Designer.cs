namespace FiftyShadesOfErrorList_UI.UserControls
{
    partial class frmBeslenmeGecmisi
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
            label2 = new Label();
            label1 = new Label();
            dtpBaslangicTarihi = new DateTimePicker();
            dtpBitisTarihi = new DateTimePicker();
            btnTumunuGoster = new Button();
            dgvBeslenmeGecmisi = new DataGridView();
            label3 = new Label();
            lblToplamKalori = new Label();
            cmbOgunBazli = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            cmbKategoriSec = new ComboBox();
            btnTariheGoreFiltrele = new Button();
            btnOguneGoreFiltrele = new Button();
            btnKategoriyeGoreFiltrele = new Button();
            btnFavoriBesinler = new Button();
            btnOgunGrafik = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBeslenmeGecmisi).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(14, 77);
            label2.Name = "label2";
            label2.Size = new Size(117, 19);
            label2.TabIndex = 16;
            label2.Text = "Başlangıç Tarihi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(14, 115);
            label1.Name = "label1";
            label1.Size = new Size(82, 19);
            label1.TabIndex = 16;
            label1.Text = "Bitiş Tarihi:";
            // 
            // dtpBaslangicTarihi
            // 
            dtpBaslangicTarihi.Location = new Point(137, 77);
            dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            dtpBaslangicTarihi.Size = new Size(200, 23);
            dtpBaslangicTarihi.TabIndex = 1;
            // 
            // dtpBitisTarihi
            // 
            dtpBitisTarihi.Location = new Point(137, 111);
            dtpBitisTarihi.Name = "dtpBitisTarihi";
            dtpBitisTarihi.Size = new Size(200, 23);
            dtpBitisTarihi.TabIndex = 2;
            // 
            // btnTumunuGoster
            // 
            btnTumunuGoster.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTumunuGoster.Location = new Point(686, 234);
            btnTumunuGoster.Name = "btnTumunuGoster";
            btnTumunuGoster.Size = new Size(149, 49);
            btnTumunuGoster.TabIndex = 19;
            btnTumunuGoster.Text = "Tümünü Göster";
            btnTumunuGoster.UseVisualStyleBackColor = true;
            btnTumunuGoster.Click += btnTumunuGoster_Click;
            // 
            // dgvBeslenmeGecmisi
            // 
            dgvBeslenmeGecmisi.BackgroundColor = Color.Silver;
            dgvBeslenmeGecmisi.BorderStyle = BorderStyle.None;
            dgvBeslenmeGecmisi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBeslenmeGecmisi.Location = new Point(0, 302);
            dgvBeslenmeGecmisi.Name = "dgvBeslenmeGecmisi";
            dgvBeslenmeGecmisi.ReadOnly = true;
            dgvBeslenmeGecmisi.RowTemplate.Height = 25;
            dgvBeslenmeGecmisi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBeslenmeGecmisi.Size = new Size(847, 378);
            dgvBeslenmeGecmisi.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(13, 216);
            label3.Name = "label3";
            label3.Size = new Size(107, 19);
            label3.TabIndex = 16;
            label3.Text = "Toplam Kalori:";
            // 
            // lblToplamKalori
            // 
            lblToplamKalori.BackColor = Color.Transparent;
            lblToplamKalori.BorderStyle = BorderStyle.Fixed3D;
            lblToplamKalori.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamKalori.ForeColor = SystemColors.ActiveCaptionText;
            lblToplamKalori.Location = new Point(137, 215);
            lblToplamKalori.Name = "lblToplamKalori";
            lblToplamKalori.Size = new Size(200, 31);
            lblToplamKalori.TabIndex = 16;
            // 
            // cmbOgunBazli
            // 
            cmbOgunBazli.BackColor = Color.WhiteSmoke;
            cmbOgunBazli.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOgunBazli.FormattingEnabled = true;
            cmbOgunBazli.Location = new Point(137, 140);
            cmbOgunBazli.Name = "cmbOgunBazli";
            cmbOgunBazli.Size = new Size(200, 23);
            cmbOgunBazli.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(14, 144);
            label4.Name = "label4";
            label4.Size = new Size(76, 19);
            label4.TabIndex = 16;
            label4.Text = "Öğün Seç:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(11, 182);
            label5.Name = "label5";
            label5.Size = new Size(98, 19);
            label5.TabIndex = 16;
            label5.Text = "Kategori Seç:";
            // 
            // cmbKategoriSec
            // 
            cmbKategoriSec.BackColor = Color.WhiteSmoke;
            cmbKategoriSec.FormattingEnabled = true;
            cmbKategoriSec.Location = new Point(137, 181);
            cmbKategoriSec.Name = "cmbKategoriSec";
            cmbKategoriSec.Size = new Size(200, 23);
            cmbKategoriSec.TabIndex = 4;
            // 
            // btnTariheGoreFiltrele
            // 
            btnTariheGoreFiltrele.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTariheGoreFiltrele.Location = new Point(356, 77);
            btnTariheGoreFiltrele.Name = "btnTariheGoreFiltrele";
            btnTariheGoreFiltrele.Size = new Size(155, 32);
            btnTariheGoreFiltrele.TabIndex = 23;
            btnTariheGoreFiltrele.Text = "Tarihe Göre Filtrele";
            btnTariheGoreFiltrele.UseVisualStyleBackColor = true;
            btnTariheGoreFiltrele.Click += btnTariheGoreFiltrele_Click;
            // 
            // btnOguneGoreFiltrele
            // 
            btnOguneGoreFiltrele.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOguneGoreFiltrele.Location = new Point(356, 125);
            btnOguneGoreFiltrele.Name = "btnOguneGoreFiltrele";
            btnOguneGoreFiltrele.Size = new Size(155, 29);
            btnOguneGoreFiltrele.TabIndex = 23;
            btnOguneGoreFiltrele.Text = "Öğüne Göre Filtrele";
            btnOguneGoreFiltrele.UseVisualStyleBackColor = true;
            btnOguneGoreFiltrele.Click += btnOguneGoreFiltrele_Click;
            // 
            // btnKategoriyeGoreFiltrele
            // 
            btnKategoriyeGoreFiltrele.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKategoriyeGoreFiltrele.Location = new Point(356, 174);
            btnKategoriyeGoreFiltrele.Name = "btnKategoriyeGoreFiltrele";
            btnKategoriyeGoreFiltrele.Size = new Size(155, 30);
            btnKategoriyeGoreFiltrele.TabIndex = 23;
            btnKategoriyeGoreFiltrele.Text = "Kategoriye Göre Filtrele";
            btnKategoriyeGoreFiltrele.UseVisualStyleBackColor = true;
            btnKategoriyeGoreFiltrele.Click += btnKategoriyeGoreFiltrele_Click;
            // 
            // btnFavoriBesinler
            // 
            btnFavoriBesinler.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFavoriBesinler.Location = new Point(356, 216);
            btnFavoriBesinler.Name = "btnFavoriBesinler";
            btnFavoriBesinler.Size = new Size(155, 30);
            btnFavoriBesinler.TabIndex = 24;
            btnFavoriBesinler.Text = "Favori Besinler";
            btnFavoriBesinler.UseVisualStyleBackColor = true;
            btnFavoriBesinler.Click += btnFavoriBesinler_Click;
            // 
            // btnOgunGrafik
            // 
            btnOgunGrafik.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOgunGrafik.Location = new Point(686, 174);
            btnOgunGrafik.Name = "btnOgunGrafik";
            btnOgunGrafik.Size = new Size(149, 43);
            btnOgunGrafik.TabIndex = 25;
            btnOgunGrafik.Text = "Grafik Göster";
            btnOgunGrafik.UseVisualStyleBackColor = true;
            btnOgunGrafik.Click += btnOgunGrafik_Click;
            // 
            // frmBeslenmeGecmisi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MicrosoftTeams_image__13_;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(btnOgunGrafik);
            Controls.Add(btnFavoriBesinler);
            Controls.Add(btnKategoriyeGoreFiltrele);
            Controls.Add(btnOguneGoreFiltrele);
            Controls.Add(btnTariheGoreFiltrele);
            Controls.Add(cmbKategoriSec);
            Controls.Add(cmbOgunBazli);
            Controls.Add(dgvBeslenmeGecmisi);
            Controls.Add(btnTumunuGoster);
            Controls.Add(dtpBitisTarihi);
            Controls.Add(dtpBaslangicTarihi);
            Controls.Add(lblToplamKalori);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "frmBeslenmeGecmisi";
            Size = new Size(923, 752);
            Load += frmBeslenmeGecmisi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBeslenmeGecmisi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private DateTimePicker dtpBaslangicTarihi;
        private DateTimePicker dtpBitisTarihi;
        private Button btnTumunuGoster;
        private DataGridView dgvBeslenmeGecmisi;
        private Label label3;
        private Label lblToplamKalori;
        private ComboBox cmbOgunBazli;
        private Label label4;
        private Label label5;
        private ComboBox cmbKategoriSec;
        private Button btnTariheGoreFiltrele;
        private Button btnOguneGoreFiltrele;
        private Button btnKategoriyeGoreFiltrele;
        private Button btnFavoriBesinler;
        private Button btnOgunGrafik;
    }
}

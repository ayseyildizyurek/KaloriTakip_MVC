namespace FiftyShadesOfErrorList_UI.UserControls
{
    partial class frmOgunEkle
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
            label1 = new Label();
            label2 = new Label();
            cmbogunSec = new ComboBox();
            cmbKategoriSec = new ComboBox();
            label3 = new Label();
            cmbBesinSec = new ComboBox();
            label6 = new Label();
            dgvKahvalti = new DataGridView();
            btnKaydet = new Button();
            btnListele = new Button();
            btnSil = new Button();
            lblPorsiyonBilgileri = new Label();
            label5 = new Label();
            nudMiktar = new NumericUpDown();
            dgvOgle = new DataGridView();
            dgvAksam = new DataGridView();
            dgvAraOgun = new DataGridView();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKahvalti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMiktar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOgle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAksam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAraOgun).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(17, 79);
            label1.Name = "label1";
            label1.Size = new Size(98, 19);
            label1.TabIndex = 15;
            label1.Text = "Kategori Seç:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(17, 36);
            label2.Name = "label2";
            label2.Size = new Size(76, 19);
            label2.TabIndex = 15;
            label2.Text = "Öğün Seç:";
            // 
            // cmbogunSec
            // 
            cmbogunSec.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbogunSec.FormattingEnabled = true;
            cmbogunSec.Location = new Point(125, 36);
            cmbogunSec.Name = "cmbogunSec";
            cmbogunSec.Size = new Size(179, 23);
            cmbogunSec.TabIndex = 1;
            // 
            // cmbKategoriSec
            // 
            cmbKategoriSec.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategoriSec.FormattingEnabled = true;
            cmbKategoriSec.Location = new Point(125, 78);
            cmbKategoriSec.Name = "cmbKategoriSec";
            cmbKategoriSec.Size = new Size(179, 23);
            cmbKategoriSec.TabIndex = 2;
            cmbKategoriSec.TextChanged += cmbKategoriSec_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(17, 122);
            label3.Name = "label3";
            label3.Size = new Size(75, 19);
            label3.TabIndex = 15;
            label3.Text = "Besin Seç:";
            // 
            // cmbBesinSec
            // 
            cmbBesinSec.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBesinSec.FormattingEnabled = true;
            cmbBesinSec.Location = new Point(125, 121);
            cmbBesinSec.Name = "cmbBesinSec";
            cmbBesinSec.Size = new Size(179, 23);
            cmbBesinSec.TabIndex = 3;
            cmbBesinSec.TextChanged += cmbBesinSec_TextChanged;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(355, 36);
            label6.Name = "label6";
            label6.Size = new Size(85, 47);
            label6.TabIndex = 15;
            label6.Text = "Porsiyon Bilgileri:";
            // 
            // dgvKahvalti
            // 
            dgvKahvalti.BackgroundColor = Color.Silver;
            dgvKahvalti.BorderStyle = BorderStyle.None;
            dgvKahvalti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKahvalti.Location = new Point(3, 239);
            dgvKahvalti.Name = "dgvKahvalti";
            dgvKahvalti.ReadOnly = true;
            dgvKahvalti.RowTemplate.Height = 25;
            dgvKahvalti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKahvalti.Size = new Size(230, 510);
            dgvKahvalti.TabIndex = 17;
            dgvKahvalti.MouseClick += dgvKahvalti_MouseClick;
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.Image = Properties.Resources.besinekle;
            btnKaydet.ImageAlign = ContentAlignment.MiddleLeft;
            btnKaydet.Location = new Point(689, 67);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(136, 41);
            btnKaydet.TabIndex = 18;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnListele
            // 
            btnListele.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnListele.Image = Properties.Resources.MicrosoftTeams_image__7_;
            btnListele.ImageAlign = ContentAlignment.MiddleLeft;
            btnListele.Location = new Point(689, 14);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(136, 41);
            btnListele.TabIndex = 18;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Image = Properties.Resources.besincikar;
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.Location = new Point(689, 114);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(136, 41);
            btnSil.TabIndex = 18;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // lblPorsiyonBilgileri
            // 
            lblPorsiyonBilgileri.BorderStyle = BorderStyle.Fixed3D;
            lblPorsiyonBilgileri.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPorsiyonBilgileri.ForeColor = SystemColors.ActiveCaptionText;
            lblPorsiyonBilgileri.Location = new Point(463, 36);
            lblPorsiyonBilgileri.Name = "lblPorsiyonBilgileri";
            lblPorsiyonBilgileri.Size = new Size(179, 35);
            lblPorsiyonBilgileri.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(356, 93);
            label5.Name = "label5";
            label5.Size = new Size(58, 19);
            label5.TabIndex = 15;
            label5.Text = "Miktar:";
            // 
            // nudMiktar
            // 
            nudMiktar.Location = new Point(463, 93);
            nudMiktar.Name = "nudMiktar";
            nudMiktar.Size = new Size(179, 23);
            nudMiktar.TabIndex = 5;
            // 
            // dgvOgle
            // 
            dgvOgle.BackgroundColor = Color.Silver;
            dgvOgle.BorderStyle = BorderStyle.None;
            dgvOgle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgle.Location = new Point(229, 239);
            dgvOgle.Name = "dgvOgle";
            dgvOgle.ReadOnly = true;
            dgvOgle.RowTemplate.Height = 25;
            dgvOgle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOgle.Size = new Size(230, 510);
            dgvOgle.TabIndex = 20;
            dgvOgle.MouseClick += dgvOgle_MouseClick;
            // 
            // dgvAksam
            // 
            dgvAksam.BackgroundColor = Color.Silver;
            dgvAksam.BorderStyle = BorderStyle.None;
            dgvAksam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAksam.Location = new Point(459, 239);
            dgvAksam.Name = "dgvAksam";
            dgvAksam.ReadOnly = true;
            dgvAksam.RowTemplate.Height = 25;
            dgvAksam.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAksam.Size = new Size(230, 510);
            dgvAksam.TabIndex = 21;
            dgvAksam.MouseClick += dgvAksam_MouseClick;
            // 
            // dgvAraOgun
            // 
            dgvAraOgun.BackgroundColor = Color.Silver;
            dgvAraOgun.BorderStyle = BorderStyle.None;
            dgvAraOgun.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAraOgun.Location = new Point(689, 239);
            dgvAraOgun.Name = "dgvAraOgun";
            dgvAraOgun.ReadOnly = true;
            dgvAraOgun.RowTemplate.Height = 25;
            dgvAraOgun.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAraOgun.Size = new Size(230, 510);
            dgvAraOgun.TabIndex = 21;
            dgvAraOgun.MouseClick += dgvAraOgun_MouseClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(17, 206);
            label4.Name = "label4";
            label4.Size = new Size(67, 19);
            label4.TabIndex = 15;
            label4.Text = "Kahvaltı:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(229, 206);
            label7.Name = "label7";
            label7.Size = new Size(45, 19);
            label7.TabIndex = 15;
            label7.Text = "Öğle:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(459, 206);
            label8.Name = "label8";
            label8.Size = new Size(58, 19);
            label8.TabIndex = 15;
            label8.Text = "Akşam:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(689, 206);
            label9.Name = "label9";
            label9.Size = new Size(77, 19);
            label9.TabIndex = 15;
            label9.Text = "Ara Öğün:";
            // 
            // frmOgunEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MicrosoftTeams_image__13_;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(dgvAraOgun);
            Controls.Add(dgvAksam);
            Controls.Add(dgvOgle);
            Controls.Add(nudMiktar);
            Controls.Add(btnSil);
            Controls.Add(btnListele);
            Controls.Add(btnKaydet);
            Controls.Add(dgvKahvalti);
            Controls.Add(cmbBesinSec);
            Controls.Add(cmbKategoriSec);
            Controls.Add(cmbogunSec);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(lblPorsiyonBilgileri);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "frmOgunEkle";
            Size = new Size(923, 752);
            Load += frmOgunEkle_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKahvalti).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMiktar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOgle).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAksam).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAraOgun).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbogunSec;
        private ComboBox cmbKategoriSec;
        private Label label3;
        private ComboBox cmbBesinSec;
        private Label label6;
        private DataGridView dgvKahvalti;
        private Button btnKaydet;
        private Button btnListele;
        private Button btnSil;
        private Label lblPorsiyonBilgileri;
        private Label label5;
        private NumericUpDown nudMiktar;
        private DataGridView dgvOgle;
        private DataGridView dgvAksam;
        private DataGridView dgvAraOgun;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}

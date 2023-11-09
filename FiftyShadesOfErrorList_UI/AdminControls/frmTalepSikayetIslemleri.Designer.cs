namespace FiftyShadesOfErrorList_UI.UserControls
{
    partial class frmTalepSikayetIslemleri
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
            btnTumunuListele = new Button();
            btnOkunduGuncelle = new Button();
            dgvIstekSikayet = new DataGridView();
            chOkunduMu = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvIstekSikayet).BeginInit();
            SuspendLayout();
            // 
            // btnTumunuListele
            // 
            btnTumunuListele.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTumunuListele.Image = Properties.Resources.MicrosoftTeams_image__7_;
            btnTumunuListele.ImageAlign = ContentAlignment.MiddleLeft;
            btnTumunuListele.Location = new Point(3, 25);
            btnTumunuListele.Name = "btnTumunuListele";
            btnTumunuListele.Size = new Size(147, 46);
            btnTumunuListele.TabIndex = 9;
            btnTumunuListele.Text = "Tümünü Listele";
            btnTumunuListele.UseVisualStyleBackColor = true;
            btnTumunuListele.Click += btnTumunuListele_Click;
            // 
            // btnOkunduGuncelle
            // 
            btnOkunduGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOkunduGuncelle.Image = Properties.Resources.MicrosoftTeams_image__14_1;
            btnOkunduGuncelle.ImageAlign = ContentAlignment.TopLeft;
            btnOkunduGuncelle.Location = new Point(3, 161);
            btnOkunduGuncelle.Name = "btnOkunduGuncelle";
            btnOkunduGuncelle.Size = new Size(124, 43);
            btnOkunduGuncelle.TabIndex = 10;
            btnOkunduGuncelle.Text = "       Okundu Olarak Guncelle";
            btnOkunduGuncelle.UseVisualStyleBackColor = true;
            btnOkunduGuncelle.Click += btnOkunduGuncelle_Click;
            // 
            // dgvIstekSikayet
            // 
            dgvIstekSikayet.BackgroundColor = Color.Silver;
            dgvIstekSikayet.BorderStyle = BorderStyle.None;
            dgvIstekSikayet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIstekSikayet.Location = new Point(170, 25);
            dgvIstekSikayet.Name = "dgvIstekSikayet";
            dgvIstekSikayet.ReadOnly = true;
            dgvIstekSikayet.RowTemplate.Height = 25;
            dgvIstekSikayet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIstekSikayet.Size = new Size(591, 449);
            dgvIstekSikayet.TabIndex = 11;
            dgvIstekSikayet.MouseClick += dgvIstekSikayet_MouseClick;
            // 
            // chOkunduMu
            // 
            chOkunduMu.BackColor = Color.Transparent;
            chOkunduMu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chOkunduMu.ImageAlign = ContentAlignment.TopRight;
            chOkunduMu.Location = new Point(3, 105);
            chOkunduMu.Name = "chOkunduMu";
            chOkunduMu.Size = new Size(103, 36);
            chOkunduMu.TabIndex = 13;
            chOkunduMu.Text = "Okundu";
            chOkunduMu.UseVisualStyleBackColor = false;
            // 
            // frmTalepSikayetIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MicrosoftTeams_image__13_;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(chOkunduMu);
            Controls.Add(dgvIstekSikayet);
            Controls.Add(btnOkunduGuncelle);
            Controls.Add(btnTumunuListele);
            Name = "frmTalepSikayetIslemleri";
            Size = new Size(764, 477);
            Load += frmTalepSikayetIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIstekSikayet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTumunuListele;
        private Button btnOkunduGuncelle;
        private DataGridView dgvIstekSikayet;
        private CheckBox chOkunduMu;
    }
}

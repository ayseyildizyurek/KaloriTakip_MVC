namespace FiftyShadesOfErrorList_UI
{
    partial class AdminEkrani
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminEkrani));
            btnKullaniciIslemleri = new Button();
            btnBesinIslemleri = new Button();
            btnKategoriIslemleri = new Button();
            btnTalepSikayetIslemleri = new Button();
            panel1 = new Panel();
            ımageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnKullaniciIslemleri
            // 
            btnKullaniciIslemleri.BackgroundImageLayout = ImageLayout.Stretch;
            btnKullaniciIslemleri.Image = Properties.Resources.MicrosoftTeams_image__4_2;
            btnKullaniciIslemleri.ImageAlign = ContentAlignment.MiddleLeft;
            btnKullaniciIslemleri.Location = new Point(12, 98);
            btnKullaniciIslemleri.Name = "btnKullaniciIslemleri";
            btnKullaniciIslemleri.Size = new Size(131, 38);
            btnKullaniciIslemleri.TabIndex = 0;
            btnKullaniciIslemleri.Text = "Kullanıcı İşlemleri";
            btnKullaniciIslemleri.TextAlign = ContentAlignment.MiddleRight;
            btnKullaniciIslemleri.UseVisualStyleBackColor = true;
            btnKullaniciIslemleri.Click += btnKullaniciIslemleri_Click;
            // 
            // btnBesinIslemleri
            // 
            btnBesinIslemleri.Image = (Image)resources.GetObject("btnBesinIslemleri.Image");
            btnBesinIslemleri.ImageAlign = ContentAlignment.MiddleLeft;
            btnBesinIslemleri.Location = new Point(12, 142);
            btnBesinIslemleri.Name = "btnBesinIslemleri";
            btnBesinIslemleri.Size = new Size(131, 38);
            btnBesinIslemleri.TabIndex = 0;
            btnBesinIslemleri.Text = "Besin İşlemleri     ";
            btnBesinIslemleri.TextAlign = ContentAlignment.MiddleRight;
            btnBesinIslemleri.UseVisualStyleBackColor = true;
            btnBesinIslemleri.Click += btnBesinIslemleri_Click;
            // 
            // btnKategoriIslemleri
            // 
            btnKategoriIslemleri.Image = (Image)resources.GetObject("btnKategoriIslemleri.Image");
            btnKategoriIslemleri.ImageAlign = ContentAlignment.MiddleLeft;
            btnKategoriIslemleri.Location = new Point(12, 186);
            btnKategoriIslemleri.Name = "btnKategoriIslemleri";
            btnKategoriIslemleri.Size = new Size(131, 38);
            btnKategoriIslemleri.TabIndex = 0;
            btnKategoriIslemleri.Text = "Kategori İşlemleri";
            btnKategoriIslemleri.TextAlign = ContentAlignment.MiddleRight;
            btnKategoriIslemleri.UseVisualStyleBackColor = true;
            btnKategoriIslemleri.Click += btnKategoriIslemleri_Click;
            // 
            // btnTalepSikayetIslemleri
            // 
            btnTalepSikayetIslemleri.Image = (Image)resources.GetObject("btnTalepSikayetIslemleri.Image");
            btnTalepSikayetIslemleri.ImageAlign = ContentAlignment.MiddleLeft;
            btnTalepSikayetIslemleri.Location = new Point(12, 230);
            btnTalepSikayetIslemleri.Name = "btnTalepSikayetIslemleri";
            btnTalepSikayetIslemleri.Size = new Size(131, 38);
            btnTalepSikayetIslemleri.TabIndex = 0;
            btnTalepSikayetIslemleri.Text = "Talep Şikayet         ";
            btnTalepSikayetIslemleri.TextAlign = ContentAlignment.MiddleRight;
            btnTalepSikayetIslemleri.UseVisualStyleBackColor = true;
            btnTalepSikayetIslemleri.Click += btnTalepSikayetIslemleri_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.BackgroundImage = Properties.Resources.MicrosoftTeams_image__13_;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(149, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(705, 633);
            panel1.TabIndex = 1;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageSize = new Size(16, 16);
            ımageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(1, 386);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // AdminEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(858, 635);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(btnTalepSikayetIslemleri);
            Controls.Add(btnKategoriIslemleri);
            Controls.Add(btnBesinIslemleri);
            Controls.Add(btnKullaniciIslemleri);
            DoubleBuffered = true;
            Name = "AdminEkrani";
            Text = "AdminEkrani";
            Load += AdminEkrani_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnKullaniciIslemleri;
        private Button btnBesinIslemleri;
        private Button btnKategoriIslemleri;
        private Button btnTalepSikayetIslemleri;
        private Panel panel1;
        private ImageList ımageList1;
        private PictureBox pictureBox1;
    }
}
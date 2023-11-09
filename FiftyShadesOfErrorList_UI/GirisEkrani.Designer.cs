using System.Windows.Forms;

namespace FiftyShadesOfErrorList_UI
{
    partial class GirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            label1 = new Label();
            grpGiris = new GroupBox();
            pictureBox1 = new PictureBox();
            btnKaydol = new Button();
            btnGirisYap = new Button();
            txtSifre = new TextBox();
            txtEposta = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            grpGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Yu Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(753, 81);
            label1.TabIndex = 1;
            label1.Text = "SAĞLIKLI BESLENME VE FORMDA KALMA YOLCULUĞUNA KATILIN!";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // grpGiris
            // 
            grpGiris.BackColor = Color.Transparent;
            grpGiris.Controls.Add(pictureBox1);
            grpGiris.Controls.Add(btnKaydol);
            grpGiris.Controls.Add(btnGirisYap);
            grpGiris.Controls.Add(txtSifre);
            grpGiris.Controls.Add(txtEposta);
            grpGiris.Controls.Add(label4);
            grpGiris.Controls.Add(label3);
            grpGiris.Controls.Add(label2);
            grpGiris.Dock = DockStyle.Left;
            grpGiris.Location = new Point(0, 81);
            grpGiris.Name = "grpGiris";
            grpGiris.Size = new Size(248, 446);
            grpGiris.TabIndex = 2;
            grpGiris.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(39, 239);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnKaydol
            // 
            btnKaydol.BackColor = Color.Silver;
            btnKaydol.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydol.Location = new Point(144, 169);
            btnKaydol.Name = "btnKaydol";
            btnKaydol.Size = new Size(69, 26);
            btnKaydol.TabIndex = 4;
            btnKaydol.Text = "Kaydol";
            btnKaydol.UseVisualStyleBackColor = false;
            btnKaydol.Click += btnKaydol_Click;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.Silver;
            btnGirisYap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGirisYap.ForeColor = SystemColors.ActiveCaptionText;
            btnGirisYap.Location = new Point(84, 117);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(129, 24);
            btnGirisYap.TabIndex = 3;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.WhiteSmoke;
            txtSifre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifre.Location = new Point(84, 77);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(129, 23);
            txtSifre.TabIndex = 2;
            // 
            // txtEposta
            // 
            txtEposta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtEposta.Location = new Point(84, 37);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(129, 23);
            txtEposta.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(15, 169);
            label4.Name = "label4";
            label4.Size = new Size(123, 19);
            label4.TabIndex = 0;
            label4.Text = "Hesabın yok mu?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(15, 78);
            label3.Name = "label3";
            label3.Size = new Size(44, 19);
            label3.TabIndex = 0;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(15, 38);
            label2.Name = "label2";
            label2.Size = new Size(63, 19);
            label2.TabIndex = 0;
            label2.Text = "E-Posta:";
            // 
            // GirisEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(753, 527);
            Controls.Add(grpGiris);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GirisEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Ekranı";
            grpGiris.ResumeLayout(false);
            grpGiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private GroupBox grpGiris;
        private Button btnGirisYap;
        private TextBox txtSifre;
        private TextBox txtEposta;
        private Label label3;
        private Label label2;
        private Button btnKaydol;
        private Label label4;
        private PictureBox pictureBox1;
    }
}
namespace FiftyShadesOfErrorList_UI.UserControls
{
    partial class frmSuTakibi
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
            nudSuMiktari = new NumericUpDown();
            btnEkle = new Button();
            label6 = new Label();
            lblGunlukSuMiktari = new Label();
            label3 = new Label();
            lblIcilen = new Label();
            lblOlmasiGereken = new Label();
            pbSizinIctiginiz = new ProgressBar();
            lblSizinIctiginizSu = new Label();
            lblOlmasiGerekenSu = new Label();
            pbOlmasiGereken = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)nudSuMiktari).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(264, 181);
            label1.Name = "label1";
            label1.Size = new Size(81, 19);
            label1.TabIndex = 16;
            label1.Text = "Su Miktarı:";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(442, 181);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 17;
            label2.Text = "Su Bardağı (200 ml)";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudSuMiktari
            // 
            nudSuMiktari.Location = new Point(364, 181);
            nudSuMiktari.Name = "nudSuMiktari";
            nudSuMiktari.Size = new Size(72, 23);
            nudSuMiktari.TabIndex = 18;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.Image = Properties.Resources.suicme;
            btnEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btnEkle.Location = new Point(484, 219);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(102, 40);
            btnEkle.TabIndex = 19;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(264, 302);
            label6.Name = "label6";
            label6.Size = new Size(112, 60);
            label6.TabIndex = 20;
            label6.Text = "Günlük İçmen Gereken Su Miktarı:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGunlukSuMiktari
            // 
            lblGunlukSuMiktari.BackColor = Color.Transparent;
            lblGunlukSuMiktari.BorderStyle = BorderStyle.Fixed3D;
            lblGunlukSuMiktari.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblGunlukSuMiktari.Location = new Point(382, 308);
            lblGunlukSuMiktari.Name = "lblGunlukSuMiktari";
            lblGunlukSuMiktari.Size = new Size(204, 51);
            lblGunlukSuMiktari.TabIndex = 17;
            lblGunlukSuMiktari.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(391, 92);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 16;
            label3.Text = "SU TAKİBİ";
            // 
            // lblIcilen
            // 
            lblIcilen.AutoSize = true;
            lblIcilen.BackColor = Color.Transparent;
            lblIcilen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblIcilen.Location = new Point(795, 488);
            lblIcilen.Name = "lblIcilen";
            lblIcilen.Size = new Size(0, 15);
            lblIcilen.TabIndex = 25;
            // 
            // lblOlmasiGereken
            // 
            lblOlmasiGereken.AutoSize = true;
            lblOlmasiGereken.BackColor = Color.Transparent;
            lblOlmasiGereken.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOlmasiGereken.Location = new Point(795, 441);
            lblOlmasiGereken.Name = "lblOlmasiGereken";
            lblOlmasiGereken.Size = new Size(0, 15);
            lblOlmasiGereken.TabIndex = 26;
            // 
            // pbSizinIctiginiz
            // 
            pbSizinIctiginiz.Location = new Point(149, 476);
            pbSizinIctiginiz.Name = "pbSizinIctiginiz";
            pbSizinIctiginiz.Size = new Size(616, 27);
            pbSizinIctiginiz.TabIndex = 21;
            // 
            // lblSizinIctiginizSu
            // 
            lblSizinIctiginizSu.AutoSize = true;
            lblSizinIctiginizSu.BackColor = Color.Transparent;
            lblSizinIctiginizSu.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblSizinIctiginizSu.Location = new Point(20, 484);
            lblSizinIctiginizSu.Name = "lblSizinIctiginizSu";
            lblSizinIctiginizSu.Size = new Size(96, 19);
            lblSizinIctiginizSu.TabIndex = 23;
            lblSizinIctiginizSu.Text = "Sizin İçtiğiniz";
            // 
            // lblOlmasiGerekenSu
            // 
            lblOlmasiGerekenSu.AutoSize = true;
            lblOlmasiGerekenSu.BackColor = Color.Transparent;
            lblOlmasiGerekenSu.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblOlmasiGerekenSu.Location = new Point(18, 437);
            lblOlmasiGerekenSu.Name = "lblOlmasiGerekenSu";
            lblOlmasiGerekenSu.Size = new Size(115, 19);
            lblOlmasiGerekenSu.TabIndex = 24;
            lblOlmasiGerekenSu.Text = "Olması Gereken";
            // 
            // pbOlmasiGereken
            // 
            pbOlmasiGereken.Location = new Point(149, 429);
            pbOlmasiGereken.Name = "pbOlmasiGereken";
            pbOlmasiGereken.Size = new Size(616, 27);
            pbOlmasiGereken.TabIndex = 22;
            // 
            // frmSuTakibi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MicrosoftTeams_image__13_;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(lblIcilen);
            Controls.Add(lblOlmasiGereken);
            Controls.Add(pbSizinIctiginiz);
            Controls.Add(lblSizinIctiginizSu);
            Controls.Add(lblOlmasiGerekenSu);
            Controls.Add(pbOlmasiGereken);
            Controls.Add(label6);
            Controls.Add(btnEkle);
            Controls.Add(nudSuMiktari);
            Controls.Add(lblGunlukSuMiktari);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "frmSuTakibi";
            Size = new Size(923, 752);
            Load += frmSuTakibi_Load;
            ((System.ComponentModel.ISupportInitialize)nudSuMiktari).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown nudSuMiktari;
        private Button btnEkle;
        private Label label6;
        private Label lblGunlukSuMiktari;
        private Label label3;
        private Label lblIcilen;
        private Label lblOlmasiGereken;
        private ProgressBar pbSizinIctiginiz;
        private Label lblSizinIctiginizSu;
        private Label lblOlmasiGerekenSu;
        private ProgressBar pbOlmasiGereken;
    }
}

namespace FiftyShadesOfErrorList_UI.UserControls
{
    partial class frmIdealKiloHesapla
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
            rdbErkek = new RadioButton();
            rdbKadin = new RadioButton();
            label1 = new Label();
            txtBoy = new TextBox();
            label3 = new Label();
            txtKilo = new TextBox();
            btnHesapla = new Button();
            label4 = new Label();
            lblIdealKilo = new Label();
            lblHedefKilo = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(288, 139);
            label2.Name = "label2";
            label2.Size = new Size(65, 19);
            label2.TabIndex = 14;
            label2.Text = "Cinsiyet:";
            // 
            // rdbErkek
            // 
            rdbErkek.BackColor = Color.Transparent;
            rdbErkek.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdbErkek.Image = Properties.Resources.erkek;
            rdbErkek.ImageAlign = ContentAlignment.MiddleLeft;
            rdbErkek.Location = new Point(388, 130);
            rdbErkek.Name = "rdbErkek";
            rdbErkek.Size = new Size(80, 37);
            rdbErkek.TabIndex = 1;
            rdbErkek.TabStop = true;
            rdbErkek.Text = "Erkek";
            rdbErkek.TextAlign = ContentAlignment.MiddleRight;
            rdbErkek.UseVisualStyleBackColor = false;
            // 
            // rdbKadin
            // 
            rdbKadin.BackColor = Color.Transparent;
            rdbKadin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdbKadin.Image = Properties.Resources.kadin;
            rdbKadin.ImageAlign = ContentAlignment.MiddleLeft;
            rdbKadin.Location = new Point(485, 130);
            rdbKadin.Name = "rdbKadin";
            rdbKadin.Size = new Size(80, 37);
            rdbKadin.TabIndex = 2;
            rdbKadin.TabStop = true;
            rdbKadin.Text = "Kadın";
            rdbKadin.TextAlign = ContentAlignment.MiddleRight;
            rdbKadin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(288, 182);
            label1.Name = "label1";
            label1.Size = new Size(73, 19);
            label1.TabIndex = 14;
            label1.Text = "Boy (cm):";
            // 
            // txtBoy
            // 
            txtBoy.Location = new Point(388, 182);
            txtBoy.Name = "txtBoy";
            txtBoy.Size = new Size(210, 23);
            txtBoy.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(288, 220);
            label3.Name = "label3";
            label3.Size = new Size(70, 19);
            label3.TabIndex = 14;
            label3.Text = "Kilo (kg):";
            // 
            // txtKilo
            // 
            txtKilo.Location = new Point(388, 219);
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(210, 23);
            txtKilo.TabIndex = 4;
            // 
            // btnHesapla
            // 
            btnHesapla.BackColor = Color.Transparent;
            btnHesapla.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnHesapla.Image = Properties.Resources.hesapla;
            btnHesapla.ImageAlign = ContentAlignment.MiddleLeft;
            btnHesapla.Location = new Point(473, 263);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(125, 38);
            btnHesapla.TabIndex = 5;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = false;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(347, 332);
            label4.Name = "label4";
            label4.Size = new Size(99, 19);
            label4.TabIndex = 14;
            label4.Text = "İdeal Kilonuz:";
            // 
            // lblIdealKilo
            // 
            lblIdealKilo.BackColor = Color.Transparent;
            lblIdealKilo.BorderStyle = BorderStyle.Fixed3D;
            lblIdealKilo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdealKilo.ForeColor = SystemColors.ActiveCaptionText;
            lblIdealKilo.Location = new Point(473, 324);
            lblIdealKilo.Name = "lblIdealKilo";
            lblIdealKilo.Size = new Size(125, 32);
            lblIdealKilo.TabIndex = 14;
            lblIdealKilo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHedefKilo
            // 
            lblHedefKilo.BackColor = Color.Transparent;
            lblHedefKilo.BorderStyle = BorderStyle.Fixed3D;
            lblHedefKilo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHedefKilo.ForeColor = SystemColors.ActiveCaptionText;
            lblHedefKilo.Location = new Point(288, 397);
            lblHedefKilo.Name = "lblHedefKilo";
            lblHedefKilo.Size = new Size(310, 98);
            lblHedefKilo.TabIndex = 14;
            lblHedefKilo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(347, 87);
            label5.Name = "label5";
            label5.Size = new Size(189, 17);
            label5.TabIndex = 18;
            label5.Text = "İDEAL KİLO HESAPLAMA";
            // 
            // frmIdealKiloHesapla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MicrosoftTeams_image__13_;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(label5);
            Controls.Add(btnHesapla);
            Controls.Add(txtKilo);
            Controls.Add(txtBoy);
            Controls.Add(rdbKadin);
            Controls.Add(rdbErkek);
            Controls.Add(lblHedefKilo);
            Controls.Add(lblIdealKilo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "frmIdealKiloHesapla";
            Size = new Size(923, 752);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private RadioButton rdbErkek;
        private RadioButton rdbKadin;
        private Label label1;
        private TextBox txtBoy;
        private Label label3;
        private TextBox txtKilo;
        private Button btnHesapla;
        private Label label4;
        private Label lblIdealKilo;
        private Label lblHedefKilo;
        private Label label5;
    }
}

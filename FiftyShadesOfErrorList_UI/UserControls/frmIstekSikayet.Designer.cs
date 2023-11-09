namespace FiftyShadesOfErrorList_UI.UserControls
{
    partial class frmIstekSikayet
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
            label5 = new Label();
            label1 = new Label();
            txtBaslik = new TextBox();
            txtAciklama = new TextBox();
            label2 = new Label();
            btnGonder = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(335, 94);
            label5.Name = "label5";
            label5.Size = new Size(211, 17);
            label5.TabIndex = 19;
            label5.Text = "BİZİMLE İLETİŞİME GEÇİNİZ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(207, 159);
            label1.Name = "label1";
            label1.Size = new Size(404, 17);
            label1.TabIndex = 19;
            label1.Text = "Bizimle Hangi Konuda İletişime Geçmek İstiyorsunuz ? ";
            // 
            // txtBaslik
            // 
            txtBaslik.Location = new Point(207, 198);
            txtBaslik.Name = "txtBaslik";
            txtBaslik.Size = new Size(307, 23);
            txtBaslik.TabIndex = 1;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(207, 291);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.ScrollBars = ScrollBars.Vertical;
            txtAciklama.Size = new Size(445, 187);
            txtAciklama.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(207, 253);
            label2.Name = "label2";
            label2.Size = new Size(122, 17);
            label2.TabIndex = 21;
            label2.Text = "Talep/Şikayet : ";
            // 
            // btnGonder
            // 
            btnGonder.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGonder.Image = Properties.Resources.talepsikayet;
            btnGonder.ImageAlign = ContentAlignment.MiddleLeft;
            btnGonder.Location = new Point(373, 496);
            btnGonder.Name = "btnGonder";
            btnGonder.Size = new Size(141, 50);
            btnGonder.TabIndex = 22;
            btnGonder.Text = "Gönder";
            btnGonder.UseVisualStyleBackColor = true;
            btnGonder.Click += btnGonder_Click;
            // 
            // frmIstekSikayet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MicrosoftTeams_image__13_;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(btnGonder);
            Controls.Add(label2);
            Controls.Add(txtAciklama);
            Controls.Add(txtBaslik);
            Controls.Add(label1);
            Controls.Add(label5);
            Name = "frmIstekSikayet";
            Size = new Size(923, 752);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label1;
        private TextBox txtBaslik;
        private TextBox txtAciklama;
        private Label label2;
        private Button btnGonder;
    }
}

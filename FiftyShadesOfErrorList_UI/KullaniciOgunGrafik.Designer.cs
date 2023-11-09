namespace FiftyShadesOfErrorList_UI
{
    partial class KullaniciOgunGrafik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            lblTarih = new Label();
            dtpGrafikTarih = new DateTimePicker();
            btnGrafikGetir = new Button();
            ((System.ComponentModel.ISupportInitialize)chartPie).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chartPie
            // 
            chartArea2.Name = "ChartArea1";
            chartPie.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartPie.Legends.Add(legend2);
            chartPie.Location = new Point(3, 3);
            chartPie.Name = "chartPie";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartPie.Series.Add(series2);
            chartPie.Size = new Size(595, 474);
            chartPie.TabIndex = 0;
            chartPie.Text = "chart1";
            // 
            // panel1
            // 
            panel1.Controls.Add(chartPie);
            panel1.Location = new Point(348, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(601, 480);
            panel1.TabIndex = 1;
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.BackColor = Color.Transparent;
            lblTarih.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTarih.Location = new Point(14, 105);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(34, 15);
            lblTarih.TabIndex = 2;
            lblTarih.Text = "Tarih";
            // 
            // dtpGrafikTarih
            // 
            dtpGrafikTarih.Location = new Point(71, 99);
            dtpGrafikTarih.Name = "dtpGrafikTarih";
            dtpGrafikTarih.Size = new Size(190, 23);
            dtpGrafikTarih.TabIndex = 3;
            // 
            // btnGrafikGetir
            // 
            btnGrafikGetir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGrafikGetir.Location = new Point(136, 128);
            btnGrafikGetir.Name = "btnGrafikGetir";
            btnGrafikGetir.Size = new Size(125, 32);
            btnGrafikGetir.TabIndex = 4;
            btnGrafikGetir.Text = "Grafik Getir";
            btnGrafikGetir.UseVisualStyleBackColor = true;
            btnGrafikGetir.Click += btnGrafikGetir_Click;
            // 
            // KullaniciOgunGrafik
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MicrosoftTeams_image__13_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(957, 503);
            Controls.Add(btnGrafikGetir);
            Controls.Add(dtpGrafikTarih);
            Controls.Add(lblTarih);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "KullaniciOgunGrafik";
            Text = "KullaniciOgunGrafik";
            Load += KullaniciOgunGrafik_Load;
            ((System.ComponentModel.ISupportInitialize)chartPie).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
        private Panel panel1;
        private Label lblTarih;
        private DateTimePicker dtpGrafikTarih;
        private Button btnGrafikGetir;
    }
}
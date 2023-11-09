using FiftyShadesOfErrorList_DATA.Entity;
using FiftyShadesOfErrorList_DATA.Enum;
using FiftyShadesOfErrorList_SERVICE.AlinanBesinService;
using FiftyShadesOfErrorList_SERVICE.KullaniciGecmisDetayService;
using FiftyShadesOfErrorList_SERVICE.KullaniciService;
using FiftyShadesOfErrorList_UI.Metotlar;
using System;
using System.Security.Policy;
using System.Windows.Forms.DataVisualization.Charting;

namespace FiftyShadesOfErrorList_UI
{
    public partial class KullaniciOgunGrafik : Form
    {
        string hatirlanacakMail;
        string hatirlanacakSifre;
        KullaniciSERVICE kullaniciSERVICE;
        Kullanici seciliKullanici;
        AlinanBesinService alinanBesinService;
        List<AlinanBesin> alinanBesinler;

        public KullaniciOgunGrafik()
        {
            InitializeComponent();
        }

        private void KullaniciOgunGrafik_Load(object sender, EventArgs e)
        {
            PieGrafikDoldur(DateTime.Today);

        }

        private void btnGrafikGetir_Click(object sender, EventArgs e)
        {
            PieGrafikDoldur(dtpGrafikTarih.Value);

        }

        private void PieGrafikDoldur(DateTime tarih)
        {
            hatirlanacakMail = Properties.Settings.Default.Email;
            hatirlanacakSifre = Properties.Settings.Default.Sifre;
            kullaniciSERVICE = new KullaniciSERVICE();
            seciliKullanici = new Kullanici();
            seciliKullanici = kullaniciSERVICE.EmaileGoreGetir(hatirlanacakMail, hatirlanacakSifre);
            alinanBesinService = new AlinanBesinService();
            alinanBesinler = new List<AlinanBesin>();
            alinanBesinler.AddRange(alinanBesinService.TumunuGetir().Where(x => x.KullaniciId == seciliKullanici.Id && x.KayitTarihi.ToShortDateString() == tarih.ToShortDateString()).ToList());

            List<string> ogunler = new List<string>();
            foreach (string item in Enum.GetNames(typeof(Ogun)))
            {
                ogunler.Add(item);
            }

            chartPie.Series.Clear();
            chartPie.ChartAreas.Clear();
            //Pasta grafiği oluştur ve verileri ekle
            ChartArea pieChartArea = new ChartArea("PieChartArea");
            chartPie.ChartAreas.Add(pieChartArea);
            chartPie.Size = new Size(700, 500);

            Series pieSeries = new Series
            {
                Name = "PieSeries",
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Pie,
                ChartArea = "PieChartArea"
            };


            for (int i = 0; i < ogunler.Count; i++)
            {
                Ogun deger = (Ogun)Enum.Parse(typeof(Ogun), ogunler[i]);
                var kaloriToplam = alinanBesinler.Where(x => x.Ogun == deger).ToList().Sum(y => y.AlinanKalori);
                if (kaloriToplam > 0)
                {
                    DataPoint dataPoint = new DataPoint(i, kaloriToplam);
                    dataPoint.Label = deger + "\n" + kaloriToplam + " Kalori";

                    pieSeries.Points.Add(dataPoint);
                }
            }

            chartPie.Series.Add(pieSeries);
            chartPie.Palette = ChartColorPalette.Pastel;
            chartPie.Dock = DockStyle.None;
            chartPie.Location = new System.Drawing.Point(-50, -20);
            chartPie.Legends.Clear();
        }


    }
}

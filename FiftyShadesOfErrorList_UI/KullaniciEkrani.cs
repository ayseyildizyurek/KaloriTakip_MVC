using FiftyShadesOfErrorList_SERVICE.KullaniciService;
using FiftyShadesOfErrorList_UI.Metotlar;
using FiftyShadesOfErrorList_UI.UserControls;

namespace FiftyShadesOfErrorList_UI
{
    public partial class KullaniciEkrani : Form
    {
        public KullaniciEkrani()
        {
            InitializeComponent();
            KullaniciSERVICE kullaniciService = new KullaniciSERVICE();
            string hatirlanacakMail = Properties.Settings.Default.Email;
            string hatirlanacakSifre = Properties.Settings.Default.Sifre;
            var kullanici = kullaniciService.EmaileGoreGetir(hatirlanacakMail, hatirlanacakSifre);
            lblHosgeldin.Text = $"Hoşgeldiniz \n{kullanici.AdSoyad}";
        }

        private void btnKisiselBilgiler_Click(object sender, EventArgs e)
        {
            frmKisiselBilgiIslemleri frmKisiselBilgiIslemleri1 = new frmKisiselBilgiIslemleri();
            frmKisiselBilgiIslemleri1.Dock = DockStyle.Fill;
            panel1.Controls.Add(frmKisiselBilgiIslemleri1);
            Fonksiyonlar.UserControlGoster(panel1, frmKisiselBilgiIslemleri1);
        }

        private void btnIdealKiloHesapla_Click(object sender, EventArgs e)
        {
            frmIdealKiloHesapla frmIdealKiloHesapla1 = new frmIdealKiloHesapla();
            frmIdealKiloHesapla1.Dock = DockStyle.Fill;
            panel1.Controls.Add(frmIdealKiloHesapla1);
            Fonksiyonlar.UserControlGoster(panel1, frmIdealKiloHesapla1);
        }

        private void btnOgunEkle_Click(object sender, EventArgs e)
        {
            frmOgunEkle frmOgunEkle1 = new frmOgunEkle();
            frmOgunEkle1.Dock = DockStyle.Fill;
            panel1.Controls.Add(frmOgunEkle1);
            Fonksiyonlar.UserControlGoster(panel1, frmOgunEkle1);
        }

        private void btnSuTakibi_Click(object sender, EventArgs e)
        {
            frmSuTakibi frmSuTakibi1 = new frmSuTakibi();
            frmSuTakibi1.Dock = DockStyle.Fill;
            panel1.Controls.Add(frmSuTakibi1);
            Fonksiyonlar.UserControlGoster(panel1, frmSuTakibi1);
        }

        private void btnBeslenmeGecmisi_Click(object sender, EventArgs e)
        {
            frmBeslenmeGecmisi frmBeslenmeGecmisi1 = new frmBeslenmeGecmisi();
            frmBeslenmeGecmisi1.Dock = DockStyle.Fill;
            panel1.Controls.Add(frmBeslenmeGecmisi1);
            Fonksiyonlar.UserControlGoster(panel1, frmBeslenmeGecmisi1);
        }

        private void btnIstekSikayet_Click(object sender, EventArgs e)
        {
            frmIstekSikayet frmIstekSikayet1 = new frmIstekSikayet();
            frmIstekSikayet1.Dock = DockStyle.Fill;
            panel1.Controls.Add(frmIstekSikayet1);
            Fonksiyonlar.UserControlGoster(panel1, frmIstekSikayet1);
        }
    }
}

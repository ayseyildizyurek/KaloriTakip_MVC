using FiftyShadesOfErrorList_DATA.Entity;
using FiftyShadesOfErrorList_SERVICE.KullaniciGecmisDetayService;
using FiftyShadesOfErrorList_SERVICE.KullaniciService;
using FiftyShadesOfErrorList_UI.Metotlar;

namespace FiftyShadesOfErrorList_UI.UserControls
{
    public partial class frmSuTakibi : UserControl
    {
        KullaniciSERVICE kullaniciSERVICE=new KullaniciSERVICE();
        KullaniciGecmisDetaySERVICE KullaniciGecmisDetayService= new KullaniciGecmisDetaySERVICE();
        int alinmasiGerekenSu;
        Kullanici seciliKullanici=Fonksiyonlar.KullaniciBilgisiGetir();

        public frmSuTakibi()
        {
            InitializeComponent();
        }

        private void frmSuTakibi_Load(object sender, EventArgs e)
        {
            try
            {
                var kullanici = KullaniciGecmisDetayService.KullaniciIdyeGoreGetir(seciliKullanici.Id);

                if (kullanici != null)
                {
                    float boy = kullanici.Boy;
                    float kilo = kullanici.Kilo;
                    alinmasiGerekenSu = Convert.ToInt32(kilo * 0.033 * 1000);

                    lblGunlukSuMiktari.Text = $"Günlük minumum almanız gereken su miktarı {kilo * 0.033:F2} litredir";
                }

                BarGrafikDoldur();
            }
            catch (Exception)
            {
                MessageBox.Show("Günlük almanız gereken su miktarı hesaplanamadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime gTarih = seciliKullanici.GuncellemeTarihi.HasValue ? seciliKullanici.GuncellemeTarihi.Value : DateTime.Now;

                if (gTarih.ToShortDateString() == DateTime.Now.ToShortDateString())
                {
                    seciliKullanici.GunlukAlinanSuMiktari = (int)nudSuMiktari.Value * 200 + seciliKullanici.GunlukAlinanSuMiktari;
                }
                else
                {
                    seciliKullanici.GunlukAlinanSuMiktari = (int)nudSuMiktari.Value * 200;
                }
                kullaniciSERVICE.Guncelle(seciliKullanici);

                MessageBox.Show("Tüketilen Su eklendi");

                BarGrafikDoldur();
            }
            catch (Exception)
            {
                MessageBox.Show("Tüketilen su miktarı eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BarGrafikDoldur()
        {
            pbOlmasiGereken.Minimum = 0;
            pbOlmasiGereken.Maximum = alinmasiGerekenSu;
            pbOlmasiGereken.Value = alinmasiGerekenSu;
            lblOlmasiGereken.Text = $"{alinmasiGerekenSu} ({(double)alinmasiGerekenSu / 1000} lt) ml Su";
            pbOlmasiGereken.Invalidate();

            if (seciliKullanici.GunlukAlinanSuMiktari>alinmasiGerekenSu)
            {
                pbSizinIctiginiz.Minimum = 0;
                pbSizinIctiginiz.Maximum = seciliKullanici.GunlukAlinanSuMiktari;
                pbSizinIctiginiz.Value = seciliKullanici.GunlukAlinanSuMiktari;
                lblIcilen.Text = $"{seciliKullanici.GunlukAlinanSuMiktari} ({(double)seciliKullanici.GunlukAlinanSuMiktari / 1000} lt) ml Su";
                pbSizinIctiginiz.Invalidate();
            }
            else
            {
                pbSizinIctiginiz.Minimum = 0;
                pbSizinIctiginiz.Maximum = alinmasiGerekenSu;
                pbSizinIctiginiz.Value = seciliKullanici.GunlukAlinanSuMiktari;
                lblIcilen.Text = $"{seciliKullanici.GunlukAlinanSuMiktari} ({(double)seciliKullanici.GunlukAlinanSuMiktari / 1000} lt) ml Su";
                pbSizinIctiginiz.Invalidate();
            }
        }
    }
}


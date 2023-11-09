using FiftyShadesOfErrorList_DATA.Entity;
using FiftyShadesOfErrorList_DATA.Enum;
using FiftyShadesOfErrorList_SERVICE.KullaniciGecmisDetayService;
using FiftyShadesOfErrorList_SERVICE.KullaniciService;
using FiftyShadesOfErrorList_UI.Metotlar;

namespace FiftyShadesOfErrorList_UI.UserControls
{
    public partial class frmKisiselBilgiIslemleri : UserControl
    {
        KullaniciSERVICE kullaniciService;
        KullaniciGecmisDetaySERVICE kullaniciGecmisDetayService;
        Kullanici girisYapanKullanici = Fonksiyonlar.KullaniciBilgisiGetir();
        KullaniciGecmisDetay kullaniciGecmis;
        public frmKisiselBilgiIslemleri()
        {
            InitializeComponent();
        }

        private void frmKisiselBilgiIslemleri_Load(object sender, EventArgs e)
        {
            BilgileriDoldur();
        }

        private void BilgileriDoldur()
        {
            Fonksiyonlar.ComboBoxDoldur<VucutTipi>(cmbVucutTipi);
            Fonksiyonlar.ComboBoxDoldur<Egzersiz>(cmbEgzersiz);
            Fonksiyonlar.ComboBoxDoldur<Cinsiyet>(cmbCinsiyet);

            kullaniciService = new KullaniciSERVICE();
            kullaniciGecmisDetayService = new KullaniciGecmisDetaySERVICE();

            kullaniciGecmis = kullaniciGecmisDetayService.KullaniciIdyeGoreGetir(girisYapanKullanici.Id);

            txtAd.Text = girisYapanKullanici.Ad;
            txtSoyad.Text = girisYapanKullanici.Soyad;
            txtEposta.Text = girisYapanKullanici.Email;
            txtSifre.Text = girisYapanKullanici.Sifre;
            cmbEgzersiz.SelectedValue = girisYapanKullanici.Egzersiz;
            cmbVucutTipi.SelectedValue = girisYapanKullanici.VucutTipi;
            cmbCinsiyet.SelectedValue = girisYapanKullanici.Cinsiyet;
            txtBoy.Text = kullaniciGecmis.Boy.ToString();
            txtKilo.Text = kullaniciGecmis.Kilo.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                girisYapanKullanici.Ad = txtAd.Text;
                girisYapanKullanici.Soyad = txtSoyad.Text;

                girisYapanKullanici.VucutTipi = (VucutTipi)cmbVucutTipi.SelectedValue;
                girisYapanKullanici.Egzersiz = (Egzersiz)cmbEgzersiz.SelectedValue;

                girisYapanKullanici.Email = txtEposta.Text;
                girisYapanKullanici.Sifre = txtSifre.Text;
                girisYapanKullanici.Cinsiyet = (Cinsiyet)cmbCinsiyet.SelectedValue;

                kullaniciService.Guncelle(girisYapanKullanici);

                KullaniciGecmisDetay kullaniciGecmisDetay = new KullaniciGecmisDetay()
                {
                    Boy = Convert.ToSingle(txtBoy.Text),
                    Kilo = Convert.ToSingle(txtKilo.Text),
                    KullaniciId = girisYapanKullanici.Id
                };

                kullaniciGecmisDetayService.Ekle(kullaniciGecmisDetay);

                MessageBox.Show("Kullanıcı Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BilgileriDoldur();
            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnHesabiSil_Click(object sender, EventArgs e)
        {
            try
            {
                kullaniciService.Sil(girisYapanKullanici);
                MessageBox.Show("Hesap Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            catch (Exception)
            {
                MessageBox.Show("Hesap Silme Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

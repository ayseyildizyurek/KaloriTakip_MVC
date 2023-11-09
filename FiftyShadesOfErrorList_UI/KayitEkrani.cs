using FiftyShadesOfErrorList_DATA.Entity;
using FiftyShadesOfErrorList_DATA.Enum;
using FiftyShadesOfErrorList_SERVICE.KullaniciGecmisDetayService;
using FiftyShadesOfErrorList_SERVICE.KullaniciService;
using FiftyShadesOfErrorList_UI.Metotlar;

namespace FiftyShadesOfErrorList_UI
{
    public partial class KayitEkrani : Form
    {
        Kullanici yeniKullanici;
        KullaniciSERVICE service;
        int aktivasyonKodu;
        int girilenAktivasyonKodu;
        public KayitEkrani()
        {
            InitializeComponent();
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Fonksiyonlar.GirdiKontrol(this.Controls))
                {
                    string mail = txtEposta.Text.Trim();
                    string sifre = txtSifre.Text.Trim();
                    service = new KullaniciSERVICE();

                    var tumKullanicilar = service.TumunuGetir();

                    if (Fonksiyonlar.MailGecerliMi(mail) && Fonksiyonlar.SifreKontrol(sifre))
                    {
                        if (tumKullanicilar.Any(x => x.Email == mail))
                        {
                            MessageBox.Show("Bu maile ait kullanıcı zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            yeniKullanici = new Kullanici()
                            {
                                Ad = txtAd.Text.Trim(),
                                Soyad = txtSoyad.Text.Trim(),
                                Email = mail,
                                Sifre = sifre,
                                Cinsiyet = (Cinsiyet)cmbCinsiyet.SelectedValue,
                                DogumTarihi = dtpDogumTarihi.Value,
                                VucutTipi = (VucutTipi)cmbVucutTipi.SelectedValue,
                                Egzersiz = (Egzersiz)cmbEgzersiz.SelectedValue,
                                Status = Status.Aktif,
                                GunlukAlinanKalori = 0,
                                GunlukAlinanSuMiktari = 0
                            };

                            lblAktivasyonKodu.Visible = true;
                            btnKodOnayla.Visible = true;
                            txtAktivasyonKodu.Visible = true;

                            aktivasyonKodu = Fonksiyonlar.MailGonder(mail);
                            lblSifreUyari.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz Mail veya Şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Fonksiyonlar.Temizle(Controls);
                        lblSifreUyari.Visible = true;
                        lblSifreUyari.Text = "Şifre en az 8 en fazla 16 karakter olmalıdır.Şifre en az 1 büyük harf,\n1 küçük harf, 1 özel karakter ve 1 rakam içermelidir. ";
                    }
                }
                else
                {
                    MessageBox.Show("İlgili Alanlar Boş Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Fonksiyonlar.Temizle(Controls);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void KayitEkrani_Load(object sender, EventArgs e)
        {
            lblAktivasyonKodu.Visible = false;
            btnKodOnayla.Visible = false;
            txtAktivasyonKodu.Visible = false;
            Fonksiyonlar.ComboBoxDoldur<Cinsiyet>(cmbCinsiyet);
            Fonksiyonlar.ComboBoxDoldur<VucutTipi>(cmbVucutTipi);
            Fonksiyonlar.ComboBoxDoldur<Egzersiz>(cmbEgzersiz);
            lblSifreUyari.Visible = false;
        }

        private void btnKodOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                girilenAktivasyonKodu = Convert.ToInt32(txtAktivasyonKodu.Text.Trim());
                if (girilenAktivasyonKodu == aktivasyonKodu && aktivasyonKodu != 0)
                {
                    service.Ekle(yeniKullanici);
                    KullaniciGecmisDetay kullaniciGecmisDetay = new KullaniciGecmisDetay()
                    {
                        KullaniciId = yeniKullanici.Id,
                        Kilo = Convert.ToSingle(txtKilo.Text.Trim()),
                        Boy = Convert.ToSingle(txtBoy.Text.Trim()),
                    };

                    KullaniciGecmisDetaySERVICE kullaniciGecmisDetayService = new KullaniciGecmisDetaySERVICE();

                    kullaniciGecmisDetayService.Ekle(kullaniciGecmisDetay);
                    GirisEkrani girisEkrani = new GirisEkrani();
                    girisEkrani.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş, Tekrar Deneyiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Fonksiyonlar.Temizle(this.Controls);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata ile Karşılaşıldı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

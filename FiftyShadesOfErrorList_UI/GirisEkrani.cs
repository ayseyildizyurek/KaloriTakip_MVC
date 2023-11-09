using FiftyShadesOfErrorList_DATA.Enum;
using FiftyShadesOfErrorList_SERVICE.AdminService;
using FiftyShadesOfErrorList_SERVICE.KullaniciService;
using FiftyShadesOfErrorList_UI.Metotlar;

namespace FiftyShadesOfErrorList_UI
{

    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string email = txtEposta.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            Properties.Settings.Default.Email = string.Empty;
            Properties.Settings.Default.Sifre = string.Empty;

            if (Fonksiyonlar.GirdiKontrol(Controls))
            {
                MessageBox.Show("Email veya Þifre Boþ Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Fonksiyonlar.Temizle(Controls);
            }
            else
            {
                IAdminSERVICE adminSERVICE = new AdminSERVICE();
                IKullaniciSERVICE kullaniciSERVICE = new KullaniciSERVICE();
                var kullanici = kullaniciSERVICE.EmaileGoreGetir(email, sifre);

                if (adminSERVICE.EmaileGoreGetir(email, sifre) != null)
                {
                    Properties.Settings.Default.Email = email;
                    Properties.Settings.Default.Sifre = sifre;
                    AdminEkrani adminEkrani = new AdminEkrani();
                    adminEkrani.Show();
                    this.Hide();
                }
                else if (kullaniciSERVICE.EmaileGoreGetir(email, sifre) != null && kullanici.Status == Status.Aktif)
                {
                    Properties.Settings.Default.Email = email;
                    Properties.Settings.Default.Sifre = sifre;

                    KullaniciEkrani kullaniciEkrani = new KullaniciEkrani();
                    kullaniciEkrani.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Email veya Þifre Hatalý", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Fonksiyonlar.Temizle(Controls);
                }
            }
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            KayitEkrani kayitEkrani = new KayitEkrani();
            kayitEkrani.Show();
            this.Hide();
        }
    }
}
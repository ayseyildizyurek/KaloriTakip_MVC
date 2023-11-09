using FiftyShadesOfErrorList_DATA;
using FiftyShadesOfErrorList_SERVICE.AdminService;
using FiftyShadesOfErrorList_SERVICE.IstekSikayetService;
using FiftyShadesOfErrorList_UI.Metotlar;

namespace FiftyShadesOfErrorList_UI.UserControls
{
    public partial class frmIstekSikayet : UserControl
    {
        IstekSikayetSERVICE istekSikayetSERVICE;
        IstekSikayet istekSikayet;
        public frmIstekSikayet()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            try
            {
                AdminSERVICE adminService = new AdminSERVICE();
                var adminler = adminService.TumunuGetir();

                if (string.IsNullOrEmpty(txtBaslik.Text) || string.IsNullOrEmpty(txtAciklama.Text))
                {
                    MessageBox.Show("Boş Alan Bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Fonksiyonlar.Temizle(Controls);
                }
                else
                {
                    istekSikayetSERVICE = new IstekSikayetSERVICE();

                    istekSikayet = new IstekSikayet()
                    {
                        Baslik = txtBaslik.Text,
                        Aciklama = txtAciklama.Text,
                        OkunduMu = false,
                        KullaniciId = Fonksiyonlar.KullaniciBilgisiGetir().Id,
                        AdminId = adminler[0].Id
                    };
                    istekSikayetSERVICE.Ekle(istekSikayet);
                    MessageBox.Show("Talebiniz Alınmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Fonksiyonlar.Temizle(Controls);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Fonksiyonlar.Temizle(Controls);
            }

        }
    }
}

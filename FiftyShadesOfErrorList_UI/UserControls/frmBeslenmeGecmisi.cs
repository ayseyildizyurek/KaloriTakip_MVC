using FiftyShadesOfErrorList_DATA.Entity;
using FiftyShadesOfErrorList_DATA.Enum;
using FiftyShadesOfErrorList_SERVICE.AlinanBesinService;
using FiftyShadesOfErrorList_SERVICE.KategoriService;
using FiftyShadesOfErrorList_SERVICE.KullaniciService;
using FiftyShadesOfErrorList_UI.Metotlar;

namespace FiftyShadesOfErrorList_UI.UserControls
{
    public partial class frmBeslenmeGecmisi : UserControl
    {
        AlinanBesinService alinanBesinService = new AlinanBesinService();
        public frmBeslenmeGecmisi()
        {
            InitializeComponent();
        }

        private void btnTumunuGoster_Click(object sender, EventArgs e)
        {
            DGVFill(null);
        }

        private void DGVFill(Ogun? ogun)
        {
            var alinanbesinlistesi = alinanBesinService.TumunuGetir();

            if (ogun != null)
            {
                var sonuc = alinanbesinlistesi.Where(x => x.KullaniciId == Fonksiyonlar.KullaniciBilgisiGetir().Id && x.Ogun == ogun).ToList().Select(x => new
                {
                    BesinAdi = x.Besin.Ad,
                    AlinanMiktar = x.AlinanMiktar,
                    Birim = x.Birim,
                    AlinanKalori = x.AlinanKalori,
                    Ogun = x.Ogun,
                    KayitTarihi = x.KayitTarihi,
                    GuncellemeTarihi = x.GuncellemeTarihi
                }).ToList();

                dgvBeslenmeGecmisi.DataSource = sonuc;

                double toplamKalori = 0;
                foreach (var item in sonuc)
                {
                    toplamKalori += item.AlinanKalori;
                }
                lblToplamKalori.Text = toplamKalori.ToString() + " KCal";

                dgvBeslenmeGecmisi.ClearSelection();
            }
            else
            {
                var sonuc = alinanbesinlistesi.Where(x => x.KullaniciId == Fonksiyonlar.KullaniciBilgisiGetir().Id).ToList().Select(x => new
                {
                    BesinAdi = x.Besin.Ad,
                    AlinanMiktar = x.AlinanMiktar,
                    Birim = x.Birim,
                    AlinanKalori = x.AlinanKalori,
                    Ogun = x.Ogun,
                    KayitTarihi = x.KayitTarihi,
                    GuncellemeTarihi = x.GuncellemeTarihi
                }).ToList();

                dgvBeslenmeGecmisi.DataSource = sonuc;

                double toplamKalori = 0;
                foreach (var item in sonuc)
                {
                    toplamKalori += item.AlinanKalori;
                }
                lblToplamKalori.Text = toplamKalori.ToString() + " KCal";

                dgvBeslenmeGecmisi.ClearSelection();
            }
        }

        private void frmBeslenmeGecmisi_Load(object sender, EventArgs e)
        {
            Fonksiyonlar.ComboBoxDoldur<Ogun>(cmbOgunBazli);
            cmbOgunBazli.SelectedIndex = -1;

            KategorSERVICE kategoriService = new KategorSERVICE();
            var kategoriler = kategoriService.TumunuGetir();
            cmbKategoriSec.DataSource = kategoriler;
            cmbKategoriSec.DisplayMember = "Ad";
            cmbKategoriSec.ValueMember = "Id";
            cmbKategoriSec.SelectedIndex = -1;
        }

        private void btnTariheGoreFiltrele_Click(object sender, EventArgs e)
        {
            DateTime baslangicTarihi = new DateTime(dtpBaslangicTarihi.Value.Year, dtpBaslangicTarihi.Value.Month, dtpBaslangicTarihi.Value.Day, 0, 0, 0);
            DateTime bitisTarihi = new DateTime(dtpBitisTarihi.Value.Year, dtpBitisTarihi.Value.Month, dtpBitisTarihi.Value.Day, 23, 59, 59);

           

            var alinanbesinlistesi = alinanBesinService.TumunuGetir();

            var sonuc = alinanbesinlistesi.Where(x => x.KullaniciId == Fonksiyonlar.KullaniciBilgisiGetir().Id && x.KayitTarihi >= baslangicTarihi && x.KayitTarihi <= bitisTarihi).ToList().Select(x => new
            {
                BesinAdi = x.Besin.Ad,
                AlinanMiktar = x.AlinanMiktar,
                Birim = x.Birim,
                AlinanKalori = x.AlinanKalori,
                Ogun = x.Ogun,
                KayitTarihi = x.KayitTarihi,
                GuncellemeTarihi = x.GuncellemeTarihi
            }).ToList();

            dgvBeslenmeGecmisi.DataSource = sonuc;

            double toplamKalori = 0;
            foreach (var item in sonuc)
            {
                toplamKalori += item.AlinanKalori;
            }
            lblToplamKalori.Text = toplamKalori.ToString() + " KCal";

            dgvBeslenmeGecmisi.ClearSelection();
        }

        private void btnOguneGoreFiltrele_Click(object sender, EventArgs e)
        {
            int secilenOgun = cmbOgunBazli.SelectedIndex;

            switch (secilenOgun)
            {
                case -1: DGVFill(null); break;
                case 0: DGVFill(Ogun.Sabah); break;
                case 1: DGVFill(Ogun.Ogle); break;
                case 2: DGVFill(Ogun.Aksam); break;
                case 3: DGVFill(Ogun.Araogun); break;
            }
        }

        private void btnKategoriyeGoreFiltrele_Click(object sender, EventArgs e)
        {
            try
            {
                var alinanbesinlistesi = alinanBesinService.TumunuGetir();
                int seciliKategori = (int)cmbKategoriSec.SelectedValue;

                var sonuc = alinanbesinlistesi
                    .Where(x => x.KullaniciId == Fonksiyonlar.KullaniciBilgisiGetir().Id && x.Besin.KategoriId == x.Besin.Kategori.Id && x.Besin.KategoriId == seciliKategori).ToList().Select(x => new
                    {
                        BesinAdi = x.Besin.Ad,
                        KategoriAdi = x.Besin.Kategori.Ad,
                        AlinanMiktar = x.AlinanMiktar,
                        Birim = x.Birim,
                        AlinanKalori = x.AlinanKalori,
                        Ogun = x.Ogun,
                        KayitTarihi = x.KayitTarihi,
                        GuncellemeTarihi = x.GuncellemeTarihi
                    }).ToList();

                dgvBeslenmeGecmisi.DataSource = sonuc;

                double toplamKalori = 0;
                foreach (var item in sonuc)
                {
                    toplamKalori += item.AlinanKalori;
                }
                lblToplamKalori.Text = toplamKalori.ToString() + " KCal";

                dgvBeslenmeGecmisi.ClearSelection();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Kategori Seçimi Yapın", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFavoriBesinler_Click(object sender, EventArgs e)
        {
            alinanBesinService = new AlinanBesinService();

            var alinanBesinListesi = alinanBesinService.TumunuGetir();

            var favoriBesinler = alinanBesinListesi.GroupBy(x => x.BesinId).Select(x => new
            {
                BesinId = x.Key,
                BesinAdi = alinanBesinListesi.First(z => z.BesinId == x.Key).Besin.Ad,
                KategoriAdi = alinanBesinListesi.First(y => y.BesinId == x.Key).Besin.Kategori.Ad,
                TuketilmeSikligi = x.Count(),
                ToplamTuketimMiktari = x.Sum(x => x.AlinanMiktar),
                AlinanKalori = x.Sum(x => x.AlinanKalori)
            }).OrderByDescending(x => x.TuketilmeSikligi).ToList();

            dgvBeslenmeGecmisi.DataSource = favoriBesinler;
            dgvBeslenmeGecmisi.Columns[0].Visible = false;

            double toplamKalori = 0;
            foreach (var item in favoriBesinler)
            {
                toplamKalori += item.AlinanKalori;
            }
            lblToplamKalori.Text = toplamKalori.ToString() + " KCal";

            dgvBeslenmeGecmisi.ClearSelection();
        }

        private void btnOgunGrafik_Click(object sender, EventArgs e)
        {
            KullaniciOgunGrafik kullaniciOgunGrafik = new KullaniciOgunGrafik();
            kullaniciOgunGrafik.ShowDialog();
        }
    }
}

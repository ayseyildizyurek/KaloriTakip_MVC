using FiftyShadesOfErrorList_DATA.Entity;
using FiftyShadesOfErrorList_SERVICE.KategoriService;
using FiftyShadesOfErrorList_UI.Metotlar;

namespace FiftyShadesOfErrorList_UI.UserControls
{
    public partial class frmKategoriIslemleri : UserControl
    {
        KategorSERVICE kategoriService;
        Kategori secilenKategori;
        public frmKategoriIslemleri()
        {
            InitializeComponent();
        }

        private void DGVFill()
        {
            kategoriService = new KategorSERVICE();
            var tumKategoriler = kategoriService.TumunuGetir().Select(x => new
            {
                Id = x.Id,
                Ad = x.Ad,
                KayitTarihi = x.KayitTarihi,
                GuncellemeTarihi = x.GuncellemeTarihi,
                SilmeTarihi = x.SilmeTarihi
            }).ToList();

            dgvKategori.DataSource = tumKategoriler;
            dgvKategori.ClearSelection();
        }

        private void frmKategoriIslemleri_Load(object sender, EventArgs e)
        {
            DGVFill();
        }

        private void btnTumunuListele_Click(object sender, EventArgs e)
        {
            DGVFill();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori kategori = new Kategori() { Ad = txtAd.Text };

                kategoriService.Ekle(kategori);
                MessageBox.Show("Kategori Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVFill();
                Fonksiyonlar.Temizle(this.Controls);
            }
            catch (Exception)
            {
                MessageBox.Show("Kategori Ekleme Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Fonksiyonlar.Temizle(this.Controls);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                secilenKategori.Ad = txtAd.Text;

                kategoriService.Guncelle(secilenKategori);

                MessageBox.Show("Kategori Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVFill();
                Fonksiyonlar.Temizle(this.Controls);
            }
            catch (Exception)
            {
                MessageBox.Show("Kategori Güncelleme Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Fonksiyonlar.Temizle(this.Controls);
            }
        }

        private void dgvKategori_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvKategori.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvKategori.SelectedRows[0];

                int id = (int)selectedRow.Cells[0].Value;
                secilenKategori = kategoriService.IdyeGoreGetir(id);
                txtAd.Text = secilenKategori.Ad.ToString();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                kategoriService.Sil(secilenKategori);
                MessageBox.Show("Kategori Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVFill();
                Fonksiyonlar.Temizle(this.Controls);
            }
            catch (Exception)
            {
                MessageBox.Show("Kategori Silme Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Fonksiyonlar.Temizle(this.Controls);
            }
        }
    }
}

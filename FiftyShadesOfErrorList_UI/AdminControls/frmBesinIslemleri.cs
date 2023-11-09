using FiftyShadesOfErrorList_DATA.Entity;
using FiftyShadesOfErrorList_SERVICE.BesinService;
using FiftyShadesOfErrorList_SERVICE.KategoriService;
using FiftyShadesOfErrorList_UI.Metotlar;

namespace FiftyShadesOfErrorList_UI.UserControls
{
    public partial class frmBesinIslemleri : UserControl
    {
        Besin secilenBesin = new Besin();
        BesinSERVICE besinService = new BesinSERVICE();
        string resimYolu;
        public frmBesinIslemleri()
        {
            InitializeComponent();
        }

        private void frmBesinIslemleri_Load(object sender, EventArgs e)
        {
            KategorSERVICE kategoriService = new KategorSERVICE();
            var kategoriler = kategoriService.TumunuGetir();
            cmbKategori.DataSource = kategoriler;
            cmbKategori.DisplayMember = "Ad";
            cmbKategori.ValueMember = "Id";
            cmbKategori.SelectedIndex = -1;
            DGVFill();
        }

        private void DGVFill()
        {
            var tumBesinler = besinService.TumunuGetir().Select(x => new
            {
                Id = x.Id,
                Ad = x.Ad,
                Miktar = x.Miktar,
                Birim = x.Birim,
                Kalori = x.Kalori,
                Porsiyon = x.Porsiyon,
                Karbonhidrat = x.Karbonhidrat,
                Protein = x.Protein,
                Yag = x.Yag,
                KategoriAdi = x.Kategori.Ad,
                KayitTarihi = x.KayitTarihi,
                GuncellemeTarihi = x.GuncellemeTarihi
            }).ToList();
            dgvBesin.DataSource = tumBesinler;

            dgvBesin.ClearSelection();
        }

        private void btnTumunuListele_Click(object sender, EventArgs e)
        {
            DGVFill();
        }

        private void dgvBesin_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvBesin.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvBesin.SelectedRows[0];
                int id = (int)selectedRow.Cells[0].Value;
                secilenBesin = besinService.IdyeGoreGetir(id);

                txtBesinAd.Text = secilenBesin.Ad.ToString();
                txtMiktar.Text = secilenBesin.Miktar.ToString();
                txtBirim.Text = secilenBesin.Birim.ToString();
                txtPorsiyon.Text = secilenBesin.Porsiyon.ToString();
                txtKarbonhidrat.Text = secilenBesin.Karbonhidrat.ToString();
                txtProtein.Text = secilenBesin.Protein.ToString();
                txtYag.Text = secilenBesin.Yag.ToString();
                txtKalori.Text = secilenBesin.Kalori.ToString();
                cmbKategori.SelectedValue = secilenBesin.KategoriId;
            }

            if (!string.IsNullOrEmpty(secilenBesin.ResimYolu))
            {
                pbBesinResim.Image = Image.FromFile(secilenBesin.ResimYolu);
            }
            else
            {
                pbBesinResim.Image = null;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                secilenBesin.Ad = txtBesinAd.Text;
                secilenBesin.Miktar = Convert.ToDouble(txtMiktar.Text);
                secilenBesin.Birim = txtBirim.Text;
                secilenBesin.Kalori = Convert.ToDouble(txtKalori.Text);
                secilenBesin.Porsiyon = txtPorsiyon.Text;
                secilenBesin.Karbonhidrat = Convert.ToDouble(txtKarbonhidrat.Text);
                secilenBesin.Protein = Convert.ToDouble(txtProtein.Text);
                secilenBesin.Yag = Convert.ToDouble(txtYag.Text);
                secilenBesin.KategoriId = (int)cmbKategori.SelectedValue;
                secilenBesin.ResimYolu = resimYolu;

                besinService.Guncelle(secilenBesin);
                MessageBox.Show("Besin Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVFill();
                Fonksiyonlar.Temizle(this.Controls);
            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                besinService.Sil(secilenBesin);
                MessageBox.Show("Besin Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVFill();
                Fonksiyonlar.Temizle(this.Controls);
            }
            catch (Exception)
            {
                MessageBox.Show("Silme İşlemi Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Besin besin = new Besin()
                {
                    Ad = txtBesinAd.Text,
                    Miktar = Convert.ToDouble(txtMiktar.Text),
                    Birim = txtBirim.Text,
                    Kalori = Convert.ToDouble(txtKalori.Text),
                    ResimYolu = resimYolu,
                    Porsiyon = txtPorsiyon.Text,
                    Karbonhidrat = Convert.ToDouble(txtKarbonhidrat.Text),
                    Protein = Convert.ToDouble(txtProtein.Text),
                    Yag = Convert.ToDouble(txtYag.Text),
                    KategoriId = (int)cmbKategori.SelectedValue
                };
                BesinSERVICE service = new BesinSERVICE();
                service.Ekle(besin);
                MessageBox.Show("Besin Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVFill();
                Fonksiyonlar.Temizle(this.Controls);
            }
            catch (Exception)
            {
                MessageBox.Show("Ekleme Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Resim Dosyaları (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Seçilen dosyanın yolunu al
                        resimYolu = openFileDialog.FileName;
                        // Resmi PictureBox'a yükle
                        pbBesinResim.Image = Image.FromFile(resimYolu);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Resim yükleme hatası: " + ex.Message);
                    }
                }
            }
        }

        private void txtBesinAra_TextChanged(object sender, EventArgs e)
        {
            DGVFill();
            string filter = txtBesinAra.Text.Trim().ToLower();

            //dgvBesin.DataSource = besinService.TumunuGetir().Where(x => x.Ad.ToLower().Contains(filter)).ToList(); 
            dgvBesin.DataSource = besinService.FiltreyeGoreGetir(filter);
        }
    }
}

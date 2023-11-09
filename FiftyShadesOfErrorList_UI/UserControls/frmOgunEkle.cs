using FiftyShadesOfErrorList_DATA.Entity;
using FiftyShadesOfErrorList_DATA.Enum;
using FiftyShadesOfErrorList_SERVICE.AlinanBesinService;
using FiftyShadesOfErrorList_SERVICE.BesinService;
using FiftyShadesOfErrorList_SERVICE.KategoriService;
using FiftyShadesOfErrorList_UI.Metotlar;
using System.Data;

namespace FiftyShadesOfErrorList_UI.UserControls
{
    public partial class frmOgunEkle : UserControl
    {
        KategorSERVICE kategoriService = new KategorSERVICE();
        Besin seciliBesin;
        BesinSERVICE besinService;
        AlinanBesinService alinanBesinService = new AlinanBesinService();
        AlinanBesin alinanBesin;
        Kullanici seciliKullanici = Fonksiyonlar.KullaniciBilgisiGetir();
        int SeciliId;
        public frmOgunEkle()
        {
            InitializeComponent();
        }

        private void frmOgunEkle_Load(object sender, EventArgs e)
        {
            Fonksiyonlar.ComboBoxDoldur<Ogun>(cmbogunSec);

            var kategoriler = kategoriService.TumunuGetir();
            cmbKategoriSec.DataSource = kategoriler;
            cmbKategoriSec.DisplayMember = "Ad";
            cmbKategoriSec.ValueMember = "Id";
            cmbKategoriSec.SelectedIndex = -1;
        }

        private void DGVVeriEkle(Ogun ogun, DataGridView dgv)
        {
            alinanBesinService = new AlinanBesinService();
            var sonucListe = alinanBesinService.KosulaGoreGetir(ogun, seciliKullanici.Id);

            if (sonucListe.Where(x => x.Ogun == ogun).Count() >= 0)
            {
                dgv.DataSource = sonucListe.Where(x => x.KayitTarihi.ToShortDateString() == DateTime.Now.ToShortDateString()).Select(x => new { x.Id, x.Besin.Ad, x.AlinanKalori, x.KayitTarihi }).ToList();
            }

            dgv.Columns[0].Visible = false;

            int kolonGenisligi = dgv.Width / 4;
            dgv.Columns[1].Width = kolonGenisligi * 2;
            dgv.Columns[2].Width = kolonGenisligi;
            dgv.Columns[3].Width = kolonGenisligi;

            dgv.ClearSelection();
        }

        private void cmbKategoriSec_TextChanged(object sender, EventArgs e)
        {
            if (cmbKategoriSec.SelectedValue != null && cmbKategoriSec.SelectedValue is int seciliKategori)
            {
                seciliKategori = (int)cmbKategoriSec.SelectedValue;
                besinService = new BesinSERVICE();

                List<Besin> besinListesi = besinService.KosulaGoreGetir(x => x.KategoriId == seciliKategori);

                cmbBesinSec.DataSource = besinListesi;
                cmbBesinSec.DisplayMember = "Ad";
                cmbBesinSec.ValueMember = "Id";
                cmbBesinSec.SelectedIndex = -1;
            }
        }

        private void cmbBesinSec_TextChanged(object sender, EventArgs e)
        {
            if (cmbBesinSec.SelectedValue != null && cmbBesinSec.SelectedValue is int besin)
            {
                besin = (int)cmbBesinSec.SelectedValue;
                besinService = new BesinSERVICE();
                seciliBesin = besinService.IdyeGoreGetir(besin);
                lblPorsiyonBilgileri.Text = $"{seciliBesin.Porsiyon} ({seciliBesin.Miktar} {seciliBesin.Birim})";
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            alinanBesin = new AlinanBesin()
            {
                BesinId = seciliBesin.Id,
                KullaniciId = seciliKullanici.Id,
                AlinanMiktar = Convert.ToDouble(nudMiktar.Value),
                Birim = seciliBesin.Birim,
                AlinanKalori = seciliBesin.Kalori * Convert.ToDouble(nudMiktar.Value),
                Ogun = (Ogun)cmbogunSec.SelectedValue
            };

            alinanBesinService.Ekle(alinanBesin);

            DGVVeriEkle(Ogun.Sabah, dgvKahvalti);
            DGVVeriEkle(Ogun.Ogle, dgvOgle);
            DGVVeriEkle(Ogun.Aksam, dgvAksam);
            DGVVeriEkle(Ogun.Araogun, dgvAraOgun);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            DGVVeriEkle(Ogun.Sabah, dgvKahvalti);
            DGVVeriEkle(Ogun.Ogle, dgvOgle);
            DGVVeriEkle(Ogun.Aksam, dgvAksam);
            DGVVeriEkle(Ogun.Araogun, dgvAraOgun);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                var silinecekBesin = alinanBesinService.IdyeGoreGetir(SeciliId);
                alinanBesinService.Sil(silinecekBesin);
                MessageBox.Show("Besin Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVVeriEkle(Ogun.Sabah, dgvKahvalti);
                DGVVeriEkle(Ogun.Ogle, dgvOgle);
                DGVVeriEkle(Ogun.Aksam, dgvAksam);
                DGVVeriEkle(Ogun.Araogun, dgvAraOgun);
            }
            catch (Exception)
            {
                MessageBox.Show("Silme Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvKahvalti_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvKahvalti.RowCount > 0)
            {
                SeciliId = (int)dgvKahvalti.CurrentRow.Cells[0].Value;
            }
        }

        private void dgvOgle_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvOgle.RowCount > 0)
            {
                SeciliId = (int)dgvOgle.CurrentRow.Cells[0].Value;
            }
        }

        private void dgvAksam_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvAksam.RowCount > 0)
            {
                SeciliId = (int)dgvAksam.CurrentRow.Cells[0].Value;
            }
        }

        private void dgvAraOgun_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvAraOgun.RowCount > 0)
            {
                SeciliId = (int)dgvAraOgun.CurrentRow.Cells[0].Value;
            }
        }
    }
}

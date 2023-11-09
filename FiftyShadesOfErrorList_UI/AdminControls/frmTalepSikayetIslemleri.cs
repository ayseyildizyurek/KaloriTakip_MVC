using FiftyShadesOfErrorList_DATA;
using FiftyShadesOfErrorList_SERVICE.IstekSikayetService;
using FiftyShadesOfErrorList_UI.Metotlar;

namespace FiftyShadesOfErrorList_UI.UserControls
{
    public partial class frmTalepSikayetIslemleri : UserControl
    {
        IstekSikayetSERVICE istekSikayetService=new IstekSikayetSERVICE();
        IstekSikayet secilenIstekSikayet;
        public frmTalepSikayetIslemleri()
        {
            InitializeComponent();
        }

        private void frmTalepSikayetIslemleri_Load(object sender, EventArgs e)
        {
        }

        private void DGVFill()
        {
            var tumIstekSikayetler = istekSikayetService.TumunuGetir();

            dgvIstekSikayet.AutoGenerateColumns = false;

            dgvIstekSikayet.Columns.AddRange(
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Baslik", HeaderText = "Başlık" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Aciklama", HeaderText = "Açıklama" },
                new DataGridViewTextBoxColumn { DataPropertyName = "OkunduMu", HeaderText = "Okundu Mu" },
                new DataGridViewTextBoxColumn { DataPropertyName = "AdminId", HeaderText = "AdminID" },
                new DataGridViewTextBoxColumn { DataPropertyName = "KullaniciId", HeaderText = "KullanıcıID" },
                new DataGridViewTextBoxColumn { DataPropertyName = "KayitTarihi", HeaderText = "Kayıt Tarihi" },
                new DataGridViewTextBoxColumn { DataPropertyName = "GuncellemeTarihi", HeaderText = "Güncelleme Tarihi" },
                new DataGridViewTextBoxColumn { DataPropertyName = "SilmeTarihi", HeaderText = "Silme Tarihi" }
               );

            dgvIstekSikayet.DataSource = tumIstekSikayetler;
            dgvIstekSikayet.ClearSelection();
        }

        private void dgvIstekSikayet_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvIstekSikayet.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvIstekSikayet.SelectedRows[0];

                int id = (int)selectedRow.Cells[0].Value;
                secilenIstekSikayet = istekSikayetService.IdyeGoreGetir(id);
                chOkunduMu.Checked = secilenIstekSikayet.OkunduMu;
            }
        }

        private void btnTumunuListele_Click(object sender, EventArgs e)
        {
            DGVFill();
        }

        private void btnOkunduGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                secilenIstekSikayet.OkunduMu = chOkunduMu.Checked;

                istekSikayetService.Guncelle(secilenIstekSikayet);

                MessageBox.Show("Okundu Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVFill();
                Fonksiyonlar.Temizle(this.Controls);
            }
            catch (Exception)
            {
                MessageBox.Show("Okundu Bilgisi Güncelleme Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Fonksiyonlar.Temizle(this.Controls);
            }
        }
    }
}

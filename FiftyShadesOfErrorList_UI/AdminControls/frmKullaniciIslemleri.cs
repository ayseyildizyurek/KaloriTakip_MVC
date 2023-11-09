using FiftyShadesOfErrorList_DATA.Entity;
using FiftyShadesOfErrorList_DATA.Enum;
using FiftyShadesOfErrorList_SERVICE.KullaniciGecmisDetayService;
using FiftyShadesOfErrorList_SERVICE.KullaniciService;
using FiftyShadesOfErrorList_UI.Metotlar;

namespace FiftyShadesOfErrorList_UI.UserControls
{
    public partial class frmKullaniciIslemleri : UserControl
    {
        Kullanici secilenKullanici = new Kullanici();
        KullaniciSERVICE kullaniciSERVICE = new KullaniciSERVICE();
        public frmKullaniciIslemleri()
        {
            InitializeComponent();
        }

        private void btnTumunuListele_Click(object sender, EventArgs e)
        {
            DGVFill();
        }

        private void DGVFill()
        {
            var tumkullanicilar = kullaniciSERVICE.TumunuGetir();

            dgvKullanici.AutoGenerateColumns = false;

            dgvKullanici.Columns.AddRange(
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Ad", HeaderText = "İsim" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Soyad", HeaderText = "Soyisim" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Cinsiyet", HeaderText = "Cinsiyet" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Email", HeaderText = "E-Posta" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Sifre", HeaderText = "Şifre" },
                new DataGridViewTextBoxColumn { DataPropertyName = "DogumTarihi", HeaderText = "Doğum Tarihi" },
                new DataGridViewTextBoxColumn { DataPropertyName = "VucutTipi", HeaderText = "Vücut Tipi" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Egzersiz", HeaderText = "Egzersiz Sıklığı" },
                new DataGridViewTextBoxColumn { DataPropertyName = "GunlukAlinanKalori", HeaderText = "Günlük Alınan Kalori" },
                new DataGridViewTextBoxColumn { DataPropertyName = "GunlukAlinanSuMiktari", HeaderText = "Günlük Alınan Su Miktarı" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Statü" }
               );

            dgvKullanici.DataSource = tumkullanicilar;
            dgvKullanici.CellFormatting += DgvKullanici_CellFormatting;
            dgvKullanici.ClearSelection();

            
        }

        private void frmKullaniciIslemleri_Load(object sender, EventArgs e)
        {
            Fonksiyonlar.ComboBoxDoldur<Cinsiyet>(cmbCinsiyet);
            Fonksiyonlar.ComboBoxDoldur<VucutTipi>(cmbVucutTipi);
            Fonksiyonlar.ComboBoxDoldur<Egzersiz>(cmbEgzersiz);
            Fonksiyonlar.ComboBoxDoldur<Status>(cmbStatu);
            DGVFill();
        }
        private void dgvKullanici_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvKullanici.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvKullanici.SelectedRows[0];

                int id = (int)selectedRow.Cells[0].Value;
                secilenKullanici = kullaniciSERVICE.IdyeGoreGetir(id);

                txtAd.Text = secilenKullanici.Ad.ToString();
                txtSoyad.Text = secilenKullanici.Soyad.ToString();
                txtSifreKayit.Text = secilenKullanici.Sifre.ToString();
                txtEpostaKayit.Text = secilenKullanici.Email.ToString();
                dtpDogumTarihi.Value = secilenKullanici.DogumTarihi;
                cmbCinsiyet.SelectedValue = (Cinsiyet)secilenKullanici.Cinsiyet;
                cmbEgzersiz.SelectedValue = (Egzersiz)secilenKullanici.Egzersiz;
                cmbStatu.SelectedValue = (Status)secilenKullanici.Status;
                cmbVucutTipi.SelectedValue = (VucutTipi)secilenKullanici.VucutTipi;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Kullanici kullanici = new Kullanici()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Email = txtEpostaKayit.Text,
                    Sifre = txtSifreKayit.Text,
                    Cinsiyet = (Cinsiyet)cmbCinsiyet.SelectedIndex,
                    DogumTarihi = dtpDogumTarihi.Value,
                    VucutTipi = (VucutTipi)cmbVucutTipi.SelectedIndex,
                    Egzersiz = (Egzersiz)cmbEgzersiz.SelectedIndex,
                    Status = (Status)cmbStatu.SelectedIndex
                };

                kullaniciSERVICE.Ekle(kullanici);

                KullaniciGecmisDetaySERVICE kullaniciGecmisDetayService = new KullaniciGecmisDetaySERVICE();
                KullaniciGecmisDetay yeniKullaniciDetay = new KullaniciGecmisDetay();
                yeniKullaniciDetay.KullaniciId = kullanici.Id;
                yeniKullaniciDetay.Boy = 0;
                yeniKullaniciDetay.Kilo = 0;
                kullaniciGecmisDetayService.Ekle(yeniKullaniciDetay);

                MessageBox.Show("Kullanıcı Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVFill();
                Fonksiyonlar.Temizle(this.Controls);
            }
            catch (Exception)
            {
                MessageBox.Show("Ekleme Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Fonksiyonlar.Temizle(this.Controls);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                secilenKullanici.Ad = txtAd.Text;
                secilenKullanici.Soyad = txtSoyad.Text;
                secilenKullanici.Email = txtEpostaKayit.Text;
                secilenKullanici.Sifre = txtSifreKayit.Text;
                secilenKullanici.Cinsiyet = (Cinsiyet)cmbCinsiyet.SelectedIndex;
                secilenKullanici.DogumTarihi = dtpDogumTarihi.Value;
                secilenKullanici.VucutTipi = (VucutTipi)cmbVucutTipi.SelectedIndex;
                secilenKullanici.Egzersiz = (Egzersiz)cmbEgzersiz.SelectedIndex;
                secilenKullanici.Status = (Status)cmbStatu.SelectedIndex;
                kullaniciSERVICE.Guncelle(secilenKullanici);
                MessageBox.Show("Kullanıcı Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVFill();
                Fonksiyonlar.Temizle(this.Controls);
            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Fonksiyonlar.Temizle(this.Controls);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                kullaniciSERVICE.Sil(secilenKullanici);
                MessageBox.Show("Kullanıcı Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVFill();
                Fonksiyonlar.Temizle(this.Controls);
            }
            catch (Exception)
            {
                MessageBox.Show("Silme Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Fonksiyonlar.Temizle(this.Controls);
            }
        }

        private void DgvKullanici_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int statusColumnIndex = -1;

            foreach (DataGridViewColumn column in dgvKullanici.Columns)
            {
                if (column.HeaderText == "Statü")
                {
                    statusColumnIndex = column.Index;
                    break;
                }
            }

            if (statusColumnIndex != -1 && e.RowIndex >= 0 && e.ColumnIndex == statusColumnIndex)
            {
                string statusValue = dgvKullanici.Rows[e.RowIndex].Cells[statusColumnIndex].Value.ToString();

                if (statusValue.Equals("Pasif", StringComparison.OrdinalIgnoreCase))
                {
                    dgvKullanici.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                }
                else if (statusValue.Equals("Aktif", StringComparison.OrdinalIgnoreCase))
                {
                    dgvKullanici.Rows[e.RowIndex].DefaultCellStyle.ForeColor = DefaultForeColor;
                }
            }

            if (dgvKullanici.Columns[e.ColumnIndex].Index == 5 && e.Value != null)
            {
                dgvKullanici.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }
    }
}


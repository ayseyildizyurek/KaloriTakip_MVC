using FiftyShadesOfErrorList_UI.Metotlar;

namespace FiftyShadesOfErrorList_UI.UserControls
{
    public partial class frmIdealKiloHesapla : UserControl
    {
        public frmIdealKiloHesapla()
        {
            InitializeComponent();
        }
        double idealKilo;
        private double IdealKiloHesapla()
        {
            try
            {
                double boy = Convert.ToDouble(txtBoy.Text);
                if (rdbErkek.Checked)
                {
                    idealKilo = 50 + 2.3 * ((boy / 2.54) - 60);
                }
                else if (rdbKadin.Checked)
                {
                    idealKilo = 45.5 + 2.3 * ((boy / 2.54) - 60);
                }

                return idealKilo;
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                lblIdealKilo.Text = IdealKiloHesapla().ToString("F2");
                int kilo = Convert.ToInt32(txtKilo.Text);

                if (IdealKiloHesapla() > kilo)
                {
                    lblHedefKilo.Text = $"Kilonuz ideal kilonuzun altındadır, \n{idealKilo - kilo:F2} kg almanız gerekmektedir.";
                }
                else if (IdealKiloHesapla() < kilo)
                {
                    lblHedefKilo.Text = $"Kilonuz ideal kilonuzun üstündedir, \n{kilo - idealKilo:F2} kg vermeniz gerekmektedir.";
                }
                else
                {
                    lblHedefKilo.Text = $"Tebrikler!!! İdeal kilodasınız..";
                }

                Fonksiyonlar.Temizle(this.Controls);
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

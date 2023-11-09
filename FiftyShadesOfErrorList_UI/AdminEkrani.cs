using FiftyShadesOfErrorList_UI.Metotlar;
using FiftyShadesOfErrorList_UI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiftyShadesOfErrorList_UI
{
    public partial class AdminEkrani : Form
    {
        private bool userControlsLoaded = false;
        public AdminEkrani()
        {
            InitializeComponent();

        }

        private void btnKullaniciIslemleri_Click(object sender, EventArgs e)
        {

            frmKullaniciIslemleri frmKullaniciIslemleri1 = new frmKullaniciIslemleri();
            frmKullaniciIslemleri1.Dock = DockStyle.Fill;
            panel1.Controls.Add(frmKullaniciIslemleri1);
            Fonksiyonlar.UserControlGoster(panel1, frmKullaniciIslemleri1);
        }

        private void btnBesinIslemleri_Click(object sender, EventArgs e)
        {

            frmBesinIslemleri frmBesinIslemleri1 = new frmBesinIslemleri();
            frmBesinIslemleri1.Dock = DockStyle.Fill;
            panel1.Controls.Add(frmBesinIslemleri1);
            Fonksiyonlar.UserControlGoster(panel1, frmBesinIslemleri1);
        }

        private void btnKategoriIslemleri_Click(object sender, EventArgs e)
        {

            frmKategoriIslemleri frmKategoriIslemleri1 = new frmKategoriIslemleri();
            frmKategoriIslemleri1.Dock = DockStyle.Fill;
            panel1.Controls.Add(frmKategoriIslemleri1);
            Fonksiyonlar.UserControlGoster(panel1, frmKategoriIslemleri1);
        }

        private void btnTalepSikayetIslemleri_Click(object sender, EventArgs e)
        {
            frmTalepSikayetIslemleri frmTalepSikayetIslemleri1 = new frmTalepSikayetIslemleri();
            frmTalepSikayetIslemleri1.Dock = DockStyle.Fill;
            panel1.Controls.Add(frmTalepSikayetIslemleri1);
            Fonksiyonlar.UserControlGoster(panel1, frmTalepSikayetIslemleri1);
        }

        private void AdminEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}

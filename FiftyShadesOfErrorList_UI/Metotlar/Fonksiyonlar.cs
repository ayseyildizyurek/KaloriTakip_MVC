using FiftyShadesOfErrorList_DATA.Entity;
using FiftyShadesOfErrorList_DATA.Enum;
using FiftyShadesOfErrorList_SERVICE.KullaniciService;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace FiftyShadesOfErrorList_UI.Metotlar
{
    public static class Fonksiyonlar
    {
        public static bool GirdiKontrol(Control.ControlCollection controlCollection)
        {
            bool sonuc = false;

            foreach (var item in controlCollection)
            {
                if (item is TextBox)
                {
                    sonuc = ((TextBox)item).Text == string.Empty ? true : false;
                   
                }
                if (item is ComboBox)
                {
                    sonuc = ((ComboBox)item).SelectedIndex == -1 ? true : false;

                }
                if (item is DateTimePicker)
                {
                    sonuc = ((DateTimePicker)item).Value == DateTime.Now ? true : false;
                }
                if (item is NumericUpDown)
                {
                    sonuc = ((NumericUpDown)item).Value == 0 ? true : false;
                }
                
                if (item is GroupBox)
                {
                    GirdiKontrol(((GroupBox)item).Controls);
                }
                if (item is Panel)
                {
                    GirdiKontrol(((Panel)item).Controls);
                }
            }

            return sonuc;
        }

        public static void Temizle(Control.ControlCollection controlCollection)
        {
            foreach (var item in controlCollection)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1;
                }
                if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
                if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = 0;
                }
                if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
                if (item is RadioButton)
                {
                    ((RadioButton)item).Checked = false;
                }
                if (item is DataGridView)
                {
                    ((DataGridView)item).ClearSelection();
                }
                if (item is PictureBox)
                {
                    ((PictureBox)item).Image = null;
                }
                if (item is GroupBox)
                {
                    GirdiKontrol(((GroupBox)item).Controls);
                }
                if (item is Panel)
                {
                    GirdiKontrol(((Panel)item).Controls);
                }
            }
        }

        public static int MailGonder(string eposta)
        {
            Random random = new Random();
            int activationCode = random.Next(100000, 999999);

            string senderEmail = "diyetapp@outlook.com"; // Gönderen e-posta adresi
            string senderPassword = "Fifty123456"; // Gönderen e-posta şifresi
            string recipientEmail = eposta; // Alıcı e-posta adresi

            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.office365.com");
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
                smtpClient.EnableSsl = true;

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(senderEmail);
                mailMessage.To.Add(recipientEmail);
                mailMessage.Subject = "Aktivasyon Kodu";
                mailMessage.Body = "Aktivasyon Kodunuz : " + activationCode;

                smtpClient.Send(mailMessage);

                MessageBox.Show("Aktivasyon kodu e-posta ile gönderildi.");
                return activationCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show("E-posta gönderme hatası: " + ex.Message);
                return 0;
            }
        }

        public static void UserControlGoster(Panel panel, UserControl userControl = null!)
        {
            foreach (var _userControl in panel.Controls)
            {
                if (_userControl is not PictureBox)
                {
                    if (_userControl == userControl)
                        ((UserControl)_userControl).Visible = true;
                    else
                        ((UserControl)_userControl).Visible = false;
                }
            }
        }

        public static string EnumAdiGetir(object value)
        {
            var fieldinfo = value.GetType().GetField(value.ToString());

            var attribute = fieldinfo.GetCustomAttributes(typeof(DisplayAttribute), false).Cast<DisplayAttribute>().FirstOrDefault();

            return attribute?.Name ?? value.ToString();
        }

        public static void ComboBoxDoldur<T>(ComboBox cmb)
        {
            var enumType = typeof(T);
            var enumValues = Enum.GetValues(enumType);

            var dataSource = enumValues
                .Cast<T>()
                .Select(x => new
                {
                    Value = x,
                    DisplayName = EnumAdiGetir(x)
                })
                .ToList();
            cmb.DataSource = dataSource;
            cmb.DisplayMember = "DisplayName";
            cmb.ValueMember = "Value";
            cmb.SelectedIndex = -1;

        }

        /// <summary>
        /// Bu metot kullanıcının oluşturduğu şifrenin gerekli şartlara uyup uymadığını kontrol eder
        /// </summary>
        /// <param name="sifre"></param>
        /// <returns></returns>
        public static bool SifreKontrol(string sifre)
        {
            if (sifre.Length < 8 || sifre.Length > 16)
            {
                return false;
            }
            if (!Regex.IsMatch(sifre, @"[A-Z]"))
            {
                return false;
            }
            if (!Regex.IsMatch(sifre, @"[!@#\$%\^&\*\(\)_\+{}\[\]:;<>,\.\?\\|]"))
            {
                return false;
            }
            if (!Regex.IsMatch(sifre, @"[a-z]"))
            {
                return false;
            }
            if (!Regex.IsMatch(sifre, @"[0-9]"))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Bu metot girilen mail adresinin geçerli olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="emailaddress"></param>
        /// <returns></returns>
        public static bool MailGecerliMi(string emailaddress)
        {
            try
            {
                MailAddress mail = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static Kullanici KullaniciBilgisiGetir()
        {
            string hatirlanacakMail = Properties.Settings.Default.Email;
            string hatirlanacakSifre = Properties.Settings.Default.Sifre;
            KullaniciSERVICE kullaniciService = new KullaniciSERVICE();
            var seciliKullanici = kullaniciService.EmaileGoreGetir(hatirlanacakMail, hatirlanacakSifre);
            return seciliKullanici;
        }
    }
}

using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Net.Mail;
using System.Data;

namespace vtys
{
    public partial class SignUpPage : Form
    {
        private bool sifreGizli = true;
        // Veritabanı bağlantı dizesi
        static string constring = "Data Source=UNIQUEA-PC\\SQLEXPRESS;Initial Catalog=ProjectTracker;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);
        public SignUpPage()
        {
            InitializeComponent();
            sifreBox.UseSystemPasswordChar = true;
            sifreBox1.UseSystemPasswordChar = true;
        }

        private void kayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan alınan değerleri değişkenlere ata
                string isim = adBox.Text;
                string soyisim = soyadBox.Text;
                string e_mail = emailBox.Text;
                string sifre = sifreBox.Text;

                // TextBox'ların boş olup olmadığını kontrol et
                if (string.IsNullOrWhiteSpace(isim) || string.IsNullOrWhiteSpace(soyisim) || string.IsNullOrWhiteSpace(e_mail) || string.IsNullOrWhiteSpace(sifre))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                    return;
                }

                // Şifre kutularının boş olup olmadığını kontrol et
                if (string.IsNullOrEmpty(sifreBox.Text) || string.IsNullOrEmpty(sifreBox1.Text))
                {
                    MessageBox.Show("Şifre boş olamaz.");
                    return;
                }

                // Şifre kutularının eşleşip eşleşmediğini kontrol et
                if (sifreBox.Text != sifreBox1.Text)
                {
                    MessageBox.Show("Şifreler uyuşmuyor. Lütfen aynı şifreyi giriniz.");
                    return;
                }

                // Mail adresinin formata uygun olup olmadığını kontrol et
                try
                {
                    MailAddress mailAddress = new MailAddress(e_mail);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Lütfen geçerli bir e-posta adresi giriniz.");
                    return;
                }

                using (SqlConnection connect = new SqlConnection(constring))
                {
                    // Bağlantıyı aç
                    connect.Open();

                    // INSERT sorgusunu oluştur ve parametreleri ekle
                    string sorgu = "INSERT INTO Kullaniciler (isim, soyisim, e_mail, sifre) VALUES (@isim, @soyisim, @e_mail, @sifre)";
                    using (SqlCommand komut = new SqlCommand(sorgu, connect))
                    {
                        komut.Parameters.AddWithValue("@isim", isim);
                        komut.Parameters.AddWithValue("@soyisim", soyisim);
                        komut.Parameters.AddWithValue("@e_mail", e_mail);
                        komut.Parameters.AddWithValue("@sifre", sifre);

                        // Sorguyu çalıştır
                        komut.ExecuteNonQuery();

                        // İşlem başarılı mesajı
                        MessageBox.Show("Kayıt başarıyla eklendi. Lütfen giriş yapınız.");

                        // Giriş ekranına yönlendirme
                        LoginPage form = new LoginPage();
                        this.Hide(); // Form2'yi gizle
                        form.ShowDialog();
                    }
                    connect.Close();
                }
            }
            catch (Exception)
            {
                // Hata durumunda kullanıcıya daha genel bir bilgi ver
                MessageBox.Show("Kayıt sırasında bir hata oluştu. Lütfen tekrar deneyiniz.");
            }
            finally
            {
                // Bağlantıyı her durumda kapat
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }
        private void sifreBox_TextChanged(object sender, EventArgs e)
        {
            // Şifre kutusundaki metni güncellediğimizde, her karakterin yerine '*' ekleyerek gerçek zamanlı gösterim sağla
            if (sifreGizli)
            {
                string yildizliSifre = new string('*', sifreBox.Text.Length);// Şifre kutusundaki metni '*' karakterleriyle değiştir
                sifreBox.UseSystemPasswordChar = false; // Karakter değiştirme işlemi yapılırken özelliği geçici olarak kapat
                sifreBox.Text = yildizliSifre;
                sifreBox.Select(yildizliSifre.Length, 0); // Cursor'ı metnin sonuna getir
                sifreBox.UseSystemPasswordChar = true; // Karakter değiştirme işlemi tamamlandığında özelliği tekrar aç
            }
        }

        private void sifreBox_Click(object sender, EventArgs e)
        {
            // Şifre kutusuna tıklandığında, metni göster veya gizle
            sifreGizli = !sifreGizli;
            sifreBox.UseSystemPasswordChar = !sifreGizli;
        }
        private void sifreBox1_TextChanged(object sender, EventArgs e)
        {
            // Şifre kutusundaki metni güncellediğimizde, her karakterin yerine '*' ekleyerek gerçek zamanlı gösterim sağla
            if (sifreGizli)
            {
                string yildizliSifre = new string('*', sifreBox1.Text.Length);// Şifre kutusundaki metni '*' karakterleriyle değiştir
                sifreBox1.UseSystemPasswordChar = false; // Karakter değiştirme işlemi yapılırken özelliği geçici olarak kapat
                sifreBox1.Text = yildizliSifre;
                sifreBox1.Select(yildizliSifre.Length, 0); // Cursor'ı metnin sonuna getir
                sifreBox1.UseSystemPasswordChar = true; // Karakter değiştirme işlemi tamamlandığında özelliği tekrar aç
            }
        }

        private void sifreBox1_Click(object sender, EventArgs e)
        {
            // Şifre kutusuna tıklandığında, metni göster veya gizle
            sifreGizli = !sifreGizli;
            sifreBox.UseSystemPasswordChar = !sifreGizli;
            // SifreBox1 başlangıçta boşsa ve SifreBox'a tıklandığında içeriğini değiştir
            if (string.IsNullOrEmpty(sifreBox1.Text) && !sifreBox1.Focused)
            {
                sifreBox1.Text = sifreBox.Text;
            }
            // Şifre kutularını kontrol et ve kullanıcıya bilgi ver
            if (sifreBox.Text == sifreBox1.Text)
            {
                label6.Text = "Şifreler aynı";
                label6.ForeColor = Color.Green; // Yeşil renk
            }
            else
            {
                label6.Text = "Şifreler aynı değil. Lütfen aynı şifreyi giriniz!";
                label6.ForeColor = Color.Red; // Kırmızı renk
            }
        }

        private void geri_Click(object sender, EventArgs e)
        {
            //Giriş sayfasına yönlendir
            LoginPage form1 = new LoginPage();
            this.Hide(); // Form2'yi gizle
            form1.ShowDialog();
        }

    }
}


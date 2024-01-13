using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace vtys
{
    public partial class SignUpPage : Form
    {
        private bool sifreGizli = true;
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
                // Kullanıcıdan alınan değerleri değişkenlere atayalım
                string isim = adBox.Text;
                string soyisim = soyadBox.Text;
                string e_mail = emailBox.Text;
                string sifre = sifreBox.Text;


                //********************************************************************************************************************TEXTBOXLARIN BOŞ DEĞER KABUL ETMEME DURUMU EKLENECEK!!!
                //********************************************************************************************************************GEREKSŞZ KSYIT OLMA DURUMLARI ORTADAN KSLDIRILACAK!!!


                // Veritabanı bağlantısı oluşturalım
                string constring = "Data Source=UNIQUEA-PC\\SQLEXPRESS;Initial Catalog=ProjectTracker;Integrated Security=True";
                using (SqlConnection connect = new SqlConnection(constring))
                {
                    // Bağlantıyı açalım
                    connect.Open();

                    // INSERT sorgusunu oluşturalım ve parametreleri ekleyelim
                    string sorgu = "INSERT INTO Kullaniciler (isim, soyisim, e_mail, sifre) VALUES (@isim, @soyisim, @e_mail, @sifre)";
                    using (SqlCommand komut = new SqlCommand(sorgu, connect))
                    {
                        komut.Parameters.AddWithValue("@isim", isim);
                        komut.Parameters.AddWithValue("@soyisim", soyisim);
                        komut.Parameters.AddWithValue("@e_mail", e_mail);
                        komut.Parameters.AddWithValue("@sifre", sifre);

                        // Sorguyu çalıştıralım
                        komut.ExecuteNonQuery();

                        // İşlem başarılı mesajını gösterelim
                        MessageBox.Show("Kayıt başarıyla eklendi.Lütfen giriş yapınız.");

                        // Form1'e yönlendirme işlemi
                        LoginPage form = new LoginPage();
                        this.Hide(); // Form2'yi gizle
                        form.ShowDialog();
                    }
                }
            }
            catch (Exception hata)
            {
                // Hata durumunda kullanıcıya bilgi verelim
                MessageBox.Show("Hata meydana geldi!" + hata.Message);
            }
        }
        private void sifreBox_TextChanged(object sender, EventArgs e)
        {
            // Şifre kutusundaki metni güncellediğimizde, her karakterin yerine '*' ekleyerek gerçek zamanlı gösterim sağla
            if (sifreGizli)
            {
                // Şifre kutusundaki metni '*' karakterleriyle değiştir
                string yildizliSifre = new string('*', sifreBox.Text.Length);
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
                // Şifre kutusundaki metni '*' karakterleriyle değiştir
                string yildizliSifre = new string('*', sifreBox.Text.Length);
                sifreBox.UseSystemPasswordChar = false; // Karakter değiştirme işlemi yapılırken özelliği geçici olarak kapat
                sifreBox.Text = yildizliSifre;
                sifreBox.Select(yildizliSifre.Length, 0); // Cursor'ı metnin sonuna getir
                sifreBox.UseSystemPasswordChar = true; // Karakter değiştirme işlemi tamamlandığında özelliği tekrar aç
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
            LoginPage form1 = new LoginPage();
            this.Hide(); // Form2'yi gizle
            form1.ShowDialog();
        }
    }
}


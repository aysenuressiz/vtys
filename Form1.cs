using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace vtys
{

    public partial class LoginPage : Form
    {
        private bool sifreGizli = true;
        // Giriş yapan kullanıcının ID'sini saklamak için global değişken
        public static int GirisYapanKullaniciID;

        // Veritabanı bağlantı dizesi
        static string constring = "Data Source=UNIQUEA-PC\\SQLEXPRESS;Initial Catalog=ProjectTracker;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);

        public LoginPage()
        {
            InitializeComponent();
            sifreBox.UseSystemPasswordChar = true;
        }
        
        private void girisButton_Click(object sender, EventArgs e){
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                // Kullanıcı adı ve şifreyi kontrol et
                string e_mail = isimBox.Text;
                string sifre = sifreBox.Text;

                // TextBox'ların boş olup olmadığını kontrol et
                if (string.IsNullOrWhiteSpace(e_mail) && string.IsNullOrWhiteSpace(sifre))
                {
                    MessageBox.Show("Kullanıcı adı ve şifre boş olamaz!");
                    return; 
                }

                if (string.IsNullOrWhiteSpace(e_mail))
                {
                    MessageBox.Show("Kullanıcı adı boş olamaz!");
                    return; 
                }

                if (string.IsNullOrWhiteSpace(sifre))
                {
                    MessageBox.Show("Şifre boş olamaz!");
                    return; 
                }

                // Kullanıcıyı bulmak için sorgu
                string sorgu = "SELECT COUNT(*) FROM Kullaniciler WHERE e_mail = @e_mail AND sifre = @sifre";

                using (SqlCommand komut = new SqlCommand(sorgu, connect)) { 
                    
                    komut.Parameters.AddWithValue("@e_mail", e_mail);
                    komut.Parameters.AddWithValue("@sifre", sifre);

                    // Giriş yapan kullanıcının ID'sini al
                    GirisYapanKullaniciID = Convert.ToInt32(komut.ExecuteScalar());


                    int kullaniciSayisi = (int)komut.ExecuteScalar();
                    // Kullanıcının veri tabanında olup olmadığını kontrol et 
                    if (kullaniciSayisi > 0){
                        // Anasayfaya yönlendir
                        HomePage form = new HomePage(); 
                        this.Hide(); //Form1 i gizle
                        form.Show();
                    } else 
                    {
                        MessageBox.Show("Bu kullanıcı bulunamadı."); 
                    }
                }
                connect.Close();
            }
            catch (Exception hata) {
                MessageBox.Show("Hata meydana geldi!" + hata.Message);
            }
            finally 
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close(); // Hata durumunda da bağlantıyı kapat
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

        private void kayitbutton_Click(object sender, EventArgs e)
        {
            // Kayıt Ol sayfasına yönlendir
            SignUpPage form2 = new SignUpPage();
            this.Hide(); // Form1 i Gizle
            form2.Show();
        }
    }
}


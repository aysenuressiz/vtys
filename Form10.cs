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
    public partial class AddEmployePage : Form
    {
        // Veritabanı bağlantı dizesi
        private static string constring = "Data Source=UNIQUEA-PC\\SQLEXPRESS;Initial Catalog=ProjectTracker;Integrated Security=True";
        public AddEmployePage()
        {
            InitializeComponent();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan alınan değerleri değişkenlere ata
                string isim = isimBox.Text;
                string soyisim = soyisimBox.Text;
                string email = mailBox.Text;
                string gecicisifre = geciciSifreBox.Text;

                // TextBox'ların boş olup olmadığını kontrol et
                if (string.IsNullOrEmpty(isim) || string.IsNullOrEmpty(soyisim) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(gecicisifre))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Eğer bir alan boşsa işlemi durdur
                }

                // Veritabanı bağlantısı oluştur
                using (SqlConnection connect = new SqlConnection(constring))
                {
                    // Bağlantıyı aç
                    connect.Open();

                    // INSERT sorgusunu oluştur ve parametreleri ekle
                    string sorgu = "INSERT INTO Kullaniciler (isim, soyisim, e_mail, sifre) VALUES (@isim, @soyisim, @email, @sifre)";
                    using (SqlCommand komut = new SqlCommand(sorgu, connect))
                    {
                        komut.Parameters.AddWithValue("@isim", isim);
                        komut.Parameters.AddWithValue("@soyisim", soyisim);
                        komut.Parameters.AddWithValue("@email", email);
                        komut.Parameters.AddWithValue("@sifre", gecicisifre);

                        // Sorguyu çalıştır
                        komut.ExecuteNonQuery();

                        // İşlem başarılı mesajı
                        MessageBox.Show("Çalışan başarıyla eklendi.");
                    }

                    // Bağlantıyı kapat
                    connect.Close();
                }
                this.Hide();
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi ver
                MessageBox.Show("İşlem sırasında bir hata oluştu: " + ex.Message);
            }
        }

        private void geri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
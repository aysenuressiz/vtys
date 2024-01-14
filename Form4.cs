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
using System.IO;

namespace vtys
{
    public partial class myAccountPage : Form
    {
        static string constring = "Data Source=UNIQUEA-PC\\SQLEXPRESS;Initial Catalog=ProjectTracker;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);

        string fotografAdi; // 'fotografAdi' değişkenini tanımlayın
        public myAccountPage()
        {
            InitializeComponent();
            // Kullanıcının bilgilerini çek
            LoadUserData();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // OpenFileDialog oluştur
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Kullanıcının seçtiği resmi 'fotografAdi' değişkenine kaydet
                fotografAdi = openFileDialog.FileName;

                // Kullanıcının seçtiği resmi butonun resmi olarak ayarla
                fotograf.BackgroundImage = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void geri_Click(object sender, EventArgs e)
        {
            HomePage form1 = new HomePage();
            this.Hide();
            form1.ShowDialog();
        }

        
        private void LoadUserData(){
        
            try
            {
                // Giriş yapan kullanıcının ID'sini kullanarak diğer bilgileri çekme
                string query = "SELECT isim, soyisim, e_mail, sifre, telefon  FROM Kullaniciler WHERE id = @id";

                using (SqlCommand komut = new SqlCommand(query, connect))
                {
                    // Giriş yapan kullanıcının ID'sini parametre olarak ekleyin
                    komut.Parameters.AddWithValue("@id", LoginPage.GirisYapanKullaniciID);

                    // Veritabanından verileri çek
                    SqlDataAdapter adapter = new SqlDataAdapter(komut);
                    DataTable userData = new DataTable();
                    adapter.Fill(userData);

                    // TextBox'lara verileri yerleştir
                    if (userData.Rows.Count > 0)
                    {
                        adBox.Text = userData.Rows[0]["isim"].ToString();
                        soyadBox.Text = userData.Rows[0]["soyisim"].ToString();
                        emailBox.Text = userData.Rows[0]["e_mail"].ToString();
                        sifreBox.Text = userData.Rows[0]["sifre"].ToString();
                        telefonBox.Text = userData.Rows[0]["telefon"].ToString();
                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
        private void guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                // Veritabanı bağlantısı oluştur
                string constring = "Data Source=UNIQUEA-PC\\SQLEXPRESS;Initial Catalog=ProjectTracker;Integrated Security=True";
                using (SqlConnection connect = new SqlConnection(constring))
                {
                    connect.Open();

                    // UPDATE sorgusunu oluştur ve parametreleri ekleyerek güncelle
                    string sorgu = "UPDATE Kullaniciler SET isim = @isim, soyisim = @soyisim, e_mail = @e_mail, sifre = @sifre, telefon = @telefon WHERE id = @id";
                    using (SqlCommand komut = new SqlCommand(sorgu, connect))
                    {
                        komut.Parameters.AddWithValue("@id", LoginPage.GirisYapanKullaniciID);
                        komut.Parameters.AddWithValue("@isim", adBox.Text);
                        komut.Parameters.AddWithValue("@soyisim", soyadBox.Text);
                        komut.Parameters.AddWithValue("@e_mail", emailBox.Text);
                        komut.Parameters.AddWithValue("@sifre", sifreBox.Text);
                        komut.Parameters.AddWithValue("@telefon", telefonBox.Text);

                        
                        // Sorguyu çalıştır
                        komut.ExecuteNonQuery();

                        // İşlem başarılı mesajını göster
                        MessageBox.Show("Bilgiler başarıyla güncellendi.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }        
    }
}

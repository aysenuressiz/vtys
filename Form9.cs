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
    public partial class UpdateEmployeePage : Form
    {
        private int selectedUserID;

        string fotografAdi; // 'fotografAdi' değişkenini tanımlayın
        public UpdateEmployeePage(int userID)
        {
            InitializeComponent();
            // Kullanıcının bilgilerini çek
            LoadUserData();
            selectedUserID = userID;
        }
        private void UpdateEmployeePage_Load(object sender, EventArgs e)
        {
            
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
            employeesPage form1 = new employeesPage();
            this.Hide();
            form1.ShowDialog();
        }

        private void LoadUserData()
        {
            try
            {
                // Veritabanı bağlantısı oluştur
                using (SqlConnection connect = new SqlConnection("Data Source=UNIQUEA-PC\\SQLEXPRESS;Initial Catalog=ProjectTracker;Integrated Security=True"))
                {
                    connect.Open();

                    // Seçilen kullanıcının bilgilerini çeken SQL sorgusu
                    string query = "SELECT isim, soyisim, fotografAdi FROM Kullaniciler WHERE id = @userID";
                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@userID", selectedUserID);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            // Kullanıcı bilgilerini form kontrollerine yerleştir
                            adBox.Text = reader["isim"].ToString();
                            soyadBox.Text = reader["soyisim"].ToString();
                            // Diğer bilgileri de ekle

                            // Örnek olarak "fotografAdi" sütununu kullanıcıya göstermek için
                            string imagePath = reader["fotografAdi"].ToString();
                            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                            {
                                fotograf.Image = Image.FromFile(imagePath);
                            }
                        }
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
                using (SqlConnection connect = new SqlConnection("Data Source=UNIQUEA-PC\\SQLEXPRESS;Initial Catalog=ProjectTracker;Integrated Security=True"))
                {
                    connect.Open();

                    // Kullanıcı bilgilerini güncellemek için SQL sorgusu
                    string updateQuery = "UPDATE Kullaniciler SET isim = @isim, soyisim = @soyisim WHERE id = @userID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connect))
                    {
                        command.Parameters.AddWithValue("@userID", selectedUserID);
                        command.Parameters.AddWithValue("@isim", adBox.Text);
                        command.Parameters.AddWithValue("@soyisim", soyadBox.Text);
                        // Diğer parametreleri de ekle

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Kullanıcı bilgileri başarıyla güncellendi.");
                            // Ana formu yeniden yükle
                            ((employeesPage)Application.OpenForms["employeesPage"]).LoadUserData();
                            this.Close(); // Güncelleme formunu kapat
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı bilgileri güncellenirken bir hata oluştu.");
                        }
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
//*************************************       BU KODDA HATALAR VAR DÜZENLENECEK       *********************************************
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

        private byte[] fotografBytes; // Byte dizisi olarak resmi saklamak için

        string fotografAdi; // 'fotografAdi' değişkenini tanımlayın
        public myAccountPage()
        {
            InitializeComponent();
            // Kullanıcının bilgilerini çek
            LoadUserData();
        }
        public string GetFotografAdi()
        {
            return fotografAdi;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fotografBytes = File.ReadAllBytes(openFileDialog.FileName);

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
                using (SqlConnection connect = new SqlConnection(constring))
                {
                    connect.Open();

                    string query = "SELECT isim, soyisim, e_mail, sifre, telefon, fotograf FROM Kullaniciler WHERE id = @id";

                    using (SqlCommand komut = new SqlCommand(query, connect))
                    {
                        komut.Parameters.AddWithValue("@id", LoginPage.GirisYapanKullaniciID);

                        SqlDataAdapter adapter = new SqlDataAdapter(komut);
                        DataTable userData = new DataTable();
                        adapter.Fill(userData);

                        if (userData.Rows.Count > 0)
                        {
                            adBox.Text = userData.Rows[0]["isim"].ToString();
                            soyadBox.Text = userData.Rows[0]["soyisim"].ToString();
                            emailBox.Text = userData.Rows[0]["e_mail"].ToString();
                            sifreBox.Text = userData.Rows[0]["sifre"].ToString();
                            telefonBox.Text = userData.Rows[0]["telefon"].ToString();

                            fotografAdi = userData.Rows[0]["fotograf"].ToString();

                            if (!string.IsNullOrEmpty(fotografAdi) && File.Exists(fotografAdi))
                            {
                                fotograf.BackgroundImage = Image.FromFile(fotografAdi);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Hatası oluştu: " + ex.Number + " - " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantının açık olup olmadığını kontrol et ve kapat
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }
        private void guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(constring))
                {
                    connect.Open();

                    string sorgu = "UPDATE Kullaniciler SET isim = @isim, soyisim = @soyisim, e_mail = @e_mail, sifre = @sifre, telefon = @telefon, fotograf = @fotograf WHERE id = @id";

                    using (SqlCommand komut = new SqlCommand(sorgu, connect))
                    {
                        komut.Parameters.AddWithValue("@id", LoginPage.GirisYapanKullaniciID);
                        komut.Parameters.AddWithValue("@isim", adBox.Text);
                        komut.Parameters.AddWithValue("@soyisim", soyadBox.Text);
                        komut.Parameters.AddWithValue("@e_mail", emailBox.Text);
                        komut.Parameters.AddWithValue("@sifre", sifreBox.Text);
                        komut.Parameters.AddWithValue("@telefon", telefonBox.Text);
                        komut.Parameters.AddWithValue("@fotograf", fotografBytes);

                        komut.ExecuteNonQuery();

                        MessageBox.Show("Bilgiler başarıyla güncellendi.");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Hatası oluştu: " + ex.Number + " - " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantının açık olup olmadığını kontrol et ve kapat
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }
    }        
}

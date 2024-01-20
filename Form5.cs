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
    public partial class ProjectAddPage : Form
    {
        public ProjectAddPage()
        {
            InitializeComponent();
        }
        
        private void projeEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan alınan değerleri değişkenlere atayalım
                string proje_adi = projeAdi.Text;
                DateTime baslangic_tarihi = baslangicTarihi.Value;
                DateTime bitis_tarihi = bitisTarihi.Value;

                // Veritabanı bağlantısı oluşturalım
                string constring = "Data Source=UNIQUEA-PC\\SQLEXPRESS;Initial Catalog=ProjectTracker;Integrated Security=True";
                using (SqlConnection connect = new SqlConnection(constring))
                {
                    // Bağlantıyı açalım
                    connect.Open();

                    // INSERT sorgusunu oluşturalım ve parametreleri ekleyelim
                    string sorgu = "INSERT INTO Projeler (Proje_adi, Baslangic_tarihi, Bitis_tarihi) VALUES (@proje_adi, @baslangic_tarihi, @bitis_tarihi)";
                    using (SqlCommand komut = new SqlCommand(sorgu, connect))
                    {
                        komut.Parameters.AddWithValue("@proje_adi", proje_adi);
                        komut.Parameters.AddWithValue("@baslangic_tarihi", baslangic_tarihi);
                        komut.Parameters.AddWithValue("@bitis_tarihi", bitis_tarihi);

                        // Sorguyu çalıştıralım
                        komut.ExecuteNonQuery();

                        // İşlem başarılı mesajını gösterelim
                        MessageBox.Show("Proje başarıyla eklendi.");
                    }
                    connect.Close();
                }
            }
            catch (Exception hata)
            {
                // Hata durumunda kullanıcıya bilgi verelim
                MessageBox.Show("Hata meydana geldi!" + hata.Message);
            }
        }

        private void geri_Click(object sender, EventArgs e)
        {
            HomePage form1 = new HomePage();
            this.Hide(); // Form2'yi gizle
            form1.ShowDialog();
        }
    }
}

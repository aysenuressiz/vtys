﻿using System;
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
    public partial class TaskAddPage : Form
    {
        static string constring = "Data Source=UNIQUEA-PC\\SQLEXPRESS;Initial Catalog=ProjectTracker;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);
        public TaskAddPage()
        {
            InitializeComponent();
            // Projeleri ve çalışanları yükleme
            LoadProjects();
            LoadEmployees();
        }

        private void LoadProjects()
        {
            try
            {
                // Projeleri veritabanından çekme
                string query = "SELECT id, proje_adi FROM Projeler";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                DataTable projectsTable = new DataTable();
                adapter.Fill(projectsTable);

                // ComboBox'a projeleri ekleme
                projeComboBox.DataSource = projectsTable;
                projeComboBox.DisplayMember = "proje_adi";
                projeComboBox.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void LoadEmployees()
        {
            try
            {
                // Çalışanları veritabanından çekme
                string query = "SELECT id, isim, soyisim FROM Kullaniciler";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                DataTable employeesTable = new DataTable();
                adapter.Fill(employeesTable);

                // isim ve soyisim sütunlarını birleştirip yeni bir sütun ekleyelim
                employeesTable.Columns.Add("FullName", typeof(string), "isim + ' ' + soyisim");

                // ComboBox'a çalışanları ekleme
                calisanComboBox.DataSource = employeesTable;
                calisanComboBox.DisplayMember = "FullName";
                calisanComboBox.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void görevEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan alınan değerleri değişkenlere atayalım
                int projeID = Convert.ToInt32(projeComboBox.SelectedValue);
                int calisanID = Convert.ToInt32(calisanComboBox.SelectedValue);
                string Gorev_adi = gorevAdi.Text;

                // Null kontrolü ekleyelim
                if (string.IsNullOrWhiteSpace(Gorev_adi))
                {
                    MessageBox.Show("Lütfen geçerli bir görev adı girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime baslangic_tarihi = baslangicTarihi.Value;
                DateTime bitis_tarihi = bitisTarihi.Value;

                // Başlangıç tarihi ile bitiş tarihi kontrolü ekleyelim
                if (baslangic_tarihi > bitis_tarihi)
                {
                    MessageBox.Show("Başlangıç tarihi, bitiş tarihinden sonra olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Veritabanı bağlantısı oluşturalım
                using (SqlConnection connect = new SqlConnection(constring))
                {
                    connect.Open();
                    // INSERT sorgusunu oluşturalım ve parametreleri ekleyelim
                    string sorgu = "INSERT INTO Gorevler (projeID, calisanID, Gorev_adi, baslangic_tarihi, bitis_tarihi) VALUES (@projeID, @calisanID, @Gorev_adi, @baslangic_tarihi, @bitis_tarihi)";
                    using (SqlCommand komut = new SqlCommand(sorgu, connect))
                    {
                        komut.Parameters.AddWithValue("@projeID", projeID);
                        komut.Parameters.AddWithValue("@calisanID", calisanID);
                        komut.Parameters.AddWithValue("@Gorev_adi", Gorev_adi);
                        komut.Parameters.AddWithValue("@baslangic_tarihi", baslangic_tarihi);
                        komut.Parameters.AddWithValue("@bitis_tarihi", bitis_tarihi);

                        // Sorguyu çalıştıralım
                        komut.ExecuteNonQuery();

                        // İşlem başarılı mesajını gösterelim
                        MessageBox.Show("Görev başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void geri_Click(object sender, EventArgs e)
        {
            HomePage form = new HomePage();
            this.Hide(); // Form6'yı gizle
            form.ShowDialog();
        }
    }
}

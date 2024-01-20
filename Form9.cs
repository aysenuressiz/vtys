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
        private static string constring = "Data Source=UNIQUEA-PC\\SQLEXPRESS;Initial Catalog=ProjectTracker;Integrated Security=True";
        private int selectedUserID;

        public UpdateEmployeePage()
        {
            InitializeComponent();
        }
        public void SetEmployeeID(int selectedEmployeeID)
        {
            selectedUserID = selectedEmployeeID;
            LoadUserData();
        }
        private void LoadUserData()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(constring))
                {
                    connect.Open();

                    string query = "SELECT isim, soyisim, e_mail, telefon FROM Kullaniciler WHERE id = @id";

                    using (SqlCommand komut = new SqlCommand(query, connect))
                    {
                        komut.Parameters.AddWithValue("@id", selectedUserID);

                        SqlDataReader reader = komut.ExecuteReader();

                        if (reader.Read())
                        {
                            // Veritabanından alınan bilgileri ilgili TextBox kontrollerine yerleştir
                            isimBox.Text = reader["isim"].ToString();
                            soyisimBox.Text = reader["soyisim"].ToString();
                            mailBox.Text = reader["e_mail"].ToString();
                            telefonBox.Text = reader["telefon"].ToString();
                        }

                        reader.Close();
                    }

                    connect.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilgiler çekilirken hata oluştu: " + ex.Message);
            }
        }

        private void geri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(constring))
                {
                    connect.Open();

                    string sorgu = "UPDATE Kullaniciler SET isim = @isim, soyisim = @soyisim, e_mail = @e_mail, telefon = @telefon WHERE id = @id";

                    using (SqlCommand komut = new SqlCommand(sorgu, connect))
                    {
                        komut.Parameters.AddWithValue("@id", selectedUserID);
                        komut.Parameters.AddWithValue("@isim", isimBox.Text);
                        komut.Parameters.AddWithValue("@soyisim", soyisimBox.Text);
                        komut.Parameters.AddWithValue("@e_mail", mailBox.Text);
                        komut.Parameters.AddWithValue("@telefon", telefonBox.Text);

                        komut.ExecuteNonQuery();

                        MessageBox.Show("Bilgiler başarıyla güncellendi.");
                    }

                    connect.Close();
                }
                this.Hide(); // Formu gizle
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilgiler güncellenirken hata oluştu: " + ex.Message);
            }
        }
    }
}

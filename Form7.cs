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
    public partial class EmployeeDetailPage : Form
    {
        private int userID;
        public EmployeeDetailPage(int selectedUserID)
        {
            InitializeComponent();
            userID = selectedUserID;
        }

        private void EmployeeDetailPage_Load(object sender, EventArgs e)
        {
            LoadUserTasks();
        }

        private void LoadUserTasks()
        {
            try
            {
                string constring = "Data Source=UNIQUEA-PC\\SQLEXPRESS;Initial Catalog=ProjectTracker;Integrated Security=True";
                using (SqlConnection connect = new SqlConnection(constring))
                {
                    connect.Open();

                    string query = "SELECT P.proje_adi, G.Gorev_adi, G.baslangic_tarihi, G.bitis_tarihi, G.durum " +
                                   "FROM Kullaniciler K " +
                                   "JOIN Gorevler G ON K.id = G.calisanID " +
                                   "JOIN Projeler P ON G.projeID = P.id " +
                                   "WHERE K.id = @userID";

                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@userID", userID);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable userTasks = new DataTable();
                        adapter.Fill(userTasks);

                        // DataGridView'e kullanıcının görev bilgilerini bind et
                        dataGridView1.DataSource = userTasks;

                        // DataGridView'deki sütun adlarını kontrol et
                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            Console.WriteLine("Sütun Adı: " + column.Name);
                        }

                        // 'durum' sütununun varlığını kontrol et
                        if (dataGridView1.Columns.Contains("durum"))
                        {
                            // DataGridView'deki hücreleri duruma göre renklendir ve durumu yazdır
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                // 'durum' sütununun hücresinin değerini almadan önce null kontrolü yap
                                if (row.Cells["durum"].Value != null)
                                {
                                    string taskStatus = row.Cells["durum"].Value.ToString();
                                    DataGridViewCellStyle style = new DataGridViewCellStyle();

                                    switch (taskStatus)  // Küçük harfe çevirerek kontrol et
                                    {
                                        case "Tamamlandı":
                                            style.BackColor = Color.Green; // Tamamlandı durumu için yeşil renk
                                            row.Cells["durum"].Value = "Tamamlandı";
                                            break;
                                        case "Devam ediyor":
                                            style.BackColor = Color.Yellow; // Devam Ediyor durumu için sarı renk
                                            row.Cells["durum"].Value = "Devam Ediyor";
                                            break;
                                        case "Başlayacak":
                                            style.BackColor = Color.Red; // Başlayacak durumu için kırmızı renk
                                            row.Cells["durum"].Value = "Başlayacak";
                                            break;
                                        default:
                                            break;
                                    }

                                    row.DefaultCellStyle = style;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("'durum' sütunu bulunamadı.");
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
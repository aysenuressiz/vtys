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
            CustomizeDataGridView(dataGridView1);
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
                        // DataGridView'deki 'durum' sütununu bul
                        DataGridViewColumn durumColumn = dataGridView1.Columns["durum"];
                        // 'durum' sütununun varlığını kontrol et
                        if (durumColumn != null)
                        {
                            // DataGridView'deki hücreleri duruma göre renklendir ve durumu yazdır
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                // 'durum' sütununun hücresinin değerini almadan önce null kontrolü yap
                                if (row.Cells["durum"].Value != null)
                                {
                                    string taskStatus = row.Cells["durum"].Value?.ToString().ToLower();
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

        private void CustomizeDataGridView(DataGridView dataGridView)
        {
            // DataGridView'i özelleştirme
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView.BackgroundColor = Color.White;

            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // DataGridView'deki 'durum' sütununu bul
            DataGridViewColumn durumColumn = dataGridView.Columns["durum"];

            if (durumColumn != null)
            {
                // DataGridView'deki her bir satırı döngü ile kontrol et
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    // 'durum' hücresinin değerini al ve küçük harfe çevir
                    string taskStatus = row.Cells[durumColumn.Index].Value?.ToString().ToLower();

                    // Duruma göre renk seçimi
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    switch (taskStatus)
                    {
                        case "tamamlandı":
                            style.BackColor = Color.Green;
                            break;
                        case "devam ediyor":
                            style.BackColor = Color.Yellow;
                            break;
                        case "başlayacak":
                            style.BackColor = Color.Red;
                            break;
                        default:
                            break;
                    }

                    // Hücrenin stilini belirtilen stille değiştir
                    row.Cells[durumColumn.Index].Style = style;
                }
            }
            else
            {
                MessageBox.Show("'durum' sütunu bulunamadı.");
            }
        }

        private void geri_Click(object sender, EventArgs e)
        {
            employeesPage form1 = new employeesPage();
            this.Hide();
            form1.ShowDialog();
        }
    }
}

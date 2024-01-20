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
            CustomizeDataGridView();
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

                        // DataGridView'deki 'durum' sütununu bul
                        DataGridViewColumn durumColumn = dataGridView1.Columns["durum"];

                        if (durumColumn != null)
                        {
                            // DataGridView'deki her bir satırı döngü ile kontrol et
                            foreach (DataGridViewRow row in dataGridView1.Rows)
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
                    connect.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void CustomizeDataGridView()
        {
            // DataGridView'i özelleştirme
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // DataGridView'deki 'durum' sütununu bul
            DataGridViewColumn durumColumn = dataGridView1.Columns["durum"];

            if (durumColumn != null)
            {
                // DataGridView'deki her bir satırı döngü ile kontrol et
                foreach (DataGridViewRow row in dataGridView1.Rows)
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

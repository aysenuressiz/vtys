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
        static string constring = "Data Source=UNIQUEA-PC\\SQLEXPRESS;Initial Catalog=ProjectTracker;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);
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
                using (SqlConnection connect = new SqlConnection(constring))
                {
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

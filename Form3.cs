using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace vtys
{
    public partial class HomePage : Form
    {
        private static string constring = "Data Source=UNIQUEA-PC\\SQLEXPRESS;Initial Catalog=ProjectTracker;Integrated Security=True";
        private SqlConnection connect = new SqlConnection(constring);

        public HomePage()
        {
            InitializeComponent();
            LoadUserData();
        }
        private void LoadUserData()
        {
            try
            {
                connect.Open();

                // Giriş yapan kullanıcının projelerini çek
                List<Project> projects = GetProjectsForUser(LoginPage.GirisYapanKullaniciID);

                // DataGridView için bir DataTable oluştur
                DataTable dataTable = new DataTable();

                // DataTable'a sütunları ekle
                dataTable.Columns.Add("GorevID"); // Yeni sütun: "GorevID"
                dataTable.Columns.Add("Proje Adı");
                dataTable.Columns.Add("Görev Adı");
                dataTable.Columns.Add("Görev Durumu", typeof(bool)); // bool türünde bir sütun ekleyin
                dataTable.Columns.Add("Bitiş Tarihi");
                dataTable.Columns.Add("Süre"); // Gecikme Miktarı sütununun adını "Süre" olarak değiştir

                // DataTable'a verileri ekle
                foreach (var project in projects)
                {
                    foreach (var task in project.Tasks)
                    {
                        // Görevin durumunu kontrol et ve gerekirse güncelle
                        if (!task.Tamamlandi && task.BitisTarihi < DateTime.Now)
                        {
                            task.Durum = "Tamamlandı";
                        }

                        // Gecikme veya kalan süreyi hesapla
                        TimeSpan gecikme = task.BitisTarihi - DateTime.Now;
                        string sure = "";

                        if (gecikme.Days > 0)
                        {
                            sure = $"{gecikme.Days} gün kaldı";
                        }
                        else if (gecikme.Days < 0)
                        {
                            // Süre geçtiyse, teslim tarihini bir gün uzat
                            task.BitisTarihi = task.BitisTarihi.AddDays(1);

                            // Yeni gecikmeyi hesapla
                            gecikme = task.BitisTarihi - DateTime.Now;
                            sure = $"{Math.Abs(gecikme.Days)} gün geçti, teslim tarihi 1 gün uzatıldı";

                            // Veritabanında teslim tarihini güncelle
                            UpdateTaskDueDateInDatabase(task.TaskID, task.BitisTarihi);
                        }
                        else
                        {
                            sure = "Bugün teslim edilecek";
                        }

                        // DataTable'a yeni satır ekle
                        dataTable.Rows.Add(task.TaskID, project.ProjeAdi, task.GorevAdi, !task.Tamamlandi, task.BitisTarihi.ToShortDateString(), sure);
                    }
                }

                // DataGridView için özel bir hücre şablonu oluştur
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.HeaderText = "Görev Durumu";
                checkBoxColumn.Name = "GorevDurumu";
                checkBoxColumn.DataPropertyName = "Görev Durumu";
                dataGridView1.Columns.Add(checkBoxColumn);

                // DataGridView'e DataTable'ı bağla
                dataGridView1.DataSource = dataTable;

                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void UpdateTaskStatusInDatabase(int rowIndex, bool newStatus)
        {
            try
            {
                connect.Open();

                // DataGridView'deki görevin ID'sini al
                int taskID = GetTaskIDFromDataGridView(rowIndex);

                // Veritabanında görevin durumunu ve tamamlanma tarihini güncelle
                string updateQuery = "UPDATE Gorevler SET durum = @durum, bitis_tarihi = @bitis_tarihi WHERE id = @id";

                using (SqlCommand command = new SqlCommand(updateQuery, connect))
                {
                    command.Parameters.AddWithValue("@durum", newStatus ? "Tamamlandı" : "Devam Ediyor");
                    command.Parameters.AddWithValue("@bitis_tarihi", newStatus ? DateTime.Now : (object)DBNull.Value); // Görev tamamlanmadıysa null olarak ayarla
                    command.Parameters.AddWithValue("@id", taskID);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private void UpdateTaskDueDateInDatabase(int taskID, DateTime newDueDate)
        {
            try
            {
                connect.Open();

                // Veritabanında görevin teslim tarihini güncelle
                string updateQuery = "UPDATE Gorevler SET bitis_tarihi = @bitis_tarihi WHERE id = @id";

                using (SqlCommand command = new SqlCommand(updateQuery, connect))
                {
                    command.Parameters.AddWithValue("@bitis_tarihi", newDueDate);
                    command.Parameters.AddWithValue("@id", taskID);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private int GetTaskIDFromDataGridView(int rowIndex)
        {
            // DataGridView'deki görevin ID'sini al
            DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
            int taskID = Convert.ToInt32(selectedRow.Cells["GorevID"].Value); // "GorevID" sütununu kullanın

            return taskID;
        }

        private List<Project> GetProjectsForUser(int kullaniciID)
        {
            List<Project> projects = new List<Project>();

            // Kullanıcının projelerini çeken SQL sorgusu
            string projectQuery = "SELECT P.id AS ProjectID, P.proje_adi AS ProjectName, " +
                                  "G.id AS TaskID, G.gorev_adi AS TaskName, G.durum AS TaskStatus, G.bitis_tarihi AS TaskDueDate, G.bitis_tarihi AS TaskCompletionDate " +
                                  "FROM Projeler P " +
                                  "LEFT JOIN Gorevler G ON P.id = G.projeID " +
                                  "WHERE G.calisanID = @kullaniciID";

            using (SqlCommand command = new SqlCommand(projectQuery, connect))
            {
                command.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int projectID = Convert.ToInt32(reader["ProjectID"]);
                    string projectName = reader["ProjectName"].ToString();

                    int taskID = Convert.ToInt32(reader["TaskID"]);
                    string taskName = reader["TaskName"].ToString();
                    string taskStatus = reader["TaskStatus"].ToString();
                    DateTime taskDueDate = Convert.ToDateTime(reader["TaskDueDate"]);
                    DateTime? taskCompletionDate = reader["TaskCompletionDate"] as DateTime?;

                    // Proje daha önce eklenmiş mi?
                    Project existingProject = projects.Find(p => p.ProjectID == projectID);
                    if (existingProject != null)
                    {
                        // Var olan projeye görevi ekle
                        existingProject.Tasks.Add(new Task { TaskID = taskID, GorevAdi = taskName, Durum = taskStatus, BitisTarihi = taskDueDate, Tamamlandi = taskCompletionDate.HasValue });
                    }
                    else
                    {
                        // Yeni bir proje oluştur ve görevi ekle
                        Project newProject = new Project { ProjectID = projectID, ProjeAdi = projectName };
                        newProject.Tasks.Add(new Task { TaskID = taskID, GorevAdi = taskName, Durum = taskStatus, BitisTarihi = taskDueDate, Tamamlandi = taskCompletionDate.HasValue });
                        projects.Add(newProject);
                    }
                }

                reader.Close();
            }

            return projects;
        }

        private class Project
        {
            public int ProjectID { get; set; }
            public string ProjeAdi { get; set; }
            public List<Task> Tasks { get; set; } = new List<Task>();
        }

        private class Task
        {
            public int TaskID { get; set; }
            public string GorevAdi { get; set; }
            public string Durum { get; set; }
            public DateTime BitisTarihi { get; set; }
            public bool Tamamlandi { get; set; }
        }

        private void hesabım_Click(object sender, EventArgs e)
        {
            myAccountPage form1 = new myAccountPage();
            this.Hide(); // Form3'ü gizle
            form1.ShowDialog();

            // Giriş yapan kullanıcının fotoğraf adını al
            string fotografAdi = form1.GetFotografAdi();

            // FotoğrafAdi boş değilse ve dosya mevcut ise butonun arka planını güncelle
            if (!string.IsNullOrEmpty(fotografAdi) && File.Exists(fotografAdi))
            {
                hesabım.BackgroundImage = Image.FromFile(fotografAdi);
            }

            this.Show(); // Form3'ü tekrar göster
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            LoginPage form1 = new LoginPage();
            this.Hide(); // Form3'ü gizle
            form1.ShowDialog();
        }

        private void projeEkle_Click(object sender, EventArgs e)
        {
            ProjectAddPage form1 = new ProjectAddPage();
            this.Hide(); // Form3'ü gizle
            form1.ShowDialog();
        }

        private void gorevEkle_Click(object sender, EventArgs e)
        {
            TaskAddPage form1 = new TaskAddPage();
            this.Hide(); // Form3'ü gizle
            form1.ShowDialog();
        }

        private void calisanlar_Click(object sender, EventArgs e)
        {
            employeesPage form1 = new employeesPage();
            this.Hide(); // Form3'ü gizle
            form1.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tıklanan hücre bir CheckBox hücresi mi kontrol et
            if (e.ColumnIndex == dataGridView1.Columns["GorevDurumu"].Index && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell checkBoxCell = dataGridView1.Rows[e.RowIndex].Cells["GorevDurumu"] as DataGridViewCheckBoxCell;

                // CheckBox değerini tersine çevir
                checkBoxCell.Value = !(bool)checkBoxCell.Value;

                // DataGridView üzerindeki CheckBox durumu değiştiğinde, veritabanında güncelleme yap
                UpdateTaskStatusInDatabase(e.RowIndex, (bool)checkBoxCell.Value);
            }
        }
    }
}
 
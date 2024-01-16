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
    public partial class employeesPage : Form
    {
        public employeesPage()
        {
            InitializeComponent();
        }

        private void employeesPage_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projectTrackerDataSet.Kullaniciler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kullanicilerTableAdapter.Fill(this.projectTrackerDataSet.Kullaniciler);
            LoadUserData();
        }

        private void LoadUserData()
        {
            try
            {
                // Veritabanı bağlantısı oluştur
                string constring = "Data Source=UNIQUEA-PC\\SQLEXPRESS;Initial Catalog=ProjectTracker;Integrated Security=True";
                using (SqlConnection connect = new SqlConnection(constring))
                {
                    connect.Open();

                    // Kullanıcıların listesini çeken SQL sorgusu
                    string query = "SELECT * FROM Kullaniciler";
                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable userData = new DataTable();
                        adapter.Fill(userData);

                        // DataGridView'e kullanıcıların listesini bind et
                    }

                    // Kullanıcının projelerini ve görevlerini çeken SQL sorgusu
                    string projectQuery = "SELECT P.proje_adi, G.Gorev_adi " +
                                          "FROM Projeler P " +
                                          "JOIN Assignments A ON P.id = A.ProjectID " +
                                          "JOIN Gorevler G ON A.TaskID = G.id " +
                                          "WHERE A.UserID = @userID";

                    using (SqlCommand command = new SqlCommand(projectQuery, connect))
                    {
                        // Örneğin, kullanıcı ID'sini 1 olarak kabul ediyoruz, siz gerçek kullanıcı ID'sini kullanmalısınız.
                        command.Parameters.AddWithValue("@userID", 1);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable projectData = new DataTable();
                        adapter.Fill(projectData);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

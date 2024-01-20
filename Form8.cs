
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            LoadUserData();
            CustomizeDataGridView();
        }

        public void LoadUserData()
        {
            try
            {
                // Veritabanı bağlantısı oluştur
                string constring = "Data Source=UNIQUEA-PC\\SQLEXPRESS;Initial Catalog=ProjectTracker;Integrated Security=True";
                using (SqlConnection connect = new SqlConnection(constring))
                {
                    connect.Open();

                    // Kullanıcıların listesini çeken SQL sorgusu
                    string query = "SELECT id, isim, soyisim, fotograf " +
                                   "FROM Kullaniciler";
                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable userData = new DataTable();
                        adapter.Fill(userData);

                        // 'AdSoyad' sütununu oluştur ve 'Ad' ve 'Soyad' sütunlarını birleştir
                        DataColumn adSoyadColumn = new DataColumn("AdSoyad", typeof(string), "isim + ' ' + soyisim");
                        userData.Columns.Add(adSoyadColumn);

                        // DataGridView'e kullanıcı bilgilerini bind et
                        dataGridView1.DataSource = userData;
                        // DataGridView'deki herhangi bir hücreye tıklanıldığında o satırdaki kullanıcı detaylarını gösteren olay ekle
                        dataGridView1.CellClick += dataGridView1_CellClick;

                        // DataGridView'deki "fotograf" sütununu resim olarak görüntüle
                        dataGridView1.Columns["fotograf"].Visible = false; // Resim dosya yolu gizli
                        using (DataGridViewImageColumn imageColumn = new DataGridViewImageColumn())
                        {
                            imageColumn.HeaderText = "Profil Fotoğrafı";
                            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                            dataGridView1.Columns.Add(imageColumn);
                        }

                        // DataGridView'e resimleri yükle
                        for (int i = 0; i < userData.Rows.Count; i++)
                        {
                            string imagePath = userData.Rows[i]["fotograf"].ToString();
                            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                            {
                                Image image = Image.FromFile(imagePath);
                                dataGridView1.Rows[i].Cells["Profil Fotoğrafı"].Value = image;
                            }
                        }

                        // DataGridView'deki gereksiz sütunları gizle
                        dataGridView1.Columns["id"].Visible = false;
                        dataGridView1.Columns["isim"].Visible = false;
                        dataGridView1.Columns["soyisim"].Visible = false;
                        dataGridView1.Columns["fotograf"].Visible = false;
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
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kullanıcının tıkladığı satırdaki ID'yi al
            int selectedUserID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);

            // Detay sayfasına yönlendirme
            EmployeeDetailPage form9 = new EmployeeDetailPage(selectedUserID);
            this.Hide();
            form9.ShowDialog();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            HomePage form1 = new HomePage();
            this.Hide(); 
            form1.ShowDialog();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            AddEmployePage form1 = new AddEmployePage();
            form1.ShowDialog(); 
        }

        private void sil_Click(object sender, EventArgs e)
        {
            // Kullanıcının tıkladığı satırdaki ID'yi al
            int selectedUserID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

            // Silme işlemini gerçekleştirmek için SQL sorgusu
            string deleteQuery = "DELETE FROM Kullaniciler WHERE id = @userID";

            try
            {
                using (SqlConnection connect = new SqlConnection("Data Source=UNIQUEA-PC\\SQLEXPRESS;Initial Catalog=ProjectTracker;Integrated Security=True"))
                {
                    connect.Open();
                    using (SqlCommand command = new SqlCommand(deleteQuery, connect))
                    {
                        command.Parameters.AddWithValue("@userID", selectedUserID);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Kullanıcı başarıyla silindi.");
                            // Veriyi yeniden yükle
                            LoadUserData();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı silinirken bir hata oluştu.");
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

        private void guncelle_Click(object sender, EventArgs e)
        {

            UpdateEmployeePage form1 = new UpdateEmployeePage();
            form1.ShowDialog();
        }
    }
}

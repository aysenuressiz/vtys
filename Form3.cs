using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtys
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void hesabım_Click(object sender, EventArgs e)
        {
            myAccountPage form1 = new myAccountPage();
            this.Hide(); // Form3'ü gizle
            form1.ShowDialog();
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
    }
}

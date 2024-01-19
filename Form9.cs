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
        public UpdateEmployeePage()
        {
            InitializeComponent();

        }
        private void UpdateEmployeePage_Load(object sender, EventArgs e)
        {
            
        }

        private void geri_Click(object sender, EventArgs e)
        {
            employeesPage form1 = new employeesPage();
            this.Hide();
            form1.ShowDialog();
        }

        
        private void guncelle_Click(object sender, EventArgs e)
        {
            
        }
    }
}
//*************************************       BURANIN KODU YAZILACAK       *********************************************
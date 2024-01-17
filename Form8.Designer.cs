namespace vtys
{
    partial class employeesPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.projectTrackerDataSet = new vtys.ProjectTrackerDataSet();
            this.kullanicilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullanicilerTableAdapter = new vtys.ProjectTrackerDataSetTableAdapters.KullanicilerTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.projectTrackerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // projectTrackerDataSet
            // 
            this.projectTrackerDataSet.DataSetName = "ProjectTrackerDataSet";
            this.projectTrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullanicilerBindingSource
            // 
            this.kullanicilerBindingSource.DataMember = "Kullaniciler";
            this.kullanicilerBindingSource.DataSource = this.projectTrackerDataSet;
            // 
            // kullanicilerTableAdapter
            // 
            this.kullanicilerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(159, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(831, 423);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // employeesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 630);
            this.Controls.Add(this.dataGridView1);
            this.Name = "employeesPage";
            this.Text = "EMPLOYEES PAGE";
            this.Load += new System.EventHandler(this.employeesPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectTrackerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ProjectTrackerDataSet projectTrackerDataSet;
        private System.Windows.Forms.BindingSource kullanicilerBindingSource;
        private ProjectTrackerDataSetTableAdapters.KullanicilerTableAdapter kullanicilerTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
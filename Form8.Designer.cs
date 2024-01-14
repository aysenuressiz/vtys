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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.projectTrackerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilerBindingSource)).BeginInit();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.96078F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.03922F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 82);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.71754F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.28246F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1127, 439);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // employeesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 630);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "employeesPage";
            this.Text = "EMPLOYEES PAGE";
            this.Load += new System.EventHandler(this.employeesPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectTrackerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ProjectTrackerDataSet projectTrackerDataSet;
        private System.Windows.Forms.BindingSource kullanicilerBindingSource;
        private ProjectTrackerDataSetTableAdapters.KullanicilerTableAdapter kullanicilerTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
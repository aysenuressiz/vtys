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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employeesPage));
            this.projectTrackerDataSet = new vtys.ProjectTrackerDataSet();
            this.kullanicilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullanicilerTableAdapter = new vtys.ProjectTrackerDataSetTableAdapters.KullanicilerTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.geri = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
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
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(150, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(968, 437);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // geri
            // 
            this.geri.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.geri.BackColor = System.Drawing.Color.MidnightBlue;
            this.geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.geri.Location = new System.Drawing.Point(213, 565);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(140, 68);
            this.geri.TabIndex = 13;
            this.geri.Text = "GERİ";
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // ekle
            // 
            this.ekle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ekle.BackColor = System.Drawing.Color.MidnightBlue;
            this.ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ekle.Location = new System.Drawing.Point(454, 565);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(140, 68);
            this.ekle.TabIndex = 32;
            this.ekle.Text = "EKLE";
            this.ekle.UseVisualStyleBackColor = false;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // sil
            // 
            this.sil.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sil.BackColor = System.Drawing.Color.MidnightBlue;
            this.sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sil.Location = new System.Drawing.Point(699, 565);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(140, 68);
            this.sil.TabIndex = 33;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // guncelle
            // 
            this.guncelle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guncelle.BackColor = System.Drawing.Color.MidnightBlue;
            this.guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guncelle.Location = new System.Drawing.Point(915, 622);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(146, 68);
            this.guncelle.TabIndex = 34;
            this.guncelle.Text = "GÜNCELLE";
            this.guncelle.UseVisualStyleBackColor = false;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.MidnightBlue;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(0, 55);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(85, 12, 12, 12);
            this.label12.Size = new System.Drawing.Size(300, 45);
            this.label12.TabIndex = 35;
            this.label12.Text = "ÇALIŞANLAR";
            // 
            // employeesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 668);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.dataGridView1);
            this.Name = "employeesPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Label label12;
    }
}
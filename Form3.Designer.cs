namespace vtys
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.hesabım = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.projeEkle = new System.Windows.Forms.Button();
            this.gorevEkle = new System.Windows.Forms.Button();
            this.calisanlar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTamamlanacakGorevSayisi = new System.Windows.Forms.Label();
            this.lblDevamEdenGorevSayisi = new System.Windows.Forms.Label();
            this.lblTamamlananGorevSayisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // hesabım
            // 
            this.hesabım.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hesabım.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hesabım.BackgroundImage")));
            this.hesabım.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hesabım.Location = new System.Drawing.Point(1099, 12);
            this.hesabım.Name = "hesabım";
            this.hesabım.Size = new System.Drawing.Size(45, 45);
            this.hesabım.TabIndex = 12;
            this.hesabım.UseVisualStyleBackColor = true;
            this.hesabım.Click += new System.EventHandler(this.hesabım_Click);
            // 
            // cikis
            // 
            this.cikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cikis.BackColor = System.Drawing.Color.Transparent;
            this.cikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cikis.BackgroundImage")));
            this.cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cikis.Location = new System.Drawing.Point(1198, 12);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(45, 45);
            this.cikis.TabIndex = 13;
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1074, 61);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 4, 4, 4);
            this.label2.Size = new System.Drawing.Size(99, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hesabım";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.MidnightBlue;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1188, 61);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.label3.Size = new System.Drawing.Size(72, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Çıkış";
            // 
            // projeEkle
            // 
            this.projeEkle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.projeEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("projeEkle.BackgroundImage")));
            this.projeEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.projeEkle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projeEkle.ForeColor = System.Drawing.Color.DimGray;
            this.projeEkle.Location = new System.Drawing.Point(156, 122);
            this.projeEkle.Name = "projeEkle";
            this.projeEkle.Size = new System.Drawing.Size(161, 161);
            this.projeEkle.TabIndex = 16;
            this.projeEkle.Text = "Proje Ekle";
            this.projeEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.projeEkle.UseVisualStyleBackColor = true;
            this.projeEkle.Click += new System.EventHandler(this.projeEkle_Click);
            // 
            // gorevEkle
            // 
            this.gorevEkle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gorevEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gorevEkle.BackgroundImage")));
            this.gorevEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gorevEkle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gorevEkle.ForeColor = System.Drawing.Color.DimGray;
            this.gorevEkle.Location = new System.Drawing.Point(377, 122);
            this.gorevEkle.Name = "gorevEkle";
            this.gorevEkle.Size = new System.Drawing.Size(161, 161);
            this.gorevEkle.TabIndex = 17;
            this.gorevEkle.Text = "Görev Ekle";
            this.gorevEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gorevEkle.UseVisualStyleBackColor = true;
            this.gorevEkle.Click += new System.EventHandler(this.gorevEkle_Click);
            // 
            // calisanlar
            // 
            this.calisanlar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.calisanlar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("calisanlar.BackgroundImage")));
            this.calisanlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.calisanlar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calisanlar.ForeColor = System.Drawing.Color.DimGray;
            this.calisanlar.Location = new System.Drawing.Point(590, 122);
            this.calisanlar.Name = "calisanlar";
            this.calisanlar.Size = new System.Drawing.Size(161, 161);
            this.calisanlar.TabIndex = 18;
            this.calisanlar.Text = "Çalışanlar";
            this.calisanlar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.calisanlar.UseVisualStyleBackColor = true;
            this.calisanlar.Click += new System.EventHandler(this.calisanlar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1126, 322);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.Tag = "";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.MidnightBlue;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(0, 55);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(90, 12, 12, 12);
            this.label12.Size = new System.Drawing.Size(300, 45);
            this.label12.TabIndex = 24;
            this.label12.Text = "ANA SAYFA";
            // 
            // lblTamamlanacakGorevSayisi
            // 
            this.lblTamamlanacakGorevSayisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTamamlanacakGorevSayisi.BackColor = System.Drawing.Color.DarkRed;
            this.lblTamamlanacakGorevSayisi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamamlanacakGorevSayisi.ForeColor = System.Drawing.Color.White;
            this.lblTamamlanacakGorevSayisi.Location = new System.Drawing.Point(829, 131);
            this.lblTamamlanacakGorevSayisi.Name = "lblTamamlanacakGorevSayisi";
            this.lblTamamlanacakGorevSayisi.Padding = new System.Windows.Forms.Padding(10, 4, 4, 4);
            this.lblTamamlanacakGorevSayisi.Size = new System.Drawing.Size(315, 32);
            this.lblTamamlanacakGorevSayisi.TabIndex = 25;
            // 
            // lblDevamEdenGorevSayisi
            // 
            this.lblDevamEdenGorevSayisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDevamEdenGorevSayisi.BackColor = System.Drawing.Color.Goldenrod;
            this.lblDevamEdenGorevSayisi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevamEdenGorevSayisi.ForeColor = System.Drawing.Color.White;
            this.lblDevamEdenGorevSayisi.Location = new System.Drawing.Point(829, 182);
            this.lblDevamEdenGorevSayisi.Name = "lblDevamEdenGorevSayisi";
            this.lblDevamEdenGorevSayisi.Padding = new System.Windows.Forms.Padding(10, 4, 4, 4);
            this.lblDevamEdenGorevSayisi.Size = new System.Drawing.Size(315, 32);
            this.lblDevamEdenGorevSayisi.TabIndex = 26;
            // 
            // lblTamamlananGorevSayisi
            // 
            this.lblTamamlananGorevSayisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTamamlananGorevSayisi.BackColor = System.Drawing.Color.DarkGreen;
            this.lblTamamlananGorevSayisi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamamlananGorevSayisi.ForeColor = System.Drawing.Color.White;
            this.lblTamamlananGorevSayisi.Location = new System.Drawing.Point(829, 234);
            this.lblTamamlananGorevSayisi.Name = "lblTamamlananGorevSayisi";
            this.lblTamamlananGorevSayisi.Padding = new System.Windows.Forms.Padding(10, 4, 4, 4);
            this.lblTamamlananGorevSayisi.Size = new System.Drawing.Size(315, 32);
            this.lblTamamlananGorevSayisi.TabIndex = 27;
            this.lblTamamlananGorevSayisi.Click += new System.EventHandler(this.label5_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 668);
            this.Controls.Add(this.lblTamamlananGorevSayisi);
            this.Controls.Add(this.lblDevamEdenGorevSayisi);
            this.Controls.Add(this.lblTamamlanacakGorevSayisi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calisanlar);
            this.Controls.Add(this.gorevEkle);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.hesabım);
            this.Controls.Add(this.projeEkle);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME PAGE";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button hesabım;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button projeEkle;
        private System.Windows.Forms.Button gorevEkle;
        private System.Windows.Forms.Button calisanlar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTamamlanacakGorevSayisi;
        private System.Windows.Forms.Label lblDevamEdenGorevSayisi;
        private System.Windows.Forms.Label lblTamamlananGorevSayisi;
    }
}
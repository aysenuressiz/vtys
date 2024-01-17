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
            this.projeListele = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hesabım
            // 
            this.hesabım.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hesabım.BackgroundImage")));
            this.hesabım.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hesabım.Location = new System.Drawing.Point(28, 12);
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
            this.cikis.Location = new System.Drawing.Point(1173, 12);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(45, 45);
            this.cikis.TabIndex = 13;
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 61);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(89, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hesabım";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.MidnightBlue;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1169, 61);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3);
            this.label3.Size = new System.Drawing.Size(63, 30);
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
            this.projeEkle.Location = new System.Drawing.Point(376, 141);
            this.projeEkle.Name = "projeEkle";
            this.projeEkle.Size = new System.Drawing.Size(129, 135);
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
            this.gorevEkle.Location = new System.Drawing.Point(597, 141);
            this.gorevEkle.Name = "gorevEkle";
            this.gorevEkle.Size = new System.Drawing.Size(129, 135);
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
            this.calisanlar.Location = new System.Drawing.Point(810, 141);
            this.calisanlar.Name = "calisanlar";
            this.calisanlar.Size = new System.Drawing.Size(129, 135);
            this.calisanlar.TabIndex = 18;
            this.calisanlar.Text = "Çalışanlar";
            this.calisanlar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.calisanlar.UseVisualStyleBackColor = true;
            this.calisanlar.Click += new System.EventHandler(this.calisanlar_Click);
            // 
            // projeListele
            // 
            this.projeListele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("projeListele.BackgroundImage")));
            this.projeListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.projeListele.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projeListele.ForeColor = System.Drawing.Color.DimGray;
            this.projeListele.Location = new System.Drawing.Point(203, 375);
            this.projeListele.Name = "projeListele";
            this.projeListele.Size = new System.Drawing.Size(190, 190);
            this.projeListele.TabIndex = 19;
            this.projeListele.Text = "Proje Listele";
            this.projeListele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.projeListele.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.MidnightBlue;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(0, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1265, 23);
            this.label13.TabIndex = 21;
            this.label13.Text = "ANASAYFA";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.MidnightBlue;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1265, 68);
            this.label12.TabIndex = 20;
            this.label12.Text = "     PROJECT  TRACKER      ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1265, 729);
            this.Controls.Add(this.projeListele);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calisanlar);
            this.Controls.Add(this.gorevEkle);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.hesabım);
            this.Controls.Add(this.projeEkle);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME PAGE";
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
        private System.Windows.Forms.Button projeListele;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}
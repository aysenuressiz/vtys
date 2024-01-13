namespace vtys
{
    partial class TaskAddPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.görevEkle = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.kullanicilerTableAdapter1 = new vtys.ProjeYonetimVeriTabaniDataSetTableAdapters.KullanicilerTableAdapter();
            this.adamGunDegeri = new System.Windows.Forms.TextBox();
            this.gorevAdi = new System.Windows.Forms.TextBox();
            this.gorevTanimi = new System.Windows.Forms.TextBox();
            this.baslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.bitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.projeComboBox = new System.Windows.Forms.ComboBox();
            this.calisanComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(256, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROJE SEÇİNİZ:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(256, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "ÇALIŞAN SEÇİNİZ:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(256, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "ADAM GÜN DEĞERİ:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(256, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "GÖREV ADI:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(256, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "GÖREV TANIMI:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(256, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "BAŞLANGIÇ TARİHİ:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(256, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "BİTİŞ TARİHİ:";
            // 
            // görevEkle
            // 
            this.görevEkle.Location = new System.Drawing.Point(642, 487);
            this.görevEkle.Name = "görevEkle";
            this.görevEkle.Size = new System.Drawing.Size(140, 56);
            this.görevEkle.TabIndex = 7;
            this.görevEkle.Text = "GÖREV EKLE";
            this.görevEkle.UseVisualStyleBackColor = true;
            this.görevEkle.Click += new System.EventHandler(this.görevEkle_Click);
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(398, 487);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(140, 56);
            this.geri.TabIndex = 8;
            this.geri.Text = "GERİ";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // kullanicilerTableAdapter1
            // 
            this.kullanicilerTableAdapter1.ClearBeforeFill = true;
            // 
            // adamGunDegeri
            // 
            this.adamGunDegeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adamGunDegeri.Location = new System.Drawing.Point(510, 132);
            this.adamGunDegeri.Name = "adamGunDegeri";
            this.adamGunDegeri.Size = new System.Drawing.Size(375, 30);
            this.adamGunDegeri.TabIndex = 9;
            // 
            // gorevAdi
            // 
            this.gorevAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gorevAdi.Location = new System.Drawing.Point(510, 184);
            this.gorevAdi.Name = "gorevAdi";
            this.gorevAdi.Size = new System.Drawing.Size(375, 30);
            this.gorevAdi.TabIndex = 10;
            // 
            // gorevTanimi
            // 
            this.gorevTanimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gorevTanimi.Location = new System.Drawing.Point(510, 242);
            this.gorevTanimi.Multiline = true;
            this.gorevTanimi.Name = "gorevTanimi";
            this.gorevTanimi.Size = new System.Drawing.Size(375, 131);
            this.gorevTanimi.TabIndex = 11;
            // 
            // baslangicTarihi
            // 
            this.baslangicTarihi.Location = new System.Drawing.Point(510, 393);
            this.baslangicTarihi.Name = "baslangicTarihi";
            this.baslangicTarihi.Size = new System.Drawing.Size(375, 22);
            this.baslangicTarihi.TabIndex = 12;
            // 
            // bitisTarihi
            // 
            this.bitisTarihi.Location = new System.Drawing.Point(510, 437);
            this.bitisTarihi.Name = "bitisTarihi";
            this.bitisTarihi.Size = new System.Drawing.Size(375, 22);
            this.bitisTarihi.TabIndex = 13;
            // 
            // projeComboBox
            // 
            this.projeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projeComboBox.FormattingEnabled = true;
            this.projeComboBox.Location = new System.Drawing.Point(510, 28);
            this.projeComboBox.Name = "projeComboBox";
            this.projeComboBox.Size = new System.Drawing.Size(375, 33);
            this.projeComboBox.TabIndex = 14;
            // 
            // calisanComboBox
            // 
            this.calisanComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calisanComboBox.FormattingEnabled = true;
            this.calisanComboBox.Location = new System.Drawing.Point(510, 79);
            this.calisanComboBox.Name = "calisanComboBox";
            this.calisanComboBox.Size = new System.Drawing.Size(375, 33);
            this.calisanComboBox.TabIndex = 15;
            // 
            // TaskAddPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 630);
            this.Controls.Add(this.calisanComboBox);
            this.Controls.Add(this.projeComboBox);
            this.Controls.Add(this.bitisTarihi);
            this.Controls.Add(this.baslangicTarihi);
            this.Controls.Add(this.gorevTanimi);
            this.Controls.Add(this.gorevAdi);
            this.Controls.Add(this.adamGunDegeri);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.görevEkle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TaskAddPage";
            this.Text = "TASK ADD PAGE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button görevEkle;
        private System.Windows.Forms.Button geri;
        private ProjeYonetimVeriTabaniDataSetTableAdapters.KullanicilerTableAdapter kullanicilerTableAdapter1;
        private System.Windows.Forms.TextBox adamGunDegeri;
        private System.Windows.Forms.TextBox gorevAdi;
        private System.Windows.Forms.TextBox gorevTanimi;
        private System.Windows.Forms.DateTimePicker baslangicTarihi;
        private System.Windows.Forms.DateTimePicker bitisTarihi;
        private System.Windows.Forms.ComboBox projeComboBox;
        private System.Windows.Forms.ComboBox calisanComboBox;
    }
}
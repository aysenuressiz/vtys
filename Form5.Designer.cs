﻿namespace vtys
{
    partial class ProjectAddPage
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
            this.projeAdi = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.projeAçiklamasi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.projeEkle = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.baslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.bitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // projeAdi
            // 
            this.projeAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projeAdi.Location = new System.Drawing.Point(528, 46);
            this.projeAdi.Name = "projeAdi";
            this.projeAdi.Size = new System.Drawing.Size(251, 30);
            this.projeAdi.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // projeAçiklamasi
            // 
            this.projeAçiklamasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projeAçiklamasi.Location = new System.Drawing.Point(528, 119);
            this.projeAçiklamasi.Name = "projeAçiklamasi";
            this.projeAçiklamasi.Size = new System.Drawing.Size(251, 30);
            this.projeAçiklamasi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(313, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "PROJE ADI:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(310, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "BAŞLANGIÇ TARİHİ:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(310, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "BİTİŞ TARİHİ:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(310, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "PROJE AÇIKLAMASI:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // projeEkle
            // 
            this.projeEkle.Location = new System.Drawing.Point(619, 415);
            this.projeEkle.Name = "projeEkle";
            this.projeEkle.Size = new System.Drawing.Size(128, 46);
            this.projeEkle.TabIndex = 11;
            this.projeEkle.Text = "PROJE EKLE";
            this.projeEkle.UseVisualStyleBackColor = true;
            this.projeEkle.Click += new System.EventHandler(this.projeEkle_Click);
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(422, 415);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(128, 46);
            this.geri.TabIndex = 12;
            this.geri.Text = "GERİ";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // baslangicTarihi
            // 
            this.baslangicTarihi.Location = new System.Drawing.Point(528, 234);
            this.baslangicTarihi.Name = "baslangicTarihi";
            this.baslangicTarihi.Size = new System.Drawing.Size(251, 22);
            this.baslangicTarihi.TabIndex = 13;
            // 
            // bitisTarihi
            // 
            this.bitisTarihi.Location = new System.Drawing.Point(528, 315);
            this.bitisTarihi.Name = "bitisTarihi";
            this.bitisTarihi.Size = new System.Drawing.Size(251, 22);
            this.bitisTarihi.TabIndex = 14;
            // 
            // ProjectAddPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 630);
            this.Controls.Add(this.bitisTarihi);
            this.Controls.Add(this.baslangicTarihi);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.projeEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.projeAçiklamasi);
            this.Controls.Add(this.projeAdi);
            this.Name = "ProjectAddPage";
            this.Text = "PROJECT ADD PAGE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox projeAdi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox projeAçiklamasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button projeEkle;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.DateTimePicker baslangicTarihi;
        private System.Windows.Forms.DateTimePicker bitisTarihi;
    }
}
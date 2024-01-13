using System;

namespace vtys
{
    partial class LoginPage
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.girisButton = new System.Windows.Forms.Button();
            this.isimLabel = new System.Windows.Forms.Label();
            this.isimBox = new System.Windows.Forms.TextBox();
            this.sifreBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kayitbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // girisButton
            // 
            this.girisButton.BackColor = System.Drawing.Color.SteelBlue;
            this.girisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girisButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.girisButton.Location = new System.Drawing.Point(237, 376);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(152, 55);
            this.girisButton.TabIndex = 0;
            this.girisButton.Text = "GİRİŞ YAP";
            this.girisButton.UseVisualStyleBackColor = false;
            this.girisButton.Click += new System.EventHandler(this.girisButton_Click);
            // 
            // isimLabel
            // 
            this.isimLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.isimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isimLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.isimLabel.Location = new System.Drawing.Point(85, 212);
            this.isimLabel.Name = "isimLabel";
            this.isimLabel.Size = new System.Drawing.Size(104, 30);
            this.isimLabel.TabIndex = 1;
            this.isimLabel.Text = "E-MAİL:";
            this.isimLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // isimBox
            // 
            this.isimBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isimBox.ForeColor = System.Drawing.Color.Black;
            this.isimBox.Location = new System.Drawing.Point(207, 212);
            this.isimBox.Name = "isimBox";
            this.isimBox.Size = new System.Drawing.Size(269, 30);
            this.isimBox.TabIndex = 2;
            // 
            // sifreBox
            // 
            this.sifreBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifreBox.ForeColor = System.Drawing.Color.Black;
            this.sifreBox.Location = new System.Drawing.Point(207, 297);
            this.sifreBox.Name = "sifreBox";
            this.sifreBox.Size = new System.Drawing.Size(269, 30);
            this.sifreBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(86, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "ŞİFRE:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(449, 437);
            this.label2.TabIndex = 5;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(203, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lütfen e-mail adresinizi giriniz.";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(208, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lütfen şifrenizi giriniz.";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(242, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hesabın yok mu?";
            // 
            // kayitbutton
            // 
            this.kayitbutton.BackColor = System.Drawing.Color.SteelBlue;
            this.kayitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayitbutton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.kayitbutton.Location = new System.Drawing.Point(237, 501);
            this.kayitbutton.Name = "kayitbutton";
            this.kayitbutton.Size = new System.Drawing.Size(152, 55);
            this.kayitbutton.TabIndex = 9;
            this.kayitbutton.Text = "KAYIT OL";
            this.kayitbutton.UseVisualStyleBackColor = false;
            this.kayitbutton.Click += new System.EventHandler(this.kayitbutton_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 64.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(-301, -27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1749, 328);
            this.label6.TabIndex = 10;
            this.label6.Text = "PROJECT  TRACKER";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1170, 630);
            this.Controls.Add(this.isimBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sifreBox);
            this.Controls.Add(this.kayitbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isimLabel);
            this.Controls.Add(this.girisButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Name = "LoginPage";
            this.Text = "LOGIN PAGE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button girisButton;
        private System.Windows.Forms.Label isimLabel;
        private System.Windows.Forms.TextBox isimBox;
        private System.Windows.Forms.TextBox sifreBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button kayitbutton;
        private System.Windows.Forms.Label label6;
    }
}


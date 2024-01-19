namespace vtys
{
    partial class UpdateEmployeePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateEmployeePage));
            this.geri = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // geri
            // 
            this.geri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.geri.BackColor = System.Drawing.Color.MidnightBlue;
            this.geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.geri.Location = new System.Drawing.Point(195, 342);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(160, 65);
            this.geri.TabIndex = 42;
            this.geri.Text = "GERİ";
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // guncelle
            // 
            this.guncelle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guncelle.BackColor = System.Drawing.Color.MidnightBlue;
            this.guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guncelle.Location = new System.Drawing.Point(413, 342);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(160, 65);
            this.guncelle.TabIndex = 41;
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
            this.label12.Padding = new System.Windows.Forms.Padding(50, 12, 12, 12);
            this.label12.Size = new System.Drawing.Size(300, 45);
            this.label12.TabIndex = 43;
            this.label12.Text = "ÇALIŞAN GÜNCELLE";
            // 
            // UpdateEmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.guncelle);
            this.Name = "UpdateEmployeePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UPDATE EMPLOYEE PAGE";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Label label12;
    }
}
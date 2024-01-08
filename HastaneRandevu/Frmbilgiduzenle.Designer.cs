namespace HastaneRandevu
{
    partial class Frmbilgiduzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmbilgiduzenle));
            this.btnguncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.msktel = new System.Windows.Forms.MaskedTextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnguncelle.Location = new System.Drawing.Point(179, 451);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(199, 58);
            this.btnguncelle.TabIndex = 33;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(-1, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(460, 50);
            this.label7.TabIndex = 32;
            this.label7.Text = "Hasta Bilgilerini Güncelle";
            // 
            // cmbcinsiyet
            // 
            this.cmbcinsiyet.FormattingEnabled = true;
            this.cmbcinsiyet.Location = new System.Drawing.Point(179, 391);
            this.cmbcinsiyet.Name = "cmbcinsiyet";
            this.cmbcinsiyet.Size = new System.Drawing.Size(199, 36);
            this.cmbcinsiyet.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 28);
            this.label6.TabIndex = 30;
            this.label6.Text = "Cinsiyet:";
            // 
            // msktel
            // 
            this.msktel.Location = new System.Drawing.Point(179, 265);
            this.msktel.Mask = "(999) 000-0000";
            this.msktel.Name = "msktel";
            this.msktel.Size = new System.Drawing.Size(194, 36);
            this.msktel.TabIndex = 4;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(179, 148);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(194, 36);
            this.txtsoyad.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "Soyad:";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(179, 325);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(194, 36);
            this.txtsifre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 28);
            this.label4.TabIndex = 25;
            this.label4.Text = "Sifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Telefon:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(179, 93);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(194, 36);
            this.txtad.TabIndex = 1;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(179, 209);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(194, 36);
            this.msktc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "TC Kimlik No:";
            // 
            // Frmbilgiduzenle
            // 
            this.AcceptButton = this.btnguncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(471, 556);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbcinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.msktel);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Frmbilgiduzenle";
            this.Text = "Bilgileri Güncelle";
            this.Load += new System.EventHandler(this.Frmbilgiduzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbcinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox msktel;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
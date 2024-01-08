namespace HastaneRandevu
{
    partial class Frmdoktorbilgiduzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmdoktorbilgiduzenle));
            this.btnguncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnguncelle.Location = new System.Drawing.Point(166, 401);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(199, 58);
            this.btnguncelle.TabIndex = 47;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(27, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(449, 50);
            this.label7.TabIndex = 46;
            this.label7.Text = "Doktor Bilgi Güncelleme";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(166, 163);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(194, 36);
            this.txtsoyad.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 28);
            this.label5.TabIndex = 41;
            this.label5.Text = "Soyad:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(166, 108);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(194, 36);
            this.txtad.TabIndex = 37;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(166, 224);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(194, 36);
            this.msktc.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 28);
            this.label3.TabIndex = 35;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 28);
            this.label2.TabIndex = 34;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 28);
            this.label4.TabIndex = 39;
            this.label4.Text = "Sifre:";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(166, 340);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(194, 36);
            this.txtsifre.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 28);
            this.label1.TabIndex = 48;
            this.label1.Text = "Branş:";
            // 
            // cmbbrans
            // 
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(166, 282);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(194, 36);
            this.cmbbrans.TabIndex = 49;
            // 
            // Frmdoktorbilgiduzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(490, 522);
            this.Controls.Add(this.cmbbrans);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Frmdoktorbilgiduzenle";
            this.Text = "Doktor Bilgi Düzenle";
            this.Load += new System.EventHandler(this.Frmdoktorbilgiduzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbrans;
    }
}
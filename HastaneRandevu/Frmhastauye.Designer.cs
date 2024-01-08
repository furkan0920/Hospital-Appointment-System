namespace HastaneRandevu
{
    partial class Frmhastauye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmhastauye));
            this.txtad = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.msktel = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnkayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(155, 79);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(194, 36);
            this.txtad.TabIndex = 1;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(155, 195);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(194, 36);
            this.msktc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Telefon:";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(155, 311);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(194, 36);
            this.txtsifre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sifre:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(155, 134);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(194, 36);
            this.txtsoyad.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "Soyad:";
            // 
            // msktel
            // 
            this.msktel.Location = new System.Drawing.Point(155, 251);
            this.msktel.Mask = "(999) 000-0000";
            this.msktel.Name = "msktel";
            this.msktel.Size = new System.Drawing.Size(194, 36);
            this.msktel.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 28);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cinsiyet:";
            // 
            // cmbcinsiyet
            // 
            this.cmbcinsiyet.FormattingEnabled = true;
            this.cmbcinsiyet.Location = new System.Drawing.Point(155, 377);
            this.cmbcinsiyet.Name = "cmbcinsiyet";
            this.cmbcinsiyet.Size = new System.Drawing.Size(199, 36);
            this.cmbcinsiyet.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(1, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(336, 50);
            this.label7.TabIndex = 18;
            this.label7.Text = "Hasta Kayit Paneli";
            // 
            // btnkayit
            // 
            this.btnkayit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnkayit.Location = new System.Drawing.Point(155, 437);
            this.btnkayit.Name = "btnkayit";
            this.btnkayit.Size = new System.Drawing.Size(199, 58);
            this.btnkayit.TabIndex = 7;
            this.btnkayit.Text = "Kayit Yap";
            this.btnkayit.UseVisualStyleBackColor = false;
            this.btnkayit.Click += new System.EventHandler(this.btnkayit_Click);
            // 
            // Frmhastauye
            // 
            this.AcceptButton = this.btnkayit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(445, 535);
            this.Controls.Add(this.btnkayit);
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
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "Frmhastauye";
            this.Text = "Hasta Kayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox msktel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbcinsiyet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnkayit;
    }
}
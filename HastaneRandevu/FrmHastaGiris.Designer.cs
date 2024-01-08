namespace HastaneRandevu
{
    partial class FrmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.linkuye = new System.Windows.Forms.LinkLabel();
            this.btngirisyap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai Medium", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giris Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sifre:";
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(176, 89);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(194, 36);
            this.msktc.TabIndex = 3;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(176, 153);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(194, 36);
            this.txtsifre.TabIndex = 4;
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // linkuye
            // 
            this.linkuye.AutoSize = true;
            this.linkuye.Location = new System.Drawing.Point(414, 215);
            this.linkuye.Name = "linkuye";
            this.linkuye.Size = new System.Drawing.Size(75, 28);
            this.linkuye.TabIndex = 6;
            this.linkuye.TabStop = true;
            this.linkuye.Text = "Uye Ol";
            this.linkuye.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkuye_LinkClicked);
            // 
            // btngirisyap
            // 
            this.btngirisyap.Location = new System.Drawing.Point(239, 195);
            this.btngirisyap.Name = "btngirisyap";
            this.btngirisyap.Size = new System.Drawing.Size(131, 56);
            this.btngirisyap.TabIndex = 5;
            this.btngirisyap.Text = "Giris Yap";
            this.btngirisyap.UseVisualStyleBackColor = true;
            this.btngirisyap.Click += new System.EventHandler(this.btngirisyap_Click);
            // 
            // FrmHastaGiris
            // 
            this.AcceptButton = this.btngirisyap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(532, 298);
            this.Controls.Add(this.btngirisyap);
            this.Controls.Add(this.linkuye);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaGiris";
            this.Text = "Hasta  Giris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.LinkLabel linkuye;
        private System.Windows.Forms.Button btngirisyap;
    }
}
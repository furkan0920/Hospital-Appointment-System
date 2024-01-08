namespace HastaneRandevu
{
    partial class Frmdoktorpaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmdoktorpaneli));
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbbrans
            // 
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(105, 257);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(194, 36);
            this.cmbbrans.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 28);
            this.label1.TabIndex = 58;
            this.label1.Text = "Branş:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(105, 138);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(194, 36);
            this.txtsoyad.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 28);
            this.label5.TabIndex = 56;
            this.label5.Text = "Soyad:";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(105, 315);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(194, 36);
            this.txtsifre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 28);
            this.label4.TabIndex = 54;
            this.label4.Text = "Sifre:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(105, 83);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(194, 36);
            this.txtad.TabIndex = 1;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(105, 199);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(194, 36);
            this.msktc.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 28);
            this.label6.TabIndex = 51;
            this.label6.Text = "Ad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 28);
            this.label7.TabIndex = 50;
            this.label7.Text = "TC :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(365, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(502, 395);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.SeaGreen;
            this.btnekle.Location = new System.Drawing.Point(105, 378);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(96, 50);
            this.btnekle.TabIndex = 6;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Orange;
            this.btnsil.Location = new System.Drawing.Point(222, 378);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(96, 50);
            this.btnsil.TabIndex = 7;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.DarkGreen;
            this.btnguncelle.Location = new System.Drawing.Point(130, 434);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(153, 53);
            this.btnguncelle.TabIndex = 8;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // Frmdoktorpaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(913, 526);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbbrans);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Frmdoktorpaneli";
            this.Text = "Doktor Paneli";
            this.Load += new System.EventHandler(this.Frmdoktorpaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbbrans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
    }
}
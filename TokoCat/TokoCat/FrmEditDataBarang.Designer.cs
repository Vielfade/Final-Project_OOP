namespace TokoCat
{
    partial class FrmEditDataBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditDataBarang));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cboSatuan = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Harga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Satuan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Stok";
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(110, 40);
            this.txtKode.Name = "txtKode";
            this.txtKode.ReadOnly = true;
            this.txtKode.Size = new System.Drawing.Size(154, 22);
            this.txtKode.TabIndex = 6;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(110, 80);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(154, 22);
            this.txtNama.TabIndex = 7;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(110, 120);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(154, 22);
            this.txtHarga.TabIndex = 9;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(110, 200);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(55, 22);
            this.txtStok.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboSatuan
            // 
            this.cboSatuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSatuan.FormattingEnabled = true;
            this.cboSatuan.Items.AddRange(new object[] {
            "pcs",
            "klg",
            "ember",
            "meter"});
            this.cboSatuan.Location = new System.Drawing.Point(110, 160);
            this.cboSatuan.Name = "cboSatuan";
            this.cboSatuan.Size = new System.Drawing.Size(70, 24);
            this.cboSatuan.TabIndex = 14;
            // 
            // FrmEditDataBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(422, 303);
            this.Controls.Add(this.cboSatuan);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditDataBarang";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.FrmEditDataBarang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cboSatuan;
    }
}
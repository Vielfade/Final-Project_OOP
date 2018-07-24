namespace FinalProjectPhase1
{
    partial class Faktur_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Faktur_Page));
            this.faktur_label = new System.Windows.Forms.Label();
            this.Faktur_kode_label = new System.Windows.Forms.Label();
            this.Label_barang = new System.Windows.Forms.Label();
            this.Label_tanggal = new System.Windows.Forms.Label();
            this.No_faktur_tb = new System.Windows.Forms.TextBox();
            this.Tanggal_tb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Confirm_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // faktur_label
            // 
            this.faktur_label.AutoSize = true;
            this.faktur_label.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faktur_label.ForeColor = System.Drawing.Color.Red;
            this.faktur_label.Location = new System.Drawing.Point(16, 11);
            this.faktur_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.faktur_label.Name = "faktur_label";
            this.faktur_label.Size = new System.Drawing.Size(151, 55);
            this.faktur_label.TabIndex = 0;
            this.faktur_label.Text = "Faktur";
            // 
            // Faktur_kode_label
            // 
            this.Faktur_kode_label.AutoSize = true;
            this.Faktur_kode_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Faktur_kode_label.Location = new System.Drawing.Point(112, 78);
            this.Faktur_kode_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Faktur_kode_label.Name = "Faktur_kode_label";
            this.Faktur_kode_label.Size = new System.Drawing.Size(112, 25);
            this.Faktur_kode_label.TabIndex = 1;
            this.Faktur_kode_label.Text = "No. Faktur";
            // 
            // Label_barang
            // 
            this.Label_barang.AutoSize = true;
            this.Label_barang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_barang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_barang.Location = new System.Drawing.Point(101, 169);
            this.Label_barang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_barang.Name = "Label_barang";
            this.Label_barang.Size = new System.Drawing.Size(121, 25);
            this.Label_barang.TabIndex = 2;
            this.Label_barang.Text = "List Barang";
            // 
            // Label_tanggal
            // 
            this.Label_tanggal.AutoSize = true;
            this.Label_tanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_tanggal.Location = new System.Drawing.Point(21, 127);
            this.Label_tanggal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_tanggal.Name = "Label_tanggal";
            this.Label_tanggal.Size = new System.Drawing.Size(198, 25);
            this.Label_tanggal.TabIndex = 3;
            this.Label_tanggal.Text = "Tanggal Pembelian";
            // 
            // No_faktur_tb
            // 
            this.No_faktur_tb.Location = new System.Drawing.Point(291, 78);
            this.No_faktur_tb.Margin = new System.Windows.Forms.Padding(4);
            this.No_faktur_tb.Name = "No_faktur_tb";
            this.No_faktur_tb.Size = new System.Drawing.Size(221, 22);
            this.No_faktur_tb.TabIndex = 4;
            // 
            // Tanggal_tb
            // 
            this.Tanggal_tb.Location = new System.Drawing.Point(291, 127);
            this.Tanggal_tb.Margin = new System.Windows.Forms.Padding(4);
            this.Tanggal_tb.Name = "Tanggal_tb";
            this.Tanggal_tb.Size = new System.Drawing.Size(221, 22);
            this.Tanggal_tb.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(291, 169);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(570, 311);
            this.dataGridView1.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nomor Faktur";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nama Barang";
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Keterangan";
            this.Column5.Name = "Column5";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Jumlah Barang";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Harga";
            this.Column4.Name = "Column4";
            // 
            // Confirm_button
            // 
            this.Confirm_button.Location = new System.Drawing.Point(291, 511);
            this.Confirm_button.Margin = new System.Windows.Forms.Padding(4);
            this.Confirm_button.Name = "Confirm_button";
            this.Confirm_button.Size = new System.Drawing.Size(100, 28);
            this.Confirm_button.TabIndex = 7;
            this.Confirm_button.Text = "Confirm";
            this.Confirm_button.UseVisualStyleBackColor = true;
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(621, 511);
            this.Cancel_button.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(100, 28);
            this.Cancel_button.TabIndex = 8;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TokoCat.Properties.Resources._174976751_612x612;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(869, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Faktur_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Confirm_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Tanggal_tb);
            this.Controls.Add(this.No_faktur_tb);
            this.Controls.Add(this.Label_tanggal);
            this.Controls.Add(this.Label_barang);
            this.Controls.Add(this.Faktur_kode_label);
            this.Controls.Add(this.faktur_label);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Faktur_Page";
            this.Text = "Faktur Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label faktur_label;
        private System.Windows.Forms.Label Faktur_kode_label;
        private System.Windows.Forms.Label Label_barang;
        private System.Windows.Forms.Label Label_tanggal;
        private System.Windows.Forms.TextBox No_faktur_tb;
        private System.Windows.Forms.TextBox Tanggal_tb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Confirm_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
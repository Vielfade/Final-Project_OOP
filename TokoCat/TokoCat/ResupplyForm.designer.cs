namespace TokoCat
{
    partial class ResupplyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResupplyForm));
            this.Resupply_form = new System.Windows.Forms.Label();
            this.Nama_Barang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_harga = new System.Windows.Forms.TextBox();
            this.cbox_kode = new System.Windows.Forms.ComboBox();
            this.btn_pesan = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.btn_kurang = new System.Windows.Forms.Button();
            this.txtbox_jumlah = new System.Windows.Forms.TextBox();
            this.btn_list = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txtbox_nama = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Resupply_form
            // 
            this.Resupply_form.AutoSize = true;
            this.Resupply_form.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resupply_form.Location = new System.Drawing.Point(12, 9);
            this.Resupply_form.Name = "Resupply_form";
            this.Resupply_form.Size = new System.Drawing.Size(152, 45);
            this.Resupply_form.TabIndex = 0;
            this.Resupply_form.Text = "Resupply";
            // 
            // Nama_Barang
            // 
            this.Nama_Barang.AutoSize = true;
            this.Nama_Barang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nama_Barang.Location = new System.Drawing.Point(16, 129);
            this.Nama_Barang.Name = "Nama_Barang";
            this.Nama_Barang.Size = new System.Drawing.Size(136, 24);
            this.Nama_Barang.TabIndex = 1;
            this.Nama_Barang.Text = "Nama Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jumlah";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Harga";
            // 
            // txtbox_harga
            // 
            this.txtbox_harga.Location = new System.Drawing.Point(204, 234);
            this.txtbox_harga.Name = "txtbox_harga";
            this.txtbox_harga.ReadOnly = true;
            this.txtbox_harga.Size = new System.Drawing.Size(204, 20);
            this.txtbox_harga.TabIndex = 5;
            this.txtbox_harga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbox_kode
            // 
            this.cbox_kode.FormattingEnabled = true;
            this.cbox_kode.Location = new System.Drawing.Point(204, 82);
            this.cbox_kode.Name = "cbox_kode";
            this.cbox_kode.Size = new System.Drawing.Size(204, 21);
            this.cbox_kode.TabIndex = 8;
            this.cbox_kode.SelectedIndexChanged += new System.EventHandler(this.cbox_kode_SelectedIndexChanged);
            // 
            // btn_pesan
            // 
            this.btn_pesan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesan.Location = new System.Drawing.Point(1014, 77);
            this.btn_pesan.Name = "btn_pesan";
            this.btn_pesan.Size = new System.Drawing.Size(115, 37);
            this.btn_pesan.TabIndex = 9;
            this.btn_pesan.Text = "Pesan";
            this.btn_pesan.UseVisualStyleBackColor = true;
            this.btn_pesan.Click += new System.EventHandler(this.btn_pesan_Click);
            // 
            // btn_tambah
            // 
            this.btn_tambah.Location = new System.Drawing.Point(272, 187);
            this.btn_tambah.Margin = new System.Windows.Forms.Padding(2);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(24, 19);
            this.btn_tambah.TabIndex = 11;
            this.btn_tambah.Text = "+";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // btn_kurang
            // 
            this.btn_kurang.Location = new System.Drawing.Point(204, 186);
            this.btn_kurang.Margin = new System.Windows.Forms.Padding(2);
            this.btn_kurang.Name = "btn_kurang";
            this.btn_kurang.Size = new System.Drawing.Size(24, 19);
            this.btn_kurang.TabIndex = 12;
            this.btn_kurang.Text = "-";
            this.btn_kurang.UseVisualStyleBackColor = true;
            this.btn_kurang.Click += new System.EventHandler(this.btn_kurang_Click);
            // 
            // txtbox_jumlah
            // 
            this.txtbox_jumlah.Location = new System.Drawing.Point(232, 187);
            this.txtbox_jumlah.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_jumlah.Name = "txtbox_jumlah";
            this.txtbox_jumlah.Size = new System.Drawing.Size(36, 20);
            this.txtbox_jumlah.TabIndex = 13;
            this.txtbox_jumlah.Text = "0";
            this.txtbox_jumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbox_jumlah.TextChanged += new System.EventHandler(this.txtbox_jumlah_TextChanged);
            this.txtbox_jumlah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_jumlah_KeyPress);
            // 
            // btn_list
            // 
            this.btn_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_list.Location = new System.Drawing.Point(1014, 181);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(115, 57);
            this.btn_list.TabIndex = 14;
            this.btn_list.Text = "List Barang";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kode,
            this.Nama,
            this.Jumlah,
            this.Harga});
            this.dataGridView1.Location = new System.Drawing.Point(427, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(570, 275);
            this.dataGridView1.TabIndex = 15;
            // 
            // Kode
            // 
            this.Kode.HeaderText = "Kode";
            this.Kode.Name = "Kode";
            this.Kode.ReadOnly = true;
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama";
            this.Nama.Name = "Nama";
            this.Nama.ReadOnly = true;
            // 
            // Jumlah
            // 
            this.Jumlah.HeaderText = "Jumlah";
            this.Jumlah.Name = "Jumlah";
            this.Jumlah.ReadOnly = true;
            // 
            // Harga
            // 
            this.Harga.HeaderText = "Harga";
            this.Harga.Name = "Harga";
            this.Harga.ReadOnly = true;
            // 
            // btn_hapus
            // 
            this.btn_hapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_hapus.Location = new System.Drawing.Point(1014, 129);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(115, 37);
            this.btn_hapus.TabIndex = 16;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(1014, 315);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(115, 37);
            this.btn_ok.TabIndex = 17;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(1014, 255);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(115, 37);
            this.btn_cancel.TabIndex = 18;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txtbox_nama
            // 
            this.txtbox_nama.Location = new System.Drawing.Point(204, 134);
            this.txtbox_nama.Name = "txtbox_nama";
            this.txtbox_nama.ReadOnly = true;
            this.txtbox_nama.Size = new System.Drawing.Size(204, 20);
            this.txtbox_nama.TabIndex = 19;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(204, 271);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(204, 20);
            this.txtSubTotal.TabIndex = 21;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sub Total";
            // 
            // ResupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1143, 371);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbox_nama);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.txtbox_jumlah);
            this.Controls.Add(this.btn_kurang);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.btn_pesan);
            this.Controls.Add(this.cbox_kode);
            this.Controls.Add(this.txtbox_harga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nama_Barang);
            this.Controls.Add(this.Resupply_form);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ResupplyForm";
            this.Text = "Resupply Form";
            this.Load += new System.EventHandler(this.ResupplyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Resupply_form;
        private System.Windows.Forms.Label Nama_Barang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_harga;
        private System.Windows.Forms.ComboBox cbox_kode;
        private System.Windows.Forms.Button btn_pesan;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Button btn_kurang;
        private System.Windows.Forms.TextBox txtbox_jumlah;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txtbox_nama;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label4;
    }
}
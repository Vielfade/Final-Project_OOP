namespace TokoCat
{
    partial class MainPetugas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPetugas));
            this.Petugas_Label = new System.Windows.Forms.Label();
            this.Search_Label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lblBanyakRecordData = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Satuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Petugas_Label
            // 
            this.Petugas_Label.AutoSize = true;
            this.Petugas_Label.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Petugas_Label.Location = new System.Drawing.Point(16, 11);
            this.Petugas_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Petugas_Label.Name = "Petugas_Label";
            this.Petugas_Label.Size = new System.Drawing.Size(169, 55);
            this.Petugas_Label.TabIndex = 0;
            this.Petugas_Label.Text = "Petugas";
            // 
            // Search_Label
            // 
            this.Search_Label.AutoSize = true;
            this.Search_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Label.Location = new System.Drawing.Point(27, 95);
            this.Search_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Search_Label.Name = "Search_Label";
            this.Search_Label.Size = new System.Drawing.Size(95, 29);
            this.Search_Label.TabIndex = 1;
            this.Search_Label.Text = "Search";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(908, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 70);
            this.button1.TabIndex = 5;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(908, 211);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 70);
            this.button2.TabIndex = 6;
            this.button2.Text = "Faktur";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(911, 367);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 70);
            this.button4.TabIndex = 8;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Button5
            // 
            this.Button5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.Location = new System.Drawing.Point(908, 289);
            this.Button5.Margin = new System.Windows.Forms.Padding(4);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(143, 70);
            this.Button5.TabIndex = 9;
            this.Button5.Text = "Hapus";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(908, 133);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(143, 70);
            this.button6.TabIndex = 10;
            this.button6.Text = "Resupply";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lblBanyakRecordData
            // 
            this.lblBanyakRecordData.AutoSize = true;
            this.lblBanyakRecordData.Location = new System.Drawing.Point(13, 153);
            this.lblBanyakRecordData.Name = "lblBanyakRecordData";
            this.lblBanyakRecordData.Size = new System.Drawing.Size(62, 17);
            this.lblBanyakRecordData.TabIndex = 11;
            this.lblBanyakRecordData.Text = "[Record]";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kode,
            this.Nama,
            this.Harga,
            this.Satuan,
            this.Stok});
            this.dataGridView1.Location = new System.Drawing.Point(16, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(748, 217);
            this.dataGridView1.TabIndex = 12;
            // 
            // Kode
            // 
            this.Kode.HeaderText = "Kode";
            this.Kode.Name = "Kode";
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama";
            this.Nama.Name = "Nama";
            // 
            // Harga
            // 
            this.Harga.HeaderText = "Harga";
            this.Harga.Name = "Harga";
            // 
            // Satuan
            // 
            this.Satuan.HeaderText = "Satuan";
            this.Satuan.Name = "Satuan";
            // 
            // Stok
            // 
            this.Stok.HeaderText = "Stok";
            this.Stok.Name = "Stok";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(321, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 22);
            this.textBox1.TabIndex = 13;
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // MainPetugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 470);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblBanyakRecordData);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Search_Label);
            this.Controls.Add(this.Petugas_Label);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainPetugas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Petugas";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.MainPetugas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Petugas_Label;
        private System.Windows.Forms.Label Search_Label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblBanyakRecordData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Satuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stok;
    }
}


namespace TokoCat
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_main = new System.Windows.Forms.Label();
            this.btn_sign = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_ttlharga = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvMainMenu = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBnykRecord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBarang = new System.Windows.Forms.ComboBox();
            this.barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBPenjualanCATDataSet = new TokoCat.DBPenjualanCATDataSet();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnKurang = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKuantitas = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNoFaktur = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFaktur = new System.Windows.Forms.DateTimePicker();
            this.Column_nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPenjualanCATDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(173, 524);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 52);
            this.button1.TabIndex = 17;
            this.button1.Text = "&Bayar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_main
            // 
            this.lbl_main.AutoSize = true;
            this.lbl_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_main.Location = new System.Drawing.Point(447, 15);
            this.lbl_main.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_main.Name = "lbl_main";
            this.lbl_main.Size = new System.Drawing.Size(213, 39);
            this.lbl_main.TabIndex = 16;
            this.lbl_main.Text = "MAIN MENU";
            // 
            // btn_sign
            // 
            this.btn_sign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sign.Location = new System.Drawing.Point(976, 15);
            this.btn_sign.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sign.Name = "btn_sign";
            this.btn_sign.Size = new System.Drawing.Size(100, 28);
            this.btn_sign.TabIndex = 15;
            this.btn_sign.Text = "&Sign in";
            this.btn_sign.UseVisualStyleBackColor = true;
            this.btn_sign.Click += new System.EventHandler(this.btn_sign_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.Location = new System.Drawing.Point(454, 88);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 28);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "&Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_ttlharga
            // 
            this.lbl_ttlharga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ttlharga.AutoSize = true;
            this.lbl_ttlharga.Location = new System.Drawing.Point(841, 548);
            this.lbl_ttlharga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ttlharga.Name = "lbl_ttlharga";
            this.lbl_ttlharga.Size = new System.Drawing.Size(115, 17);
            this.lbl_ttlharga.TabIndex = 12;
            this.lbl_ttlharga.Text = "Total harga : Rp ";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(19, 124);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(136, 214);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "List barang :\r\n- Alat pengikis\r\n- Amplas\r\n- Cat cair\r\n- Kuas\r\n- Pillox\r\n- Spray g" +
    "un\r\n- Roller\r\n- Tempat Roller\r\n- Thinner";
            // 
            // dgvMainMenu
            // 
            this.dgvMainMenu.AllowUserToAddRows = false;
            this.dgvMainMenu.AllowUserToDeleteRows = false;
            this.dgvMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMainMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_nama,
            this.Column_quantity,
            this.Column1,
            this.Column2});
            this.dgvMainMenu.Location = new System.Drawing.Point(454, 124);
            this.dgvMainMenu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMainMenu.Name = "dgvMainMenu";
            this.dgvMainMenu.Size = new System.Drawing.Size(622, 416);
            this.dgvMainMenu.TabIndex = 10;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Location = new System.Drawing.Point(173, 121);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 28);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "&Add barang";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1060, 548);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBnykRecord
            // 
            this.lblBnykRecord.AutoSize = true;
            this.lblBnykRecord.Location = new System.Drawing.Point(951, 103);
            this.lblBnykRecord.Name = "lblBnykRecord";
            this.lblBnykRecord.Size = new System.Drawing.Size(125, 17);
            this.lblBnykRecord.TabIndex = 19;
            this.lblBnykRecord.Text = "{bnyk record data}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(169, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Pilih barang";
            // 
            // cbBarang
            // 
            this.cbBarang.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.barangBindingSource, "Nama", true));
            this.cbBarang.DataSource = this.barangBindingSource;
            this.cbBarang.DisplayMember = "Nama";
            this.cbBarang.FormattingEnabled = true;
            this.cbBarang.Location = new System.Drawing.Point(173, 208);
            this.cbBarang.Name = "cbBarang";
            this.cbBarang.Size = new System.Drawing.Size(247, 24);
            this.cbBarang.TabIndex = 23;
            this.cbBarang.ValueMember = "Nama";
            // 
            // barangBindingSource
            // 
            this.barangBindingSource.DataMember = "Barang";
            this.barangBindingSource.DataSource = this.dBPenjualanCATDataSet;
            // 
            // dBPenjualanCATDataSet
            // 
            this.dBPenjualanCATDataSet.DataSetName = "DBPenjualanCATDataSet";
            this.dBPenjualanCATDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(257, 291);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(27, 23);
            this.btnTambah.TabIndex = 28;
            this.btnTambah.Text = "+";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnKurang
            // 
            this.btnKurang.Location = new System.Drawing.Point(173, 291);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.Size = new System.Drawing.Size(27, 23);
            this.btnKurang.TabIndex = 27;
            this.btnKurang.Text = "-";
            this.btnKurang.UseVisualStyleBackColor = true;
            this.btnKurang.Click += new System.EventHandler(this.btnKurang_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(169, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Jumlah Barang";
            // 
            // txtKuantitas
            // 
            this.txtKuantitas.Location = new System.Drawing.Point(206, 290);
            this.txtKuantitas.Name = "txtKuantitas";
            this.txtKuantitas.Size = new System.Drawing.Size(45, 22);
            this.txtKuantitas.TabIndex = 25;
            this.txtKuantitas.Text = "0";
            this.txtKuantitas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(173, 364);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.ReadOnly = true;
            this.txtHarga.Size = new System.Drawing.Size(172, 22);
            this.txtHarga.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(169, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Harga";
            // 
            // btnBatal
            // 
            this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.Location = new System.Drawing.Point(309, 524);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(4);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(100, 52);
            this.btnBatal.TabIndex = 31;
            this.btnBatal.Text = "&Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "No Faktur";
            // 
            // txtNoFaktur
            // 
            this.txtNoFaktur.Location = new System.Drawing.Point(99, 13);
            this.txtNoFaktur.Name = "txtNoFaktur";
            this.txtNoFaktur.ReadOnly = true;
            this.txtNoFaktur.Size = new System.Drawing.Size(200, 22);
            this.txtNoFaktur.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Tanggal";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(173, 432);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(172, 22);
            this.txtSubTotal.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(169, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 24);
            this.label7.TabIndex = 35;
            this.label7.Text = "Sub Total";
            // 
            // dtpFaktur
            // 
            this.dtpFaktur.Location = new System.Drawing.Point(99, 66);
            this.dtpFaktur.Name = "dtpFaktur";
            this.dtpFaktur.Size = new System.Drawing.Size(200, 22);
            this.dtpFaktur.TabIndex = 37;
            // 
            // Column_nama
            // 
            this.Column_nama.HeaderText = "Nama Barang";
            this.Column_nama.Name = "Column_nama";
            this.Column_nama.ReadOnly = true;
            // 
            // Column_quantity
            // 
            this.Column_quantity.HeaderText = "Jumlah barang";
            this.Column_quantity.Name = "Column_quantity";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Harga";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "SubTotal";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 583);
            this.Controls.Add(this.dtpFaktur);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNoFaktur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnKurang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKuantitas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBarang);
            this.Controls.Add(this.lblBnykRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_main);
            this.Controls.Add(this.btn_sign);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.lbl_ttlharga);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvMainMenu);
            this.Controls.Add(this.btn_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPenjualanCATDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_main;
        private System.Windows.Forms.Button btn_sign;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_ttlharga;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvMainMenu;
        private System.Windows.Forms.Label lblBnykRecord;
        private System.Windows.Forms.BindingSource barangBindingSource;
        private DBPenjualanCATDataSet dBPenjualanCATDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBarang;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnKurang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKuantitas;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNoFaktur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DateTimePicker dtpFaktur;
    }
}
namespace TokoCat
{
    partial class FrmTambahPenjualan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTambahPenjualan));
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbKeterangan = new System.Windows.Forms.ComboBox();
            this.barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBPenjualanCATDataSet = new TokoCat.DBPenjualanCATDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.barangTableAdapter = new TokoCat.DBPenjualanCATDataSetTableAdapters.BarangTableAdapter();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBarang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPenjualanCATDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(312, 241);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 21;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(204, 241);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbKeterangan
            // 
            this.cbKeterangan.FormattingEnabled = true;
            this.cbKeterangan.Location = new System.Drawing.Point(435, 241);
            this.cbKeterangan.Name = "cbKeterangan";
            this.cbKeterangan.Size = new System.Drawing.Size(121, 24);
            this.cbKeterangan.TabIndex = 14;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Beli Barang";
            // 
            // barangTableAdapter
            // 
            this.barangTableAdapter.ClearBeforeFill = true;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(448, 132);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(172, 22);
            this.txtHarga.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(444, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Harga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(290, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Jumlah Barang";
            // 
            // cbBarang
            // 
            this.cbBarang.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.barangBindingSource, "Nama", true));
            this.cbBarang.FormattingEnabled = true;
            this.cbBarang.Location = new System.Drawing.Point(12, 131);
            this.cbBarang.Name = "cbBarang";
            this.cbBarang.Size = new System.Drawing.Size(247, 24);
            this.cbBarang.TabIndex = 12;
            this.cbBarang.SelectedIndexChanged += new System.EventHandler(this.cbBarang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(8, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pilih barang";
            // 
            // FrmTambahPenjualan
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 349);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbKeterangan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBarang);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmTambahPenjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pembelian Barang";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.FrmTambahPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPenjualanCATDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cbKeterangan;
        private System.Windows.Forms.Label label1;
        private DBPenjualanCATDataSet dBPenjualanCATDataSet;
        private System.Windows.Forms.BindingSource barangBindingSource;
        private DBPenjualanCATDataSetTableAdapters.BarangTableAdapter barangTableAdapter;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBarang;
        private System.Windows.Forms.Label label2;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_main = new System.Windows.Forms.Label();
            this.btn_sign = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.lbl_ttlharga = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.Colum_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Keterangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.Location = new System.Drawing.Point(173, 548);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "&Bayar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_main
            // 
            this.lbl_main.AutoSize = true;
            this.lbl_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_main.Location = new System.Drawing.Point(419, 2);
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
            this.btn_delete.Location = new System.Drawing.Point(409, 87);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 28);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "&Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.Location = new System.Drawing.Point(281, 87);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(120, 28);
            this.btn_edit.TabIndex = 13;
            this.btn_edit.Text = "&Edit kuantitas";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // lbl_ttlharga
            // 
            this.lbl_ttlharga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ttlharga.AutoSize = true;
            this.lbl_ttlharga.Location = new System.Drawing.Point(933, 544);
            this.lbl_ttlharga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ttlharga.Name = "lbl_ttlharga";
            this.lbl_ttlharga.Size = new System.Drawing.Size(124, 17);
            this.lbl_ttlharga.TabIndex = 12;
            this.lbl_ttlharga.Text = "Total harga : Rp. -";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(19, 87);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(136, 214);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "List barang :\r\n- Alat pengikis\r\n- Amplas\r\n- Cat cair\r\n- Kuas\r\n- Pillox\r\n- Spray g" +
    "un\r\n- Roller\r\n- Tempat Roller\r\n- Thinner";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colum_no,
            this.Column_nama,
            this.Column_Keterangan,
            this.Column_quantity,
            this.Column_harga});
            this.dataGridView1.Location = new System.Drawing.Point(173, 124);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(903, 416);
            this.dataGridView1.TabIndex = 10;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Location = new System.Drawing.Point(173, 87);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 28);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "&Add barang";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // Colum_no
            // 
            this.Colum_no.HeaderText = "No";
            this.Colum_no.Name = "Colum_no";
            this.Colum_no.ReadOnly = true;
            // 
            // Column_nama
            // 
            this.Column_nama.HeaderText = "Nama Barang";
            this.Column_nama.Name = "Column_nama";
            this.Column_nama.ReadOnly = true;
            // 
            // Column_Keterangan
            // 
            this.Column_Keterangan.HeaderText = "Keterangan";
            this.Column_Keterangan.Name = "Column_Keterangan";
            this.Column_Keterangan.ReadOnly = true;
            // 
            // Column_quantity
            // 
            this.Column_quantity.HeaderText = "Jumlah barang";
            this.Column_quantity.Name = "Column_quantity";
            // 
            // Column_harga
            // 
            this.Column_harga.HeaderText = "Harga";
            this.Column_harga.Name = "Column_harga";
            this.Column_harga.ReadOnly = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 583);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_main);
            this.Controls.Add(this.btn_sign);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.lbl_ttlharga);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_main;
        private System.Windows.Forms.Button btn_sign;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label lbl_ttlharga;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colum_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Keterangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_harga;
    }
}
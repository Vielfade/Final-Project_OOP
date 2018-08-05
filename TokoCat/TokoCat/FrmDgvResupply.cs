using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryPenjualan;

namespace TokoCat
{
    public partial class FrmDgvResupply : Form
    {
        public FrmDgvResupply()
        {
            InitializeComponent();
            this.dgvData.AutoGenerateColumns = false;
            this.FrmDgvResupply_Resize(null, null);
        }

        Barang _result = null;

        public Barang Run(FrmDgvResupply form)
        {
            form.ShowDialog();
            return _result;
        }

        private void FrmDgvResupply_Load(object sender, EventArgs e)
        {
            try
            {
                using (var dao = new BarangDAO())
                {
                    this.dgvData.DataSource = dao.GetAllDataBarang();
                    this.dgvData.Columns[0].DataPropertyName = "kode";
                    this.dgvData.Columns[1].DataPropertyName = "nama";
                    this.dgvData.Columns[2].DataPropertyName = "harga";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmDgvResupply_Resize(object sender, EventArgs e)
        {
            this.dgvData.Columns[0].Width = 20 * this.dgvData.Width / 100;
            this.dgvData.Columns[1].Width = 40 * this.dgvData.Width / 100;
            this.dgvData.Columns[2].Width = 32 * this.dgvData.Width / 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (this.dgvData.SelectedRows.Count > 0)
            {
                var row = this.dgvData.SelectedRows[0];
                _result = new Barang { Kode = row.Cells[0].Value.ToString(), Nama = row.Cells[1].Value.ToString(), Harga = row.Cells[2].Value.ToString() };
                this.Close();
            }
        }
    }
}

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
    public partial class MainPetugas : Form
    {
        public MainPetugas()
        {
            InitializeComponent();
            this.lblBanyakRecordData.Text = string.Empty;
            this.dataGridView1.AutoGenerateColumns = false;
            this.MainPetugas_Resize(null, null);
        }

        private void MainPetugas_Resize(object sender, EventArgs e)
        {
            this.dataGridView1.Columns[0].Width = 10 * this.dataGridView1.Width / 100;
            this.dataGridView1.Columns[1].Width = 20 * this.dataGridView1.Width / 100;
            this.dataGridView1.Columns[2].Width = 20 * this.dataGridView1.Width / 100;
            this.dataGridView1.Columns[3].Width = 15 * this.dataGridView1.Width / 100;
            this.dataGridView1.Columns[4].Width = 10 * this.dataGridView1.Width / 100;
            this.dataGridView1.Columns[5].Width = 10 * this.dataGridView1.Width / 100;
        }

        private void MainPetugas_Load(object sender, EventArgs e)
        {
            try
            {
                QueryData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void QueryData(Barang barang = null)
        {
            List<Barang> listData = null;
            try
            {
                this.dataGridView1.DataSource = null;
                listData = new BarangDAO().QueryDataBarang(barang);
                if (listData != null)
                {
                    this.dataGridView1.DataSource = listData;
                    this.dataGridView1.Columns[0].DataPropertyName = nameof(Barang.Kode);
                    this.dataGridView1.Columns[1].DataPropertyName = nameof(Barang.Nama);
                    this.dataGridView1.Columns[2].DataPropertyName = nameof(Barang.Keterangan);
                    this.dataGridView1.Columns[3].DataPropertyName = nameof(Barang.Harga);
                    this.dataGridView1.Columns[4].DataPropertyName = nameof(Barang.Satuan);
                    this.dataGridView1.Columns[5].DataPropertyName = nameof(Barang.Stok);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                this.lblBanyakRecordData.Text = $"{(listData != null ? listData.Count.ToString("n0") : "0")} Record";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

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
        List<string> kolom = new List<string>();
        List<Barang> listData = null;

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
            this.dataGridView1.Columns[1].Width = 35  * this.dataGridView1.Width / 100;
            this.dataGridView1.Columns[2].Width = 15 * this.dataGridView1.Width / 100;
            this.dataGridView1.Columns[3].Width = 10 * this.dataGridView1.Width / 100;
            this.dataGridView1.Columns[4].Width = 10 * this.dataGridView1.Width / 100;
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
            kolom.Add("");
            kolom.Add("Kode");
            kolom.Add("Nama");
            kolom.Add("Harga");
            kolom.Add("Satuan");
            kolom.Add("Stok");
            comboBox1.DataSource = kolom;
        }
        public void QueryData(Barang barang = null)
        {
            
            try
            {
                this.dataGridView1.DataSource = null;
                listData = new BarangDAO().QueryDataBarang(barang);
                if (listData != null)
                {
                    this.dataGridView1.DataSource = listData;
                    this.dataGridView1.Columns[0].DataPropertyName = nameof(Barang.Kode);
                    this.dataGridView1.Columns[1].DataPropertyName = nameof(Barang.Nama);
                    this.dataGridView1.Columns[2].DataPropertyName = nameof(Barang.Harga);
                    this.dataGridView1.Columns[3].DataPropertyName = nameof(Barang.Satuan);
                    this.dataGridView1.Columns[4].DataPropertyName = nameof(Barang.Stok);
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

        private void textBox1_Leave(object sender, EventArgs e)
        {
            List<Barang> listbaru = new List<Barang>();
            try
            {
                dataGridView1.DataSource = null;
                
                foreach (var item in listData)
                {
                    if (comboBox1.Text == "Kode" && item.Kode.ToString().ToLower().Contains(textBox1.Text))
                    {
                        listbaru.Add(item);
                    }
                    if (comboBox1.Text == "Nama" && item.Nama.ToString().ToLower().Contains(textBox1.Text))
                    {
                        listbaru.Add(item);
                    }
                    if (comboBox1.Text == "Harga" && item.Harga.ToString().ToLower().Contains(textBox1.Text))
                    {
                        listbaru.Add(item);
                    }
                    if (comboBox1.Text == "Satuan" && item.Satuan.ToString().ToLower().Contains(textBox1.Text))
                    {
                        listbaru.Add(item);
                    }
                    if (comboBox1.Text == "Stok" && item.Stok.ToString().ToLower().Contains(textBox1.Text))
                    {
                        listbaru.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            dataGridView1.DataSource = listbaru;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                FrmEditDataBarang form = new FrmEditDataBarang(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString().Trim());
                if (form.Run(form))
                {
                    QueryData(new Barang { Kode = "", Nama = "", Harga = "", Satuan = "", Stok = "" });
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0 && MessageBox.Show("Hapus Baris Data Terpilih ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (new BarangDAO().Delete(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString().Trim()) > 0)
                    {
                        QueryData(new Barang { Kode = "", Nama = "", Harga = "", Satuan = "", Stok = "" });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Faktur_Page frm = new Faktur_Page();
            frm.ShowDialog();
            //this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ResupplyForm frm = new ResupplyForm();
            frm.ShowDialog();
            //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPetugas frm = new LoginPetugas();
            frm.ShowDialog();
        }
    }
}

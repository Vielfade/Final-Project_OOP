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
    public partial class ResupplyForm : Form
    {
        List<Supplier> list= null;
        List<Barang> listData = null;
        
        public ResupplyForm()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            this.ResupplyForm_Resize(null, null);
            list = new List<Supplier>();
            dataGridView1.Columns[0].DataPropertyName = "Kode";
            dataGridView1.Columns[1].DataPropertyName = "Nama";
            dataGridView1.Columns[2].DataPropertyName = "Jumlah";
            dataGridView1.Columns[3].DataPropertyName = "Harga";
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtbox_jumlah.Text) < 50) {
                int qty = Convert.ToInt32(this.txtbox_jumlah.Text);
                qty += 1;
                this.txtbox_jumlah.Text = qty.ToString();
                decimal harga = Convert.ToDecimal(this.txtbox_harga.Text);
                decimal subtotal = qty * harga;
                this.txtSubTotal.Text = subtotal.ToString("n0");
            }
            else
            {
                MessageBox.Show("Total pesanan hanya bisa dibawah 50", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_kurang_Click(object sender, EventArgs e)
        {
                if (Convert.ToInt32(txtbox_jumlah.Text) > 0) {
                    int qty = Convert.ToInt32(this.txtbox_jumlah.Text);
                    qty -= 1;
                    this.txtbox_jumlah.Text = qty.ToString();
                    decimal harga = Convert.ToDecimal(this.txtbox_harga.Text);
                    decimal subtotal = qty * harga;
                    this.txtSubTotal.Text = subtotal.ToString("n0");
                }
                else
                {
                    MessageBox.Show("Angka harus lebih dari nol", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            FrmDgvResupply form = new FrmDgvResupply();
            Barang supp = form.Run(form);
            if (supp != null)
            {
                this.cbox_kode.Text = supp.Kode;
                this.txtbox_nama.Text = supp.Nama;
                this.txtbox_harga.Text = supp.Harga;
            }
        }        

        private void txtbox_jumlah_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtbox_jumlah.Text, "  ^ [0-9]"))
            {
                txtbox_jumlah.Text = "";
            }
            if (Convert.ToInt32(txtbox_jumlah.Text) > 100)
            {
                txtbox_jumlah.Text = "100";
            }
        }

        private void txtbox_jumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void QueryData(Barang barang = null)
        {
            try
            {
                listData = new BarangDAO().QueryDataBarang(barang);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {

            if (this.dataGridView1.SelectedRows.Count > 0 && MessageBox.Show("Hapus Baris Data Terpilih ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int row = dataGridView1.CurrentCell.RowIndex;
                    list.RemoveAt(row);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = list;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cbox_kode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbox_kode.Text.Trim() != "" && listData?.Count > 0)
            {
                string kode = this.cbox_kode.Text.Trim();
                foreach (var item in listData)
                {
                    if (item.Kode == kode)
                    {
                        this.txtbox_nama.Text = item.Nama;
                        this.txtbox_harga.Text = Convert.ToDecimal(item.Harga).ToString("n0");
                        this.txtSubTotal.Text = Convert.ToDecimal(item.Harga).ToString("n0");
                    }
                }
            }
            txtbox_jumlah.Text = "1";
        }

        private void ResupplyForm_Load(object sender, EventArgs e)
        {
            try
            {             
                listData = new BarangDAO().GetAllDataBarang();
                listData.Insert(0, new Barang{ Kode = "", Nama = "" ,Harga = ""});
                this.cbox_kode.DataSource = listData;
                this.cbox_kode.DisplayMember = nameof(Barang.Kode);
                QueryData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_pesan_Click(object sender, EventArgs e)
        {

            if (cbox_kode.Text == "" || txtbox_nama.Text == "")
            {
                MessageBox.Show("Data Tidak Boleh kosong", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (list.Count != 0)
            {
                dataGridView1.DataSource = null;
                var c = list.Find(i => i.Kode == cbox_kode.Text);
                if (c != null)
                {
                    c.Harga = ((Double.Parse(c.Harga) / Double.Parse(c.Jumlah.ToString())) * (c.Jumlah + Int32.Parse(txtbox_jumlah.Text))
                            ).ToString("n0");
                    c.Jumlah += Int32.Parse(txtbox_jumlah.Text);
                    txtbox_nama.Clear();
                    txtbox_harga.Clear();
                    txtSubTotal.Clear();
                    cbox_kode.SelectedIndex = 0;
                    dataGridView1.DataSource = list;
                }
                else
                {
                    list.Add(new Supplier
                    {
                        Kode = cbox_kode.Text,
                        Nama = txtbox_nama.Text,
                        Jumlah = Int32.Parse(txtbox_jumlah.Text),
                        Harga = txtSubTotal.Text
                    });
                    dataGridView1.DataSource = list;
                    txtbox_nama.Clear();
                    txtbox_harga.Clear();
                    txtSubTotal.Clear();
                    cbox_kode.SelectedIndex = 0;
                }
            }
            else
            {
                dataGridView1.DataSource = null;
                list.Add(new Supplier
                {
                    Kode = cbox_kode.Text,
                    Nama = txtbox_nama.Text,
                    Jumlah = Int32.Parse(txtbox_jumlah.Text),
                    Harga = txtSubTotal.Text
                });
                dataGridView1.DataSource = list;
                
                txtbox_nama.Clear();
                txtbox_harga.Clear();
                txtSubTotal.Clear();
                cbox_kode.SelectedIndex = 0;
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResupplyForm_Resize(object sender, EventArgs e)
        {
            this.dataGridView1.Columns[0].Width = 15 * this.dataGridView1.Width / 100;
            this.dataGridView1.Columns[1].Width = 35 * this.dataGridView1.Width / 100;
            this.dataGridView1.Columns[2].Width = 12 * this.dataGridView1.Width / 100;
            this.dataGridView1.Columns[3].Width = 30 * this.dataGridView1.Width / 100;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                using (var barangdao = new BarangDAO())
                {
                    
                    foreach (var item in list)
                    {
                        Barang before = barangdao.GetDataBarangByKode(item.Kode);
                        Barang brng = new Barang {
                            Kode = item.Kode,
                            Nama = item.Nama,
                            Stok = (item.Jumlah + Int32.Parse(before.Stok)).ToString(),
                            Harga = item.Harga
                        };
                        barangdao.UpdateStok(brng);
                    }
                }
               
                MessageBox.Show("Success", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

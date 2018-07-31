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
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {

            int qty = Convert.ToInt32(this.txtbox_jumlah.Text);
            qty += 1;
            this.txtbox_jumlah.Text = qty.ToString();
            decimal harga = Convert.ToDecimal(this.txtbox_harga.Text);
            decimal subtotal = qty * harga;
            this.txtSubTotal.Text = subtotal.ToString("n0");
        }

        private void btn_kurang_Click(object sender, EventArgs e)
        {
            if (txtbox_jumlah.Text == "0")
            {
                txtbox_jumlah.Text = "0";
            }
            else
            {
                int qty = Convert.ToInt32(this.txtbox_jumlah.Text);
                qty -= 1;
                this.txtbox_jumlah.Text = qty.ToString();
                decimal harga = Convert.ToDecimal(this.txtbox_harga.Text);
                decimal subtotal = qty * harga;
                this.txtSubTotal.Text = subtotal.ToString("n0");
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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

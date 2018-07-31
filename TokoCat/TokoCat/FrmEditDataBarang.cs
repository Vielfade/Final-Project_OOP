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
    public partial class FrmEditDataBarang : Form
    {
        bool _result = false;
        string _kode = string.Empty;

        public bool Run(FrmEditDataBarang form)
        {
            form.ShowDialog();
            return _result;
        }
        public FrmEditDataBarang(string Kode)
        {
            InitializeComponent();
            _kode = Kode;
            
        }

        private void FrmEditDataBarang_Load(object sender, EventArgs e)
        {
            Barang barang = new BarangDAO().GetDataBarangByKode(_kode);
            if (barang != null)
            {
                this.txtKode.Text = barang.Kode;
                this.txtNama.Text = barang.Nama;
                this.txtHarga.Text = barang.Harga;
                this.cboSatuan.Text = barang.Satuan;
                this.txtStok.Text = barang.Stok;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txtKode.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, data Kode tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtKode.Focus();
            }
            else if (this.txtNama.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, data Nama tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtNama.Focus();
            }
            else if (this.txtHarga.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, data Harga kuliah tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtHarga.Focus();
            }
            else if (this.cboSatuan.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, data Satuan tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboSatuan.Focus();
            }
            else if (this.txtStok.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, data Stok tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtStok.Focus();
            }
            else
            {
                try
                {
                    Barang barang = new Barang
                    {
                        Kode = this.txtKode.Text.Trim(),
                        Nama = this.txtNama.Text.Trim(),
                        Harga = this.txtHarga.Text.Trim(),
                        Satuan = this.cboSatuan.Text.Trim(),
                        Stok = this.txtStok.Text.Trim()
                    };
                    _result = new BarangDAO().Update(barang) > 0;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

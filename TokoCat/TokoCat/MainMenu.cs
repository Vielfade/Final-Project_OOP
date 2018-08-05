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
    public partial class MainMenu : Form
    {
        List<Barang> listData =  null;
        PenjualanDAO jualDao = null;

        public MainMenu()
        {
            InitializeComponent();
            this.lblBnykRecord.Text = $"{this.dgvMainMenu.Rows.Count.ToString("n0")} Record.";
            HitungTotal();
            this.MainMenu_Resize(null, null);
        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
            LoginPetugas frmLogin = new LoginPetugas();
            frmLogin.Show();
            
        }

        public void MainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                //txtKuantitas.Text = "1";
                listData = new BarangDAO().GetAllDataBarang();
                listData.Insert(0, new Barang { Nama = "" });
                this.cbBarang.DataSource = listData;
                this.cbBarang.DisplayMember = nameof(Barang.Nama);
                //QueryData();

                jualDao = new PenjualanDAO(Setting.connString);
                this.txtNoFaktur.Text = jualDao.GetNomorTransaksiBerikutnya(this.dtpFaktur.Value.Date);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }        

        private void btn_add_Click(object sender, EventArgs e)
        {
            

            //this.dgvMainMenu.DataSource = null;
            //this.dgvMainMenu.DataSource = frmTambah.listData;

            BarangDAO barangDAO = new BarangDAO();
            //barangDAO.Insert();

            //if (cbBarang.Text.ToString() == )

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            
            if (this.dgvMainMenu.SelectedRows.Count > 0 && MessageBox.Show("Hapus Baris Data Terpilih ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (new BarangDAO().Delete(this.dgvMainMenu.SelectedRows[0].Cells[0].Value.ToString().Trim()) > 0)
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

        private void QueryData(Barang barang = null)
        {
            try
            {
                this.dgvMainMenu.DataSource = null;
                listData = new BarangDAO().QueryDataBarang(barang);
                if (listData != null)
                {
                    this.dgvMainMenu.DataSource = listData;
                    this.dgvMainMenu.Columns[0].DataPropertyName = nameof(Barang.Kode);
                    this.dgvMainMenu.Columns[1].DataPropertyName = nameof(Barang.Nama);
                    this.dgvMainMenu.Columns[2].DataPropertyName = nameof(Barang.Harga);
                    this.dgvMainMenu.Columns[3].DataPropertyName = nameof(Barang.Satuan);
                    this.dgvMainMenu.Columns[4].DataPropertyName = nameof(Barang.Stok);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                this.lblBnykRecord.Text = $"{(listData != null ? listData.Count.ToString("n0") : "0")} Record";
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            int qty = Convert.ToInt32(this.txtKuantitas.Text);
            qty += 1;
            this.txtKuantitas.Text = qty.ToString();
            decimal harga = Convert.ToDecimal(this.txtHarga.Text);
            decimal subtotal = qty * harga;
            this.txtSubTotal.Text = subtotal.ToString("n0");
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            if (cbBarang.SelectedItem.Equals(""))
            {
                btnKurang.Enabled = true;        
            }
            else if (txtKuantitas.Text == "0")
            {
                txtKuantitas.Text = "0";
            }
            else
            {
                int qty = Convert.ToInt32(this.txtKuantitas.Text);
                qty -= 1;
                this.txtKuantitas.Text = qty.ToString();
                decimal harga = Convert.ToDecimal(this.txtHarga.Text);
                decimal subtotal = qty * harga;
                this.txtSubTotal.Text = subtotal.ToString("n0");
            }            
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtKuantitas_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtKuantitas.Text, "  ^ [0-9]"))
            {
                txtKuantitas.Text = "";
            }
        }

        private void txtKuantitas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cbBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbBarang.Text.Trim() != "" && listData?.Count > 0)
            {
                string nama = this.cbBarang.Text.Trim();
                foreach (var item in listData)
                {
                    if (item.Nama == nama)
                    {
                        this.txtHarga.Text = Convert.ToDecimal(item.Harga).ToString("n0");
                        this.txtSubTotal.Text = Convert.ToDecimal(item.Harga).ToString("n0");
                    }
                }
            }
            txtKuantitas.Text = "1";
        }

        private void HitungTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in this.dgvMainMenu.Rows)
            {
                if (row.Cells[5].Value != null && decimal.TryParse(row.Cells[5].Value.ToString(), out decimal value))
                {
                    total += value;
                }
            }
            this.lblTotal.Text = total.ToString("n0");
        }

        private void MainMenu_Resize(object sender, EventArgs e)
        {
            this.dgvMainMenu.Columns[0].Width = 35 * this.dgvMainMenu.Width / 100;
            this.dgvMainMenu.Columns[1].Width = 10 * this.dgvMainMenu.Width / 100;
            this.dgvMainMenu.Columns[2].Width = 13 * this.dgvMainMenu.Width / 100;
            this.dgvMainMenu.Columns[3].Width = 13 * this.dgvMainMenu.Width / 100;
        }

        private void dtpFaktur_Leave(object sender, EventArgs e)
        {
            this.txtNoFaktur.Text = jualDao.GetNomorTransaksiBerikutnya(this.dtpFaktur.Value.Date);

        }
    }
}

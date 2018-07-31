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

        public MainMenu()
        {
            InitializeComponent();
            this.dgvMainMenu.AutoGenerateColumns = false;
        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
            LoginPetugas frmLogin = new LoginPetugas();
            frmLogin.Show();
            
        }

        public void MainMenu_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    using (var barangDao = new BarangDAO())
            //    {
            //        this.dgvMainMenu.DataSource = barangDao.GetAllDataBarang();
            //        //this.dgvMainMenu.Columns[0].DataPropertyName = "nomor";
            //        this.dgvMainMenu.Columns[0].DataPropertyName = "nama";
            //        //this.dgvMainMenu.Columns[2].DataPropertyName = "keterangan";
            //        this.dgvMainMenu.Columns[1].DataPropertyName = "jumlah";
            //        this.dgvMainMenu.Columns[2].DataPropertyName = "harga";
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            //listData = new BarangDAO().GetAllDataBarang();
            //listData.Insert(0, new Barang{ Nama = ""});

            //cbBarang.DataSource = listData;
            //cbBarang.DisplayMember = nameof(Barang.Nama);
            //cbBarang.ValueMember = "@nama";
            //cbBarang.SelectedValue = listData;

            txtKuantitas.Text = "1";
            listData = new BarangDAO().GetAllDataBarang();
            listData.Insert(0, new Barang { Nama = ""});
            this.cbBarang.DataSource = listData;
            this.cbBarang.DisplayMember = nameof(Barang.Nama);
            //QueryData();
        }        

        private void btn_add_Click(object sender, EventArgs e)
        {
            //FrmTambahPenjualan frmTambah = new FrmTambahPenjualan();
            //frmTambah.Show();

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
            if (cbBarang.SelectedItem.Equals(""))
            {
                btnTambah.Enabled = true;
            }
            else
            {
                txtKuantitas.Text = (Convert.ToInt32(txtKuantitas.Text) + 1).ToString();
            }            
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
                txtKuantitas.Text = (Convert.ToInt32(txtKuantitas.Text) - 1).ToString();
            }            
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

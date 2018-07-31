using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryPenjualan;

namespace TokoCat
{
    //BarangDAO barangDAO = new BarangDAO();
    

    public partial class FrmTambahPenjualan : Form
    {
        List<string> barang = new List<string>();
        List<string> keteranganCat = new List<string>();
        List<string> keteranganKuas = new List<string>();
        List<string> keteranganPengikis = new List<string>();
        List<string> keteranganPilox = new List<string>();

       // MainMenu main = new MainMenu();

        public FrmTambahPenjualan()
        {
            InitializeComponent();
        }

        private void cbBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbBarang.SelectedItem.Equals("Amplas 3\""))
            //{
            //    cbKeterangan.Enabled = false;
            //}
            //else if (cbBarang.SelectedItem.Equals("Bak Cat 5\""))
            //{
            //    cbKeterangan.Enabled = false;
            //}
            //else if (cbBarang.SelectedItem.Equals("Cat Tembok 5 kg"))
            //{
            //    cbKeterangan.Enabled = true;
            //    cbKeterangan.DataSource = keteranganCat;
            //}
            //else if (cbBarang.SelectedItem.Equals("Cat Tembok 10 kg"))
            //{
            //    cbKeterangan.Enabled = true;
            //    cbKeterangan.DataSource = keteranganCat;
            //}
            //else if (cbBarang.SelectedItem.Equals("Cat Tembok 25 kg"))
            //{
            //    cbKeterangan.Enabled = true;
            //    cbKeterangan.DataSource = keteranganCat;
            //}
            //else if (cbBarang.SelectedItem.Equals("Kuas"))
            //{
            //    cbKeterangan.Enabled = true;
            //    cbKeterangan.DataSource = keteranganKuas;
            //}
            //else if (cbBarang.SelectedItem.Equals("Alat Pengikis"))
            //{
            //    cbKeterangan.Enabled = true;
            //    cbKeterangan.DataSource = keteranganPengikis;
            //}
            //else if (cbBarang.SelectedItem.Equals("Pilox 400cc"))
            //{
            //    cbKeterangan.Enabled = true;
            //    cbKeterangan.DataSource = keteranganPilox;
            //}
            //else if (cbBarang.SelectedItem.Equals("Roller 5\""))
            //{
            //    cbKeterangan.Enabled = false;
            //}
            //else if (cbBarang.SelectedItem.Equals("Spray Gun"))
            //{
            //    cbKeterangan.Enabled = false;
            //}
            //else if (cbBarang.SelectedItem.Equals("Thinner 1 liter"))
            //{
            //    cbKeterangan.Enabled = false;
            //}
        }

        private void FrmTambahPenjualan_Load(object sender, EventArgs e)
        {
            txtHarga.ReadOnly = true;
            //txtHarga.Text = (Convert.ToInt32(txtKuantitas.Text)) * .ToString();

            //BarangDAO barangDAO = new BarangDAO();
            //List<Barang> harga = barangDAO.GetHargaBarang();
            //int temp = Convert.ToInt32(harga);
            //txtHarga.Text = (temp * Convert.ToInt32(txtKuantitas.Text)).ToString();

            // TODO: This line of code loads data into the 'dBPenjualanCATDataSet.Barang' table. You can move, or remove it, as needed.
            this.barangTableAdapter.Fill(this.dBPenjualanCATDataSet.Barang);
            

            cbKeterangan.Enabled = false;
            //barang.Add("");
            //barang.Add("Amplas 3\"");
            //barang.Add("Bak Cat 5\"");
            //barang.Add("Cat Tembok 5 kg");
            //barang.Add("Cat Tembok 10 kg");
            //barang.Add("Cat Tembok 25 kg");
            //barang.Add("Kuas");
            //barang.Add("Alat Pengikis");
            //barang.Add("Pilox 400cc");
            //barang.Add("Roller 5\"");
            //barang.Add("Spray Gun");
            //barang.Add("Thinner 1 liter");

            //barang.Add("Amplas 3\"");
            //barang.Add("Bak Cat 5\"");
            //barang.Add("Cat Tembok 5 kg Warna Putih");
            //barang.Add("Cat Tembok 5 kg Warna Merah");
            //barang.Add("Cat Tembok 5 kg Warna Aster Pearl");
            //barang.Add("Cat Tembok 5 kg Warna Scarlet Oak");
            //barang.Add("Cat Tembok 5 kg Warna Alba  Rose");
            //barang.Add("Cat Tembok 5 kg Warna Strawberry Muffin");
            //barang.Add("Cat Tembok 5 kg Warna Biru");
            //barang.Add("Cat Tembok 5 kg Warna Blue Lullaby");
            //barang.Add("Cat Tembok 5 kg Warna Blue Signature");
            //barang.Add("Cat Tembok 5 kg Warna Bosco Blue");
            //barang.Add("Cat Tembok 5 kg Warna Sky Blue");
            //barang.Add("Cat Tembok 5 kg Warna Hijau");
            //barang.Add("Cat Tembok 5 kg Warna Quite Lake");
            //barang.Add("Cat Tembok 5 kg Warna Fairways");
            //barang.Add("Cat Tembok 5 kg Warna Grated Green");
            //barang.Add("Cat Tembok 5 kg Warna Getaway");
            //barang.Add("Cat Tembok 5 kg Warna Kuning");
            //barang.Add("Cat Tembok 5 kg Warna Absolute Yellow");
            //barang.Add("Cat Tembok 5 kg Warna Feather Yellow");
            //barang.Add("Cat Tembok 5 kg Warna Sunny Ivory");
            //barang.Add("Cat Tembok 5 kg Warna All Gold");

            //keteranganCat.Add("Putih");
            //keteranganCat.Add("Merah");
            //keteranganCat.Add("Aster Pearl");
            //keteranganCat.Add("Scarlet Oak");
            //keteranganCat.Add("Alba Rose");
            //keteranganCat.Add("Strawberry Muffin");
            //keteranganCat.Add("Biru");
            //keteranganCat.Add("Blue Lullaby");
            //keteranganCat.Add("Blue Signature");
            //keteranganCat.Add("Bosco Blue");
            //keteranganCat.Add("Sky Blue");
            //keteranganCat.Add("Hijau");
            //keteranganCat.Add("Quite Lake");
            //keteranganCat.Add("Fairways");
            //keteranganCat.Add("Grated Green");
            //keteranganCat.Add("Getaway");
            //keteranganCat.Add("Kuning");
            //keteranganCat.Add("Absolute Yellow");
            //keteranganCat.Add("Feather Yellow");
            //keteranganCat.Add("Sunny Ivory");
            //keteranganCat.Add("Good Fun");
            //keteranganCat.Add("All Gold");

            //keteranganKuas.Add("2\"");
            //keteranganKuas.Add("3\"");
            //keteranganKuas.Add("4\"");
            //keteranganKuas.Add("5\"");

            //keteranganPengikis.Add("3\"");
            //keteranganPengikis.Add("5\"");

            //keteranganPilox.Add("Putih");
            //keteranganPilox.Add("Merah");
            //keteranganPilox.Add("Biru");
            //keteranganPilox.Add("Kuning");
            //keteranganPilox.Add("Hijau");
            //keteranganPilox.Add("Hitam");
            //cbBarang.DataSource = barang;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        

        private void btnOK_Click(object sender, EventArgs e)
        {
            //if (txtKuantitas.Text == "0")
            //{
            //    MessageBox.Show("Tentukan jumlah barang.");
            //}
            //else
            //{
            //    using (MainMenu main = new MainMenu())
            //    {
            //        //main.dgvMainMenu.Rows[0].Cells[0].Value = cbBarang.Text.ToString();
            //        //main.dgvMainMenu.Rows[0].Cells[1].Value = (cbKeterangan.Text.ToString());
            //        //main.dgvMainMenu.Rows[0].Cells[2].Value = (txtKuantitas.Text.ToString());

            //        List<string> listDataBarang = new List<string>();
            //        List<string> listDataKeterangan = new List<string>();
            //        List<string> listDataKuantitas = new List<string>();
            //        //BarangDAO barangDAO = new BarangDAO();
            //        //barangDAO.GetAllDataBarang(cbBarang.Text.ToString());

            //        listDataBarang.Add(cbBarang.Text.ToString());
            //        listDataKeterangan.Add(cbKeterangan.Text.ToString());
            //        listDataKuantitas.Add(txtKuantitas.Text.ToString());

            //        //barangDAO.GetAllDataBarang();
            //       // main.dgvMainMenu.DataSource = barangDAO.GetAllDataBarang();
            //       // main.dgvMainMenu.Columns[0].ToString() = cbBarang.SelectedItem;
                    

            //        //cbKeterangan.SelectedText = main.dgvMainMenu.Columns[1].ToString();
            //        //txtKuantitas.SelectedText = main.dgvMainMenu.Columns[2].ToString();
            //        this.Close();
            //    }
            //}
                
        }

        

        //public List<Barang> GetDataJual()
        //{
        //    List<Barang> listData = null;

        //    try
        //    {
        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            cmd.Connection = 
        //        }

        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }

        //    return listData;
        //}



        private void txtKuantitas_TextChanged(object sender, EventArgs e)
        {
            //if (txtKuantitas == null)
            //{
            //    txtKuantitas.Text = "0";
            //}
            //if (System.Text.RegularExpressions.Regex.IsMatch(txtKuantitas.Text, "  ^ [0-9]"))
            //{
            //    txtKuantitas.Text = "";
            //}
        }

        private void txtKuantitas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}

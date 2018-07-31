using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokoCat
{
    public partial class FrmTambahPenjualan : Form
    {
        List<string> barang = new List<string>();
        List<string> keteranganCat = new List<string>();
        List<string> keteranganKuas = new List<string>();
        List<string> keteranganPengikis = new List<string>();
        List<string> keteranganPilox = new List<string>();

        public FrmTambahPenjualan()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBarang.SelectedItem.Equals("Amplas 3 inch"))
            {
                cbKeterangan.Enabled = false;
            }
            else if (cbBarang.SelectedItem.Equals("Bak Cat 5 inch"))
            {
                cbKeterangan.Enabled = false;
            }
            else if (cbBarang.SelectedItem.Equals("Cat Tembok 5 kg"))
            {
                cbKeterangan.Enabled = true;
                cbKeterangan.DataSource = keteranganCat;
            }
            else if (cbBarang.SelectedItem.Equals("Cat Tembok 10 kg"))
            {
                cbKeterangan.Enabled = true;
                cbKeterangan.DataSource = keteranganCat;
            }
            else if (cbBarang.SelectedItem.Equals("Cat Tembok 25 kg"))
            {
                cbKeterangan.Enabled = true;
                cbKeterangan.DataSource = keteranganCat;
            }
            else if (cbBarang.SelectedItem.Equals("Kuas"))
            {
                cbKeterangan.Enabled = true;
                cbKeterangan.DataSource = keteranganKuas;
            }
            else if (cbBarang.SelectedItem.Equals("Alat Pengikis"))
            {
                cbKeterangan.Enabled = true;
                cbKeterangan.DataSource = keteranganPengikis;
            }
            else if (cbBarang.SelectedItem.Equals("Pilox 400cc"))
            {
                cbKeterangan.Enabled = true;
                cbKeterangan.DataSource = keteranganPilox;
            }
            else if (cbBarang.SelectedItem.Equals("Roller 5 inch"))
            {
                cbKeterangan.Enabled = false;
            }
            else if (cbBarang.SelectedItem.Equals("Spray Gun"))
            {
                cbKeterangan.Enabled = false;
            }
            else if (cbBarang.SelectedItem.Equals("Thinner 1 liter"))
            {
                cbKeterangan.Enabled = false;
            }
        }

        private void FrmTambahPenjualan_Load(object sender, EventArgs e)
        {
            cbKeterangan.Enabled = false;
            barang.Add("");
            barang.Add("Amplas 3 inch");
            barang.Add("Bak Cat 5 inch");
            barang.Add("Cat Tembok 5 kg");
            barang.Add("Cat Tembok 10 kg");
            barang.Add("Cat Tembok 25 kg");
            barang.Add("Kuas");
            barang.Add("Alat Pengikis");
            barang.Add("Pilox 400cc");
            barang.Add("Roller 5 inch");
            barang.Add("Spray Gun");
            barang.Add("Thinner 1 liter");

            keteranganCat.Add("Putih");
            keteranganCat.Add("Merah");
            keteranganCat.Add("Aster Pearl");
            keteranganCat.Add("Scarlet Oak");
            keteranganCat.Add("Alba Rose");
            keteranganCat.Add("Strawberry Muffin");
            keteranganCat.Add("Biru");
            keteranganCat.Add("Blue Lullaby");
            keteranganCat.Add("Blue Signature");
            keteranganCat.Add("Bosco Blue");
            keteranganCat.Add("Sky Blue");
            keteranganCat.Add("Hijau");
            keteranganCat.Add("Quite Lake");
            keteranganCat.Add("Fairways");
            keteranganCat.Add("Grated Green");
            keteranganCat.Add("Getaway");
            keteranganCat.Add("Kuning");
            keteranganCat.Add("Absolute Yellow");
            keteranganCat.Add("Feather Yellow");
            keteranganCat.Add("Sunny Ivory");
            keteranganCat.Add("Good Fun");
            keteranganCat.Add("All Gold");

            keteranganKuas.Add("2 \"\"");
            keteranganKuas.Add("3 \"\"");
            keteranganKuas.Add("4 \"\"");
            keteranganKuas.Add("5 \"\"");

            keteranganPengikis.Add("3 \"\"");
            keteranganPengikis.Add("5 \"\"");

            keteranganPilox.Add("Putih");
            keteranganPilox.Add("Merah");
            keteranganPilox.Add("Biru");
            keteranganPilox.Add("Kuning");
            keteranganPilox.Add("Hijau");
            keteranganPilox.Add("Hitam");
            cbBarang.DataSource = barang;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {

        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            txtKuantitas.Text = (Convert.ToInt16(txtKuantitas.Text) - 1).ToString();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            txtKuantitas.Text = (Convert.ToInt16(txtKuantitas.Text) + 1).ToString();
        }

        private void cbKeterangan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

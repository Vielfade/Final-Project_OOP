using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPenjualan
{
    public class Supplier
    {
        public string Kode { get; set; }
        public string Nama { get; set; }
        public string Kota { get; set; }
        public Barang DataBarang { get; set; }

    }
}

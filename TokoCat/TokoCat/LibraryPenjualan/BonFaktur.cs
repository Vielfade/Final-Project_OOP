using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPenjualan
{
    public class BonFaktur
    {
        public string NoFaktur { get; set; }
        public Barang DataBarang { get; set; }
        public string Qty { get; set; }
        public string HargaSatuan { get; set; }
        public string HargaTotal { get; set; }
    }
}

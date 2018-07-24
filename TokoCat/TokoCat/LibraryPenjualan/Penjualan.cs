using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPenjualan
{
    public class Penjualan
    {
        public string Nomor { get; set; }
        public DateTime Tanggal { get; set; }
        public decimal Total { get; set; }
        public List<BonFaktur> DataDetail { get; set; }
    }
}

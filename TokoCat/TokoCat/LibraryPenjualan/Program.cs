using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPenjualan
{
    public static class Program
    {
        public static string GetConnectionString()
        {
            return
                 @"Data Source = (localdb)\mssqllocaldb; 
                    Initial Catalog = DBPenjualanCat; 
                    Integrated Security = True;";

           // @"Data Source = .\sqlexpress; Initial Catalog = DBPenjualanCat; Integrated Security = True";

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  LibraryPenjualan;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString =
                @"Data Source = (localdb)\mssqllocaldb; 
                    Initial Catalog = DBPenjualanCAT; 
                    Integrated Security = True;";
            try
            {
                using (var dao = new SupplierDAO(connString))
                {
                    var listData = dao.GetAllDataSupplier();
                    if (listData?.Count > 0)
                    {
                        listData.ForEach(
                            item => Console.WriteLine($"{item.Kode,-10}{item.Nama}{item.Kota}{item.DataBarang}"));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
                Console.ReadKey();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LibraryPenjualan
{
    public class SupplierDAO : IDisposable
    {
        SqlConnection _conn = null;

        public SupplierDAO(string connectionString)
        {
            try
            {
                _conn = new SqlConnection(connectionString);
                _conn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Supplier> GetAllDataSupplier()
        {
            List<Supplier> listData = null;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _conn;
                    cmd.CommandText = @"select * from Supplier order by Kode";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            listData = new List<Supplier>();
                            while (reader.Read())
                            {
                                listData.Add(new Supplier
                                {
                                    Kode = reader["Kode"].ToString(),
                                    Nama = reader["Nama"].ToString(),
                                    Jumlah = Convert.ToInt32(reader["Jumlah"]),
                                    Harga = reader["Harga"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listData;
        }

        public Supplier GetDataSuppleierByKode(string Kode)
        {
            Supplier result = null;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _conn;
                    cmd.CommandText = @"select * from Supplier Where Kode = @Kode";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Kode", Kode);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                result = new Supplier
                                {
                                    Kode = reader["Kode"].ToString(),
                                    Nama = reader["Qty"].ToString(),
                                    Jumlah = Convert.ToInt32(reader["Jumlah"]),
                                    Harga = reader["Harga"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

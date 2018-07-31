using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPenjualan
{
    public class BarangDAO : IDisposable
    {

        SqlConnection _conn = null;

        public BarangDAO()
        {
            try
            {
                _conn = new SqlConnection(Program.GetConnectionString());
                _conn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Barang> GetAllDataBarang()
        {
            List<Barang> listData = null;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _conn;
                    cmd.CommandText = @"select * from barang order by kode";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            listData = new List<Barang>();
                            while (reader.Read())
                            {
                                listData.Add(new Barang
                                {
                                    Kode = reader["Kode"].ToString(),
                                    Nama = reader["Nama"].ToString(),
                                    Harga = reader ["Harga"].ToString(),
                                    Satuan = reader["Satuan"].ToString(),
                                    Stok = reader["Stok"].ToString()
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

        public Barang GetDataBarangByKode(string kode)
        {
            Barang result = null;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _conn;
                    cmd.CommandText = @"select * from barang Where kode = @Kode";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Kode", kode);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                result = new Barang
                                {
                                    Kode = reader["Kode"].ToString(),
                                    Nama = reader["Nama"].ToString(),
                                    Harga = reader["Harga"].ToString(),
                                    Satuan = reader["Satuan"].ToString(),
                                    Stok = reader["Stok"].ToString()
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

        public List<Barang> QueryDataBarang(Barang barang)
        {
            List<Barang> listData = null;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _conn;
                    if (barang == null)
                    {
                        cmd.CommandText =
                            @"select * from Barang order by kode";
                    }
                    else
                    {
                        cmd.CommandText =
                            @"select b.* from mahasiswa m 
                                where b.kode like @kode and b.nama like @nama and
                                b.keterangan like @keterangan and b.harga like @harga and b.satuan like @satuan 
                                and b.stok like @stok 
                                order by kode";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@kode", $"%{barang.Kode}%");
                        cmd.Parameters.AddWithValue("@nama", $"%{barang.Nama}%");
                        cmd.Parameters.AddWithValue("@Harga", $"%{barang.Harga}%");
                        cmd.Parameters.AddWithValue("@Satuan", $"%{barang.Satuan}%");
                        cmd.Parameters.AddWithValue("@Stok", $"%{barang.Stok}%");
                    }
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            listData = new List<Barang>();
                            while (reader.Read())
                            {
                                listData.Add(
                                    new Barang
                                    {
                                        Kode = reader["kode"].ToString(),
                                        Nama = reader["nama"].ToString(),
                                        Harga = reader["harga"].ToString(),
                                        Satuan = reader["satuan"].ToString(),
                                        Stok = reader["stok"].ToString()
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

        public int Update(Barang barang)
        {
            int result = 0;
            SqlTransaction trans = null;
            try
            {
                trans = _conn.BeginTransaction();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _conn;
                    cmd.Transaction = trans;
                    cmd.CommandText = @"update barang set kode = @kode, nama = @nama, keterangan = @keterangan,
                        harga = @harga, satuan = @satuan,
                        stok = @stok where kode = @kode";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@kode", barang.Kode);
                    cmd.Parameters.AddWithValue("@nama", barang.Nama);
                    cmd.Parameters.AddWithValue("@harga", barang.Harga);
                    cmd.Parameters.AddWithValue("@Satuan", barang.Satuan);
                    cmd.Parameters.AddWithValue("@stok", barang.Stok);
                    result = cmd.ExecuteNonQuery();
                }
                trans.Commit();
            }
            catch (Exception ex)
            {
                if (trans != null) trans.Rollback();
                throw ex;
            }
            finally
            {
                if (trans != null) trans.Dispose();
            }
            return result;
        }

        public int Delete(string kode)
        {
            int result = 0;
            SqlTransaction trans = null;
            try
            {
                trans = _conn.BeginTransaction();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _conn;
                    cmd.Transaction = trans;
                    cmd.CommandText = @"delete barang where kode = @kode";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@kode", kode);
                    result = cmd.ExecuteNonQuery();
                }
                trans.Commit();
            }
            catch (Exception ex)
            {
                if (trans != null) trans.Rollback();
                throw ex;
            }
            finally
            {
                if (trans != null) trans.Dispose();
            }
            return result;
        }

        public int Kali(string kode)
        {
            int result = 0;
            SqlTransaction trans = null;
            try
            {
                trans = _conn.BeginTransaction();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _conn;
                    cmd.Transaction = trans;
                    cmd.CommandText = @"select *,(), barang where kode = @kode";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@kode", kode);
                    result = cmd.ExecuteNonQuery();
                }
                trans.Commit();
            }
            catch (Exception ex)
            {
                if (trans != null) trans.Rollback();
                throw ex;
            }
            finally
            {
                if (trans != null) trans.Dispose();
            }
            return result;
        }

        public void Dispose()
        {
            if (_conn != null) _conn.Close();
        }
    }
}

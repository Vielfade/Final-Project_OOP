using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPenjualan
{
    public class PenjualanDAO : IDisposable
    {

        SqlConnection _conn = null;

        public List<Penjualan> listData { get; set; } = null;

        public PenjualanDAO(string connectionString)
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

        public bool InsertItem(Penjualan penjualan)
        {
            bool result = false;
            try
            {
                listData.Add(penjualan);
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        //public int DeleteItem(Penjualan penjualan)
        //{
        //    int result = 0;
        //    try
        //    {
        //        string sqlString = @"delete barang where penjualan = @kode";
        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            cmd.Connection = _conn;
        //            cmd.CommandText = sqlString;
        //            cmd.Parameters.Clear();
        //            cmd.Parameters.AddWithValue("@kode", penjualan);
        //            result = cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //    return result;
        //}

        public string GetNomorTransaksiBerikutnya(DateTime tanggal)
        {
            string result = "";
            try
            {
                int tahun = tanggal.Year;
                int bulan = tanggal.Month;
                DateTime tanggalDari = new DateTime(tahun, bulan, 1);
                DateTime tanggalSampai = new DateTime(tahun, bulan, DateTime.DaysInMonth(tahun, bulan));
                string nomorTransaksiTerakhir = "";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _conn;
                    cmd.CommandText =
                        @"Select Top 1 Nomor From PenjualanHeader 
                            Where Tanggal Between @TanggalDari And @TanggalSampai 
                            Order By Tanggal Desc";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@TanggalDari", tanggalDari.Date);
                    cmd.Parameters.AddWithValue("@TanggalSampai", tanggalSampai.Date);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                nomorTransaksiTerakhir = reader["Nomor"].ToString();
                            }
                        }
                    }
                }
                if (nomorTransaksiTerakhir == "")
                {
                    result = $"0001/JL/{bulan.ToString("00")}/{tahun}";
                }
                else
                {
                    int lastNumber = Convert.ToInt32(nomorTransaksiTerakhir.Substring(0, 4));
                    result = $"{(lastNumber + 1).ToString("0000")}/JL/{bulan.ToString("00")}/{tahun}";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public bool Simpan(Penjualan penjualan)
        {
            bool result = false;
            int rowAffected = 0;
            SqlTransaction trans = null;
            try
            {
                trans = _conn.BeginTransaction();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _conn;
                    cmd.Transaction = trans;

                    cmd.CommandText = @"Insert Into PenjualanHeader Values (@Nomor, @Tanggal, @KodeCustomer, @Total)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Nomor", penjualan.Nomor);
                    cmd.Parameters.AddWithValue("@Tanggal", penjualan.Tanggal);
                    cmd.Parameters.AddWithValue("@Total", penjualan.Total);
                    rowAffected += cmd.ExecuteNonQuery();

                    foreach (BonFaktur itemDetail in penjualan.DataDetail)
                    {
                        cmd.CommandText = @"Insert Into PenjualanDetail Values (@Nomor, @NoUrut, @KodeBarang, @Quantity, @Harga)";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@Nomor", itemDetail.NoFaktur);
                        cmd.Parameters.AddWithValue("@KodeBarang", itemDetail.DataBarang.Kode);
                        cmd.Parameters.AddWithValue("@Qty", itemDetail.Qty);
                        cmd.Parameters.AddWithValue("@HargaSatuan", itemDetail.HargaSatuan);
                        cmd.Parameters.AddWithValue("@HargaTotal", itemDetail.HargaTotal);
                        rowAffected += cmd.ExecuteNonQuery();
                    }
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

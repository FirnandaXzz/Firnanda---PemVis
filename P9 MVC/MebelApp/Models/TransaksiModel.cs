using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace MebelpApp.Models
{
    public class TransaksiModel
    {
        private string connStr = "server=localhost;user=root;password=;database=mebel;port=3306";

        public DataTable GetAllTransaksi()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT kode_barang, nama_barang, harga, jumlah, total, tanggal FROM transaksi ORDER BY tanggal DESC";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public bool AddTransaksi(string kode, string nama, decimal harga, int jumlah, decimal total)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO transaksi (kode_barang, nama_barang, harga, jumlah, total, tanggal) " +
                                 "VALUES (@kode, @nama, @harga, @jumlah, @total, @tanggal)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@kode", kode);
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@harga", harga);
                    cmd.Parameters.AddWithValue("@jumlah", jumlah);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@tanggal", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool UpdateTransaksi(string kode, DateTime tanggal, int jumlahBaru, decimal totalBaru)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE transaksi SET jumlah = @jumlah, total = @total WHERE kode_barang = @kode AND tanggal = @tanggal";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@jumlah", jumlahBaru);
                    cmd.Parameters.AddWithValue("@total", totalBaru);
                    cmd.Parameters.AddWithValue("@kode", kode);
                    cmd.Parameters.AddWithValue("@tanggal", tanggal);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool DeleteTransaksi(string kode, DateTime tanggal)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM transaksi WHERE kode_barang = @kode AND tanggal = @tanggal";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@kode", kode);
                    cmd.Parameters.AddWithValue("@tanggal", tanggal);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
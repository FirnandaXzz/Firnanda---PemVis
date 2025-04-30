private void SimpanKeDatabase(MebelItem item)
{
    using var conn = DatabaseHelper.GetConnection();
    string insertCmd = "INSERT INTO Penjualan (NamaBarang, Jumlah, HargaSatuan) VALUES (@nama, @jumlah, @harga)";
    using var cmd = new SQLiteCommand(insertCmd, conn);
    cmd.Parameters.AddWithValue("@nama", item.NamaBarang);
    cmd.Parameters.AddWithValue("@jumlah", item.Jumlah);
    cmd.Parameters.AddWithValue("@harga", item.HargaSatuan);
    cmd.ExecuteNonQuery();
}

using System;
using System.Data.SQLite;
using System.IO;

namespace PenjualanMebelApp
{
    public static class DatabaseHelper
    {
        private static string dbFile = "penjualan.db";
        private static string connectionString = $"Data Source={dbFile};Version=3;";

        static DatabaseHelper()
        {
            if (!File.Exists(dbFile))
            {
                SQLiteConnection.CreateFile(dbFile);
                using var connection = new SQLiteConnection(connectionString);
                connection.Open();

                string tableCmd = @"
                CREATE TABLE IF NOT EXISTS Penjualan (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    NamaBarang TEXT NOT NULL,
                    Jumlah INTEGER NOT NULL,
                    HargaSatuan REAL NOT NULL
                );";

                using var command = new SQLiteCommand(tableCmd, connection);
                command.ExecuteNonQuery();
            }
        }

        public static SQLiteConnection GetConnection()
        {
            var conn = new SQLiteConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}

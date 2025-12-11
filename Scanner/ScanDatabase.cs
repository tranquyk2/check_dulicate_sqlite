using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;

namespace Scanner
{
    public static class ScanDatabase
    {
        private static readonly string DatabaseFolder;
        private static readonly string DatabasePath;
        private static readonly string ConnectionString;

        static ScanDatabase()
        {
            DatabaseFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Scanner");
            DatabasePath = Path.Combine(DatabaseFolder, "scans.db");
            ConnectionString = $"Data Source={DatabasePath}";

            InitializeDatabase();
        }

        private static void InitializeDatabase()
        {
            try
            {
                if (!Directory.Exists(DatabaseFolder))
                {
                    Directory.CreateDirectory(DatabaseFolder);
                }

                using var connection = new SqliteConnection(ConnectionString);
                connection.Open();

                var createTableCmd = connection.CreateCommand();
                createTableCmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS ScanRecords (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        STT INTEGER NOT NULL,
                        Barcode TEXT NOT NULL,
                        NgayGio TEXT NOT NULL,
                        KetQua TEXT NOT NULL,
                        Ca TEXT,
                        ScanTime DATETIME DEFAULT CURRENT_TIMESTAMP
                    );
                    
                    CREATE INDEX IF NOT EXISTS idx_barcode ON ScanRecords(Barcode);
                    CREATE INDEX IF NOT EXISTS idx_scantime ON ScanRecords(ScanTime);
                ";
                createTableCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Log error but don't crash the app
                System.Diagnostics.Debug.WriteLine($"Database initialization error: {ex.Message}");
            }
        }

        public static void SaveScanRecord(int stt, string barcode, string ngayGio, string ketQua, string ca)
        {
            try
            {
                using var connection = new SqliteConnection(ConnectionString);
                connection.Open();

                var insertCmd = connection.CreateCommand();
                insertCmd.CommandText = @"
                    INSERT INTO ScanRecords (STT, Barcode, NgayGio, KetQua, Ca)
                    VALUES (@stt, @barcode, @ngaygio, @ketqua, @ca)
                ";
                insertCmd.Parameters.AddWithValue("@stt", stt);
                insertCmd.Parameters.AddWithValue("@barcode", barcode ?? string.Empty);
                insertCmd.Parameters.AddWithValue("@ngaygio", ngayGio ?? string.Empty);
                insertCmd.Parameters.AddWithValue("@ketqua", ketQua ?? string.Empty);
                insertCmd.Parameters.AddWithValue("@ca", ca ?? string.Empty);

                insertCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Database save error: {ex.Message}");
            }
        }

        public static List<ScanRecord> GetRecentScans(int limit = 1000)
        {
            var records = new List<ScanRecord>();

            try
            {
                using var connection = new SqliteConnection(ConnectionString);
                connection.Open();

                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = @"
                    SELECT Id, STT, Barcode, NgayGio, KetQua, Ca, ScanTime
                    FROM ScanRecords
                    ORDER BY Id DESC
                    LIMIT @limit
                ";
                selectCmd.Parameters.AddWithValue("@limit", limit);

                using var reader = selectCmd.ExecuteReader();
                while (reader.Read())
                {
                    records.Add(new ScanRecord
                    {
                        Id = reader.GetInt32(0),
                        STT = reader.GetInt32(1),
                        Barcode = reader.GetString(2),
                        NgayGio = reader.GetString(3),
                        KetQua = reader.GetString(4),
                        Ca = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        ScanTime = reader.IsDBNull(6) ? DateTime.MinValue : reader.GetDateTime(6)
                    });
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Database read error: {ex.Message}");
            }

            return records;
        }

        public static List<ScanRecord> GetScansByDateRange(DateTime fromDate, DateTime toDate, int limit = 100000)
        {
            var records = new List<ScanRecord>();

            try
            {
                using var connection = new SqliteConnection(ConnectionString);
                connection.Open();

                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = @"
                    SELECT Id, STT, Barcode, NgayGio, KetQua, Ca, ScanTime
                    FROM ScanRecords
                    WHERE DATE(ScanTime) BETWEEN DATE(@fromDate) AND DATE(@toDate)
                    ORDER BY Id DESC
                    LIMIT @limit
                ";
                selectCmd.Parameters.AddWithValue("@fromDate", fromDate.ToString("yyyy-MM-dd"));
                selectCmd.Parameters.AddWithValue("@toDate", toDate.ToString("yyyy-MM-dd"));
                selectCmd.Parameters.AddWithValue("@limit", limit);

                using var reader = selectCmd.ExecuteReader();
                while (reader.Read())
                {
                    records.Add(new ScanRecord
                    {
                        Id = reader.GetInt32(0),
                        STT = reader.GetInt32(1),
                        Barcode = reader.GetString(2),
                        NgayGio = reader.GetString(3),
                        KetQua = reader.GetString(4),
                        Ca = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        ScanTime = reader.IsDBNull(6) ? DateTime.MinValue : reader.GetDateTime(6)
                    });
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Database query error: {ex.Message}");
            }

            return records;
        }

        public static int GetTotalRecordCount()
        {
            try
            {
                using var connection = new SqliteConnection(ConnectionString);
                connection.Open();

                var countCmd = connection.CreateCommand();
                countCmd.CommandText = "SELECT COUNT(*) FROM ScanRecords";
                var result = countCmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Database count error: {ex.Message}");
                return 0;
            }
        }

        public static void DeleteOldRecords(int daysToKeep = 90)
        {
            try
            {
                using var connection = new SqliteConnection(ConnectionString);
                connection.Open();

                var deleteCmd = connection.CreateCommand();
                deleteCmd.CommandText = @"
                    DELETE FROM ScanRecords 
                    WHERE ScanTime < datetime('now', '-' || @days || ' days')
                ";
                deleteCmd.Parameters.AddWithValue("@days", daysToKeep);
                deleteCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Database delete error: {ex.Message}");
            }
        }

        public static bool DeleteRecordByBarcode(string barcode, string ngayGio, string ketQua)
        {
            try
            {
                using var connection = new SqliteConnection(ConnectionString);
                connection.Open();

                var deleteCmd = connection.CreateCommand();
                deleteCmd.CommandText = @"
                    DELETE FROM ScanRecords 
                    WHERE Barcode = @barcode 
                    AND NgayGio = @ngaygio 
                    AND KetQua = @ketqua
                    AND Id = (
                        SELECT Id FROM ScanRecords 
                        WHERE Barcode = @barcode 
                        AND NgayGio = @ngaygio 
                        AND KetQua = @ketqua
                        ORDER BY ScanTime DESC LIMIT 1
                    )
                ";
                deleteCmd.Parameters.AddWithValue("@barcode", barcode ?? string.Empty);
                deleteCmd.Parameters.AddWithValue("@ngaygio", ngayGio ?? string.Empty);
                deleteCmd.Parameters.AddWithValue("@ketqua", ketQua ?? string.Empty);
                
                var rowsAffected = deleteCmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Database delete error: {ex.Message}");
                return false;
            }
        }

        public static List<ScanRecord> SearchByBarcode(string searchText, int limit = 1000)
        {
            var records = new List<ScanRecord>();

            try
            {
                using var connection = new SqliteConnection(ConnectionString);
                connection.Open();

                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = @"
                    SELECT Id, STT, Barcode, NgayGio, KetQua, Ca, ScanTime
                    FROM ScanRecords
                    WHERE Barcode LIKE @searchText
                    ORDER BY ScanTime DESC
                    LIMIT @limit
                ";
                selectCmd.Parameters.AddWithValue("@searchText", $"%{searchText}%");
                selectCmd.Parameters.AddWithValue("@limit", limit);

                using var reader = selectCmd.ExecuteReader();
                while (reader.Read())
                {
                    records.Add(new ScanRecord
                    {
                        Id = reader.GetInt32(0),
                        STT = reader.GetInt32(1),
                        Barcode = reader.GetString(2),
                        NgayGio = reader.GetString(3),
                        KetQua = reader.GetString(4),
                        Ca = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        ScanTime = reader.IsDBNull(6) ? DateTime.MinValue : reader.GetDateTime(6)
                    });
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Database search error: {ex.Message}");
            }

            return records;
        }

        public static List<ScanRecord> GetRecordsByMonth(int year, int month, int limit = 1000000)
        {
            var records = new List<ScanRecord>();

            try
            {
                using var connection = new SqliteConnection(ConnectionString);
                connection.Open();

                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = @"
                    SELECT Id, STT, Barcode, NgayGio, KetQua, Ca, ScanTime
                    FROM ScanRecords
                    WHERE strftime('%Y', ScanTime) = @year
                    AND strftime('%m', ScanTime) = @month
                    ORDER BY ScanTime DESC
                    LIMIT @limit
                ";
                selectCmd.Parameters.AddWithValue("@year", year.ToString("0000"));
                selectCmd.Parameters.AddWithValue("@month", month.ToString("00"));
                selectCmd.Parameters.AddWithValue("@limit", limit);

                using var reader = selectCmd.ExecuteReader();
                while (reader.Read())
                {
                    records.Add(new ScanRecord
                    {
                        Id = reader.GetInt32(0),
                        STT = reader.GetInt32(1),
                        Barcode = reader.GetString(2),
                        NgayGio = reader.GetString(3),
                        KetQua = reader.GetString(4),
                        Ca = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        ScanTime = reader.IsDBNull(6) ? DateTime.MinValue : reader.GetDateTime(6)
                    });
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Database query error: {ex.Message}");
            }

            return records;
        }
    }

    public class ScanRecord
    {
        public int Id { get; set; }
        public int STT { get; set; }
        public string Barcode { get; set; } = string.Empty;
        public string NgayGio { get; set; } = string.Empty;
        public string KetQua { get; set; } = string.Empty;
        public string Ca { get; set; } = string.Empty;
        public DateTime ScanTime { get; set; }
    }
}

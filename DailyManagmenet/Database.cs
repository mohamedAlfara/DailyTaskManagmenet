using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DailyManagmenet
{
    internal class Database
    {
        public static string dbPath =Path.Combine( Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"Daily_manager.db");
        //C:\Users\Mohammed\Documents\Daily_manager.db

        public static string connectionString = $"Data Source={dbPath};Version=3;";

        
        public static void CreateDatabase()
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
            }
        }

        
        public static void CreateTables()
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();

                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Tasks(
                                        TaskID INTEGER PRIMARY KEY AUTOINCREMENT,
                                        UserID INTEGER NOT NULL,
                                        TaskName TEXT NOT NULL,
                                        Status INTEGER DEFAULT 0,
                                        Notes TEXT,
                                        TaskDate TEXT,
                                        Hours INTEGER,
                                        Color TEXT,
                                        FOREIGN KEY(UserID) REFERENCES Users(UserID)
                                       );
                       
 
                                       CREATE TABLE IF NOT EXISTS Users(
                                       UserID      INTEGER PRIMARY KEY AUTOINCREMENT,
                                       FullName    TEXT NOT NULL,
                                       Username    TEXT NOT NULL UNIQUE,
                                       Password    TEXT NOT NULL
                                       );                   
                    ";

                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}


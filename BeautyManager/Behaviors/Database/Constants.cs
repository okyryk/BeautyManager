using System;
using System.IO;

namespace BeautyManager.Behaviors.Database
{
    public static class Constants
    {
        public const string DatabaseFilename = "BeautyManagerSQLite.db3";

        /*public const SQLite.SQLiteOpenFlags Flags =
            // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;*/

        public static string DatabasePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                var basePath2 = Path.Combine(basePath, "BeautyManager");
                if (!Directory.Exists(basePath2))
				{
                    Directory.CreateDirectory(basePath2);
				}
                var path =  Path.Combine(basePath2, DatabaseFilename);
                return path;
            }
        }
    }
}

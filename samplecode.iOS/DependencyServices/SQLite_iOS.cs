using System;
using System.IO;
using samplecode.iOS.DependencyServices;
using samplecode.SQLiteORM;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_iOS))]
namespace samplecode.iOS.DependencyServices
{
    public class SQLite_iOS : ISQLite
    {
        public SQLite.SQLiteConnection GetSQLiteConnection()
        {
            var sqliteFilename = "testing.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryPath = Path.Combine(documentsPath, "..", "Library");
            var path = Path.Combine(libraryPath, sqliteFilename);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}

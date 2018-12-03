using System;
using System.IO;
using samplecode.Droid.DependencyServices;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteAndroid))]
namespace samplecode.Droid.DependencyServices
{
    public class SQLiteAndroid
    {
        public SQLite.SQLiteConnection GetSQLiteConnection()
        {
            var fileName = "ipman.db3";
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, fileName);

            var connection = new SQLite.SQLiteConnection(path, true);

            return connection;
        }
    }
}

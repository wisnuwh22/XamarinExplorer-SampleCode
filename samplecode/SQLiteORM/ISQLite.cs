using System;
namespace samplecode.SQLiteORM
{
    public interface ISQLite
    {
        SQLite.SQLiteConnection GetSQLiteConnection();
    }
}

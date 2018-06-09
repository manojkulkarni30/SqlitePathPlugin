using System;

namespace Plugin.SqlitePath
{
    /// <summary>
    /// SQLite Path Implementation for Android
    /// </summary>
    public class SqlitePathImplementation : ISqlitePath
    {
        public string GetDbPath(string fileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return System.IO.Path.Combine(path, fileName);
        }
    }
}

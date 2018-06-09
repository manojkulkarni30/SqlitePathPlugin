using System;

namespace Plugin.SqlitePath
{
    /// <summary>
    /// SQLite Path Implementation for iOS
    /// </summary>
    public class SqlitePathImplementation : ISqlitePath
    {
        public string GetDbPath(string fileName)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = System.IO.Path.Combine(docFolder, "..", "Library");

            if (!System.IO.Directory.Exists(libFolder))
            {
                System.IO.Directory.CreateDirectory(libFolder);
            }
            return System.IO.Path.Combine(libFolder, fileName);
        }
    }
}

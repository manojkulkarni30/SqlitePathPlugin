namespace Plugin.SqlitePath
{
    /// <summary>
    /// SQLite Path Implementation for UWP
    /// </summary>
    public class SqlitePathImplementation : ISqlitePath
    {
        public string GetDbPath(string fileName)
        {
            string path = global::Windows.Storage.ApplicationData.Current.LocalFolder.Path;
            return System.IO.Path.Combine(path, fileName);
        }
    }
}

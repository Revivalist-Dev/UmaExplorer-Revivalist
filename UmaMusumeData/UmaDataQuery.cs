using SQLite;
using System.Collections.Generic;

namespace UmaMusumeData
{
    public class TableName
    {
        [Column("name")]
        public string Name { get; set; } = "";
    }

    public static class UmaDataQuery
    {
        public static List<string> GetTableNames()
        {
            SQLiteConnection connection = new(UmaDataHelper.MasterFile, SQLiteOpenFlags.ReadOnly);
            List<TableName> tableNames = connection.Query<TableName>("SELECT name FROM sqlite_master WHERE type='table'");
            connection.Close();
            connection.Dispose();

            List<string> names = new();
            tableNames.ForEach(tn => names.Add(tn.Name));
            return names;
        }
    }
}
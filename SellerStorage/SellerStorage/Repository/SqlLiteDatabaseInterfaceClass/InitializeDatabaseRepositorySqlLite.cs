using System.Data.SQLite;
using System.IO;
using SellerStorage.Interface.SqlLite;
using SellerStorage.Repository.SqlLiteDataBase;

namespace SellerStorage.Repository.SqlLiteDatabaseInterfaceClass
{


    public class InitializeDatabaseRepositorySqlLite : ISqlLiteInitializeDataBase
    {
        private readonly SqlLiteCreateTableCommands _sqlLiteCreateTableCommands;

        public InitializeDatabaseRepositorySqlLite()
        {
            _sqlLiteCreateTableCommands = new SqlLiteCreateTableCommands();
        }

        public void InitializeDatabaseIfNotExists()
        {
            if (File.Exists(DatabaseConfiguration.DatabaseFile))
            {
#if DEBUG

#else
                return;
#endif
            }

            if (!Directory.Exists(DatabaseConfiguration.DatabaseFolder))
            {
                Directory.CreateDirectory(DatabaseConfiguration.DatabaseFolder);
            }
            else
            {
                DeleteLeftoverFilesAndFolders();
            }

            SQLiteConnection.CreateFile(DatabaseConfiguration.DatabaseFile);
        }

        public void DropAllTablesCommand()
        {
            var allTableCommands = _sqlLiteCreateTableCommands.GetTableCommand();

            foreach (var tableCommand in allTableCommands)
            {
                DropTable(tableCommand.Key);
            }
        }

        public void CreateAllTablesCommand()
        {
            var allTableCommands = _sqlLiteCreateTableCommands.GetTableCommand();

            foreach (var tableCommand in allTableCommands)
            {
                CreateTable(tableCommand.Value);
            }

        }

        #region Helpers

        private void DeleteLeftoverFilesAndFolders()
        {
            var directory = new DirectoryInfo(DatabaseConfiguration.DatabaseFolder);

            foreach (FileInfo file in directory.GetFiles())
            {
                file.Delete();
            }

            foreach (DirectoryInfo subdirectories in directory.GetDirectories())
            {
                subdirectories.Delete(true);
            }
        }

        private void DropTable(string tableName)
        {
            using (var dbConnection = new SQLiteConnection(DatabaseConfiguration.ConnectionString))
            {
                string dropTableQuery = $"DROP TABLE IF EXISTS [{tableName}]";
                SQLiteCommand tableCommand = new SQLiteCommand(dropTableQuery, dbConnection);
                tableCommand.ExecuteNonQuery();
            }
        }

        private void CreateTable(string tableCommand)
        {
            using (var dbConnection = new SQLiteConnection(DatabaseConfiguration.ConnectionString))
            {
                SQLiteCommand sqLiteCommand = new SQLiteCommand(tableCommand, dbConnection);
                sqLiteCommand.ExecuteNonQuery();
            }
        }

        #endregion
    }
}

using System.IO;
using SellerStorage.Interface.SqlLite;

namespace SellerStorage.Repository.SqlLiteDatabaseInterfaceClass
{
    public class InitializeDatabaseRepositorySqlLite : ISqlLiteInitializeDataBase
    {
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
        }

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
    }
}

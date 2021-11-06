using System.Data.SQLite;
using Dapper;
using SellerStorage.Interface.SqlLite;
using SellerStorage.Models;
using SellerStorage.Repository.SqlLiteDataBase;

namespace SellerStorage.Repository.SqlLiteDatabaseInterfaceClass
{
    public class SqLiteFullProductInfoRepository : ISqLiteFullProductInfoRepository
    {
        private readonly SqLiteDatabaseCallsCommands _callsCommands;

        public SqLiteFullProductInfoRepository()
        {
            _callsCommands = new SqLiteDatabaseCallsCommands();
        }

        public bool CreateNewProductInfo(FullProductInfoModel fullProductInfo)
        {
            int affectedRows;

            using (var dbConnection = new SQLiteConnection(DatabaseConfiguration.ConnectionString))
            {
                dbConnection.Open();

                string createNewCommand = _callsCommands.CreateNewFullProductInfoCommand(fullProductInfo);

                affectedRows = dbConnection.Execute(createNewCommand);
            }

            return affectedRows == 1;
        }
    }
}

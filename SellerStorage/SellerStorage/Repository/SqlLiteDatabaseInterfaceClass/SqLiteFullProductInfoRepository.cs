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

        public bool UpdateProductInfo(FullProductInfoModel fullProductInfo, int productId)
        {
            int affectedRows;

            using (var dbConnection = new SQLiteConnection(DatabaseConfiguration.ConnectionString))
            {
                dbConnection.Open();

                string createNewCommand = _callsCommands.UpdateFullProductInfoCommand(fullProductInfo, productId);

                affectedRows = dbConnection.Execute(createNewCommand);
            }

            return affectedRows == 1;
        }

        public FullProductInfoWithIdModel GetProductInfoById(int productId)
        {
            using (var dbConnection = new SQLiteConnection(DatabaseConfiguration.ConnectionString))
            {
                dbConnection.Open();

                string getInfoCommand = _callsCommands.GetFullProductInfoById(productId);

                FullProductInfoWithIdModel getProductInfo =
                    dbConnection.QuerySingle<FullProductInfoWithIdModel>(getInfoCommand);

                return getProductInfo;
            }
        }
    }
}

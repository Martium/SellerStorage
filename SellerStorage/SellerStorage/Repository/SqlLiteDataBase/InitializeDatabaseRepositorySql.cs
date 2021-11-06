using SellerStorage.Interface.SqlLite;

namespace SellerStorage.Repository.SqlLiteDataBase
{
    public class InitializeDatabaseRepositorySql
    {
        private readonly ISqlLiteInitializeDataBase _sqlLiteInitializeDataBase;

        public InitializeDatabaseRepositorySql(ISqlLiteInitializeDataBase sqlLiteInitializeDataBase)
        {
            _sqlLiteInitializeDataBase = sqlLiteInitializeDataBase;
        }

        public void InitializeDatabaseIfNotExists()
        {
            _sqlLiteInitializeDataBase.InitializeDatabaseIfNotExists();
        }

        public void DropAllTablesCommand()
        {
            _sqlLiteInitializeDataBase.DropAllTablesCommand();
        }

        public void CreateAllTableCommand()
        {
            _sqlLiteInitializeDataBase.CreateAllTablesCommand();
        }
    }
}

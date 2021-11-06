using SellerStorage.Interface;

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
    }
}

namespace SellerStorage.Interface.SqlLite
{
    public interface ISqlLiteInitializeDataBase
    {
        void InitializeDatabaseIfNotExists();
        void DropAllTablesCommand();
        void CreateAllTablesCommand();
        
    }
}

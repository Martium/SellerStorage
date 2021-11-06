using System;
using System.Threading;
using System.Windows.Forms;
using SellerStorage.Forms;
using SellerStorage.InterfaceHelpingClass;
using SellerStorage.Repository.SqlLiteDataBase;
using SellerStorage.Repository.SqlLiteDatabaseInterfaceClass;
using SellerStorage.Service;

namespace SellerStorage
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        private const string AppUuid = "60d19e3e-da46-45b2-b2ed-bf15d6746c28";

        private static MessageBoxService _messageBoxService;
        private static InitializeDatabaseRepositorySql _initializeDatabaseRepositorySql;

        [STAThread]
        static void Main()
        {
            _messageBoxService = new MessageBoxService(new MessageBoxBoxDialogService());
            _initializeDatabaseRepositorySql = new InitializeDatabaseRepositorySql(new InitializeDatabaseRepositorySqlLite());

            using (Mutex mutex = new Mutex(false, "Global\\" + AppUuid))
            {
                if (!mutex.WaitOne(0, false))
                {
                    _messageBoxService.ShowErrorMessage(@"Vienu metu galima paleisti tik vieną 'Seller Storage' aplikacija!");
                }

                bool isDataBaseInitialize = InitializeDatabase();

                if (isDataBaseInitialize)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new ListOfProductsFullInfoForm());
                }
            }
        }

        private static bool InitializeDatabase()
        {
            bool success = true;

            try
            {
                _initializeDatabaseRepositorySql.InitializeDatabaseIfNotExists();
                _initializeDatabaseRepositorySql.DropAllTablesCommand();
                _initializeDatabaseRepositorySql.CreateAllTableCommand();
                
            }
            catch (Exception e)
            {
                _messageBoxService.ShowErrorMessage(e.Message);
                success = false;
            }

            return success;
        }
    }
}

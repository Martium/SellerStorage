using System;
using System.Windows.Forms;
using SellerStorage.Forms;

namespace SellerStorage
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ListOfProductsFullInfoForm());
        }
    }
}

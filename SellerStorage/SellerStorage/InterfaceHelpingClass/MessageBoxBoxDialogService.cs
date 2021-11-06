using System.Windows.Forms;
using SellerStorage.Interface;

namespace SellerStorage.InterfaceHelpingClass
{
    public class MessageBoxBoxDialogService : IMessageBoxService
    {

        public void ShowInfoMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void ShowErrorMessage(string errorMessage)
        {
            MessageBox.Show(errorMessage);
        }
    }
}

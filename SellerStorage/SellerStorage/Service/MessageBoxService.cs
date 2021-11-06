using SellerStorage.Interface;

namespace SellerStorage.Service
{
    public class MessageBoxService
    {
        private readonly IMessageBoxService _messageBoxService;

        public MessageBoxService(IMessageBoxService messageBoxService)
        {
            _messageBoxService = messageBoxService;
        }

        public void ShowInfoMessage(string message)
        {
            _messageBoxService.ShowInfoMessage(message);
        }

        public void ShowErrorMessage(string errorMessage)
        {
            _messageBoxService.ShowErrorMessage(errorMessage);
        }
    }
}

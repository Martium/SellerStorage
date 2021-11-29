namespace SellerStorage.Interface
{
    public interface IMessageBoxService
    { 
        void ShowInfoMessage(string message);
        void ShowErrorMessage(string errorMessage);
    }
}

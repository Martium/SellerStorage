namespace SellerStorage.Interface.Service
{
    public interface ICalculatorService
    {
        string CalculateQuantityPriceToString(double unitPrice, int quantity);
        string CalculateAdditionalExpensesToString(double unitPrice, double expenses);
        string CalculateEuCurrencyRate(double currency, double euRate);
    }
}

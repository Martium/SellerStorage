namespace SellerStorage.Interface.Service
{
    public interface ICalculatorService
    {
        double CalculateQuantityPrice(double unitPrice, int quantity);
        double CalculateCurrencyExchangeRate(double productBuyCurrency, double euroCurrency);
        double CalculateFullProductExpenses(double unitPrice, double additionalExpenses);
        int CalculateProductQuantityBalance(int soldQuantity, int quantity); 
        string CalculateQuantityPriceToString(double unitPrice, int quantity);
    }
}

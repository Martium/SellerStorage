using SellerStorage.Interface.Service;

namespace SellerStorage.Service
{
    public class CalculatorService
    {
        private readonly ICalculatorService _calculatorService;

        public CalculatorService(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        public double CalculateQuantityPrice(double unitPrice, int quantity)
        {
            double result = _calculatorService.CalculateQuantityPrice(unitPrice, quantity);
            return result;
        }

        public string CalculateQuantityPriceToString(double unitPrice, int quantity)
        {
            string result = _calculatorService.CalculateQuantityPriceToString(unitPrice, quantity);
            return result;
        }

        public double ConvertToEuroCurrencyExchangeRate(double productPrice , double euroCurrency)
        {
            double result = _calculatorService.CalculateCurrencyExchangeRate(productPrice, euroCurrency);
            return result;
        }

        public double CalculateFullProductExpenses(double unitPrice, double additionalExpenses)
        {
            double result = _calculatorService.CalculateFullProductExpenses(unitPrice, additionalExpenses);
            return result;
        }

        public int CalculateProductQuantityBalance(int soldQuantity, int quantity)
        {
            int result = _calculatorService.CalculateProductQuantityBalance(soldQuantity, quantity);
            return result;
        }
    }
}

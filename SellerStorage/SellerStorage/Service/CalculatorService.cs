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

        public string CalculateQuantityPriceToString(double unitPrice, int quantity)
        {
            string result = _calculatorService.CalculateQuantityPriceToString(unitPrice, quantity);
            return result;
        }

        public string CalculateAdditionalExpensesToString(double unitPrice, double expenses)
        {
            string result = _calculatorService.CalculateAdditionalExpensesToString(unitPrice, expenses);
            return result;
        }

        public string CalculateEuCurrencyRate(double currency, double euRate)
        {
            string result = _calculatorService.CalculateEuCurrencyRate(currency, euRate);
            return result;
        }


    }
}

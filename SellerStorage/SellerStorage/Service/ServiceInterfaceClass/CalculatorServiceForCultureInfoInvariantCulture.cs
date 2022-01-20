using System;
using System.Globalization;
using SellerStorage.Interface.Service;

namespace SellerStorage.Service.ServiceInterfaceClass
{
    public class CalculatorServiceForCultureInfoInvariantCulture : ICalculatorService
    {
        private readonly CultureInfo _cultureInfo = CultureInfo.InvariantCulture;

        public string CalculateQuantityPriceToString(double unitPrice, int quantity)
        {
            double result = unitPrice * quantity;
            result = Math.Round(result, 2, MidpointRounding.ToEven);

            string convertToString = result.ToString(_cultureInfo);
            return convertToString;
        }

        public string CalculateAdditionalExpensesToString(double unitPrice, double expenses)
        {
            double result = unitPrice + expenses;
            result = Math.Round(result, 2, MidpointRounding.ToEven);

            string convertToString = result.ToString(_cultureInfo);
            return convertToString;
        }

        public string CalculateEuCurrencyRate(double currency, double euRate)
        {
            double result = currency / euRate;
            result = Math.Round(result, 2, MidpointRounding.ToEven);

            string convertToString = result.ToString(_cultureInfo);
            return convertToString;
        }
       
    }
}

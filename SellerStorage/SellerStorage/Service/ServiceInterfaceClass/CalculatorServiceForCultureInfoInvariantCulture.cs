using System;
using System.Globalization;
using SellerStorage.Interface.Service;

namespace SellerStorage.Service.ServiceInterfaceClass
{
    public class CalculatorServiceForCultureInfoInvariantCulture : ICalculatorService
    {
        public double CalculateQuantityPrice(double unitPrice, int quantity)
        {
            double result = unitPrice * quantity;
            result = Math.Round(result, 2, MidpointRounding.ToEven);
            return result;
        }

        public string CalculateQuantityPriceToString(double unitPrice, int quantity)
        {
            double result = unitPrice * quantity;
            result = Math.Round(result, 2, MidpointRounding.ToEven);

            string convertToString = result.ToString(CultureInfo.InvariantCulture);
            return convertToString;
        }

        public double CalculateCurrencyExchangeRate(double productBuyCurrency, double euroCurrency)
        {
            throw new NotImplementedException();
        }

        public double CalculateFullProductExpenses(double unitPrice, double additionalExpenses)
        {
            throw new NotImplementedException();
        }

        public int CalculateProductQuantityBalance(int soldQuantity, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}

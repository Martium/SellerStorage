using System.Globalization;
using SellerStorage.Interface.Service;

namespace SellerStorage.Service.ServiceInterfaceClass
{
    public class NumberServiceForCultureInfoInvariantCulture : INumberService
    {
        public int TryParseToNumberOrReturnZero(string value)
        {
            int number;
            bool isNumber = int.TryParse(value, out int numberResult);

            if (isNumber)
            {
                number = numberResult;
            }
            else
            {
                number = default;
            }

            return number;
        }

        public double TryParseToDoubleOrReturnZero(string value)
        {
            string newValue = ChangeCommaToDot(value);
            double number;
            bool isDouble = double.TryParse(newValue, NumberStyles.Any, CultureInfo.InvariantCulture, out double numberResult);

            if (isDouble)
            {
                number = numberResult;
            }
            else
            {
                number = 0;
            }

            return number;
        }

        public string ConvertDoubleToString(double number)
        {
            string convertedValue = number.ToString(CultureInfo.InvariantCulture);
            return convertedValue;
        }

        #region Helpers

        private string ChangeCommaToDot(string value)
        {
            string changeCommaToDot;

            bool isComma = value.Contains(",");

            if (isComma)
            {
                changeCommaToDot = value.Replace(",", ".");
            }
            else
            {
                changeCommaToDot = value;
            }

            return changeCommaToDot;

        }

        #endregion
    }
}

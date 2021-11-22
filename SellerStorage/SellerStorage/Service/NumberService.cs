using System;
using System.Globalization;

namespace SellerStorage.Service
{
    public class NumberService
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
            bool isDouble = double.TryParse(newValue, NumberStyles.Any, CultureInfo.InvariantCulture ,out double numberResult);

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

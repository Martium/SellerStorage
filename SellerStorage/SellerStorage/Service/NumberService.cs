using SellerStorage.Interface.Service;

namespace SellerStorage.Service
{
    public class NumberService 
    {
        private readonly INumberService _numberService;

        public NumberService(INumberService numberService)
        {
            _numberService = numberService;
        }

        public int TryParseToNumberOrReturnZero(string value)
        {
            int result = _numberService.TryParseToNumberOrReturnZero(value);
            return result;
        }

        public double TryParseToDoubleOrReturnZero(string value)
        {
            double result = _numberService.TryParseToDoubleOrReturnZero(value);
            return result;
        }

    }
}

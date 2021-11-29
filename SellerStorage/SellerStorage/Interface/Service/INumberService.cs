namespace SellerStorage.Interface.Service
{
    public interface INumberService
    { 
        int TryParseToNumberOrReturnZero(string value);
        double TryParseToDoubleOrReturnZero(string value);
    }
}

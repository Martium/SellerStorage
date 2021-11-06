namespace SellerStorage.Models
{
    public class FullProductInfoModel
    {
        public string ProductType { get; set; }
        public string ProductDescription { get; set; }

        public int ProductQuantity { get; set; }
        public int ProductQuantityLeft { get; set; }

        public string ProductOriginalCostPriceCurrency { get; set; }
        public string ProductAllQuantityCostPriceAtOriginalCurrency { get; set; }

        public double ProductQuantityPriceInEuro { get; set; }
        public double ProductAllQuantityPriceInEuro { get; set; }
        public double ProductExpensesPerQuantityUnit { get; set; }
        public double ProductExpectedSellingPrice { get; set; }
        public double ProductSoldPrice { get; set; }
        public double ProductProfit { get; set; }

    }
}

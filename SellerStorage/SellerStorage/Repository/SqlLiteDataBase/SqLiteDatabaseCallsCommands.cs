using SellerStorage.Models;

namespace SellerStorage.Repository.SqlLiteDataBase
{
    public class SqLiteDatabaseCallsCommands
    {
        private const string FullProductInfoTableName = "FullProductInfoTable";

        public string CreateNewFullProductInfoCommand(FullProductInfoModel fullProductInfoModel)
        {
            string createNewProductInfoCommand = 
                $@" INSERT INTO '{FullProductInfoTableName}'
                        Values ( NULL, 
                                '{fullProductInfoModel.ProductReceiptDate}', '{fullProductInfoModel.ProductType}', 
                                '{fullProductInfoModel.ProductDescription}', {fullProductInfoModel.ProductQuantity},
                                {fullProductInfoModel.ProductQuantityLeft}, '{fullProductInfoModel.ProductOriginalCostPriceCurrency}',
                                '{fullProductInfoModel.ProductAllQuantityCostPriceAtOriginalCurrency}',{fullProductInfoModel.ProductQuantityPriceInEuro},
                                {fullProductInfoModel.ProductAllQuantityPriceInEuro}, {fullProductInfoModel.ProductExpensesPerQuantityUnit},
                                {fullProductInfoModel.ProductExpectedSellingPrice}, {fullProductInfoModel.ProductSoldPrice},
                                {fullProductInfoModel.ProductProfit} )
                ";

            return createNewProductInfoCommand;
        }
    }
}

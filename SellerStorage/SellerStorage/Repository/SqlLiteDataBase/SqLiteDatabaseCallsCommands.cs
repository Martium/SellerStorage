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

        public string UpdateFullProductInfoCommand(FullProductInfoWithIdModel fullProductInfoModel)
        {
            string updateProductInfoCommand = 
                $@"
                      UPDATE '{FullProductInfoTableName}'
                        SET ProductReceiptDate = '{fullProductInfoModel.ProductReceiptDate}', ProductType = '{fullProductInfoModel.ProductType}',
                            ProductDescription = '{fullProductInfoModel.ProductDescription}', ProductQuantity = {fullProductInfoModel.ProductQuantity},
                            ProductQuantityLeft = {fullProductInfoModel.ProductQuantityLeft}, 
                            ProductOriginalCostPriceCurrency = '{fullProductInfoModel.ProductOriginalCostPriceCurrency}',
                            ProductAllQuantityCostPriceAtOriginalCurrency = '{fullProductInfoModel.ProductAllQuantityCostPriceAtOriginalCurrency}',
                            ProductQuantityPriceInEuro = {fullProductInfoModel.ProductQuantityPriceInEuro},
                            ProductAllQuantityPriceInEuro = {fullProductInfoModel.ProductAllQuantityPriceInEuro},
                            ProductExpensesPerQuantityUnit = {fullProductInfoModel.ProductExpensesPerQuantityUnit},
                            ProductExpectedSellingPrice = {fullProductInfoModel.ProductExpectedSellingPrice},
                            ProductSoldPrice = {fullProductInfoModel.ProductSoldPrice}, ProductProfit = {fullProductInfoModel.ProductProfit}
                        WHERE ProductId = {fullProductInfoModel.ProductId}
                ";

            return updateProductInfoCommand;
        }

        public string GetFullProductInfoById(int productId)
        {
            string getProductInfoById = 
                $@"
                    SELECT 
                        FPIT.ProductType, FPIT.ProductDescription, FPIT.ProductQuantity, FPIT.ProductQuantityLeft,
                        FPIT.ProductOriginalCostPriceCurrency, FPIT.ProductAllQuantityCostPriceAtOriginalCurrency,
                        FPIT.ProductQuantityPriceInEuro, FPIT.ProductAllQuantityPriceInEuro, FPIT.ProductExpensesPerQuantityUnit, FPIT.ProductExpectedSellingPrice,
                        FPIT.ProductSoldPrice, FPIT.ProductProfit
                    FROM {FullProductInfoTableName} FPIT
                    WHERE ProductId = {productId}
                ";

            return getProductInfoById;
        }
    }
}

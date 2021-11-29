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
                                '{fullProductInfoModel.ProductDescription}', '{fullProductInfoModel.ProductBuyPlace}', {fullProductInfoModel.ProductQuantity},
                                {fullProductInfoModel.ProductQuantityLeft}, '{fullProductInfoModel.ProductOriginalCostPriceCurrency}',
                                '{fullProductInfoModel.ProductAllQuantityCostPriceAtOriginalCurrency}',{fullProductInfoModel.ProductUnitPriceInEuro},
                                {fullProductInfoModel.ProductAllQuantityPriceInEuro}, {fullProductInfoModel.ProductExpensesPerQuantityUnit},
                                {fullProductInfoModel.ProductExpectedSellingPrice}, {fullProductInfoModel.ProductSoldPrice},
                                {fullProductInfoModel.ProductProfit} )
                ";

            return createNewProductInfoCommand;
        }

        public string UpdateFullProductInfoCommand(FullProductInfoModel fullProductInfoModel, int productId)
        {
            string updateProductInfoCommand = 
                $@"
                      UPDATE '{FullProductInfoTableName}'
                        SET ProductReceiptDate = '{fullProductInfoModel.ProductReceiptDate}', ProductType = '{fullProductInfoModel.ProductType}',
                            ProductDescription = '{fullProductInfoModel.ProductDescription}', ProductBuyPlace = '{fullProductInfoModel.ProductBuyPlace}',
                            ProductQuantity = {fullProductInfoModel.ProductQuantity},
                            ProductQuantityLeft = {fullProductInfoModel.ProductQuantityLeft}, 
                            ProductOriginalCostPriceCurrency = '{fullProductInfoModel.ProductOriginalCostPriceCurrency}',
                            ProductAllQuantityCostPriceAtOriginalCurrency = '{fullProductInfoModel.ProductAllQuantityCostPriceAtOriginalCurrency}',
                            ProductUnitPriceInEuro = {fullProductInfoModel.ProductUnitPriceInEuro},
                            ProductAllQuantityPriceInEuro = {fullProductInfoModel.ProductAllQuantityPriceInEuro},
                            ProductExpensesPerQuantityUnit = {fullProductInfoModel.ProductExpensesPerQuantityUnit},
                            ProductExpectedSellingPrice = {fullProductInfoModel.ProductExpectedSellingPrice},
                            ProductSoldPrice = {fullProductInfoModel.ProductSoldPrice}, ProductProfit = {fullProductInfoModel.ProductProfit}
                        WHERE ProductId = {productId}
                ";

            return updateProductInfoCommand;
        }

        public string GetFullProductInfoById(int productId)
        {
            string getProductInfoById =
                $@"
                    SELECT 
                        FPI.ProductId, 
                        FPI.ProductReceiptDate , FPI.ProductType , FPI.ProductDescription , FPI.ProductBuyPlace , FPI.ProductBuyPlace ,
                        FPI.ProductQuantity, FPI.ProductQuantityLeft ,
                        FPI.ProductOriginalCostPriceCurrency , FPI.ProductAllQuantityCostPriceAtOriginalCurrency ,
                        FPI.ProductUnitPriceInEuro , FPI.ProductAllQuantityPriceInEuro , FPI.ProductExpensesPerQuantityUnit ,
                        FPI.ProductExpectedSellingPrice ,
                        FPI.ProductSoldPrice , FPI.ProductProfit
                    FROM {FullProductInfoTableName} FPI
                    WHERE FPI.ProductId = {productId}
                ";
            return getProductInfoById;
        }

        public string GetAllProductInfo(string searchPhrase = null)
        {
            string getAllInfo = 
                $@"SELECT 
                        FPI.ProductId, 
                        FPI.ProductReceiptDate , FPI.ProductType , FPI.ProductDescription , FPI.ProductBuyPlace ,
                        FPI.ProductQuantity, FPI.ProductQuantityLeft ,
                        FPI.ProductOriginalCostPriceCurrency , FPI.ProductAllQuantityCostPriceAtOriginalCurrency ,
                        FPI.ProductUnitPriceInEuro , FPI.ProductAllQuantityPriceInEuro , FPI.ProductExpensesPerQuantityUnit ,
                        FPI.ProductExpectedSellingPrice ,
                        FPI.ProductSoldPrice , FPI.ProductProfit
                    FROM {FullProductInfoTableName} FPI
                ";

            if (!string.IsNullOrWhiteSpace(searchPhrase))
            {
                getAllInfo +=
                    $@"
                        WHERE
                          FPI.ProductId LIKE  @SearchPhrase OR FPI.ProductReceiptDate LIKE @SearchPhrase OR FPI.ProductType LIKE @SearchPhrase
                          OR FPI.ProductDescription LIKE  @SearchPhrase
                    ";
            }

            getAllInfo += "ORDER BY FPI.ProductId DESC";

            return getAllInfo;
        }
    }
}

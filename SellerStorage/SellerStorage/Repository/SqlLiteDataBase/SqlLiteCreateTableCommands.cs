using SellerStorage.Forms.Constants;

namespace SellerStorage.Repository.SqlLiteDataBase
{
    public class SqlLiteCreateTableCommands
    {
        public static string CreateFullProductInfoTable = 
            $@"
                CREATE TABLE [FullProductInfoTable]
                    [ProductId] [Integer] NOT NULL,
                    [ProductReceiptDate] [Date] NOT NULL,

                    [ProductType] [nvarchar] ({FormLengthLimitTextBox.ProductType}) NULL,
                    [ProductDescription] [nvarchar] ({FormLengthLimitTextBox.ProductDescription}) NULL,

                    [ProductQuantity] [Integer] ({FormLengthLimitTextBox.ProductQuantity}) NULL,
                    [ProductQuantityLeft] [Integer] ({FormLengthLimitTextBox.ProductQuantityLeft}) NULL,
                    
                    [ProductOriginalCostPriceCurrency] [nvarchar] ({FormLengthLimitTextBox.ProductOriginalCostPriceCurrency}) NULL,
                    [ProductAllQuantityCostPriceAtOriginalCurrency] [nvarchar] ({FormLengthLimitTextBox.ProductAllQuantityCostPriceAtOriginalCurrency}) NULL,
                    [ProductQuantityPriceInEuro] [Numeric] NULL,
                    [ProductAllQuantityPriceInEuro] [Numeric] NULL,
                    [ProductExpensesPerQuantityUnit] [Numeric] NULL,
                    [ProductExpectedSellingPrice] [Numeric] NULL,
                    [ProductSoldPrice] [Numeric] NULL,
                    [ProductProfit] [Numeric] NULL
            ";
    }
}

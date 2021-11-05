using System.ComponentModel;
using System.Windows.Forms;
using SellerStorage.Models;

namespace SellerStorage.Forms
{
    public partial class ListOfProductsFullInfoForm : Form
    {
        public ListOfProductsFullInfoForm()
        {
            InitializeComponent();
            SetDataGridColumnSize();
            FillFakeInfo();
        }

        #region Helpers

        private void SetDataGridColumnSize()
        {
            productsListDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FillFakeInfo()
        {
            BindingList<FullProductInfoModel> list = new BindingList<FullProductInfoModel>();

            productsListDataGridView.DataSource = list;

            for (int i = 1; i < 200; i++)
            {
                list.Add(new FullProductInfoModel()
                {
                    ProductType = "kazkas",
                    ProductDescription = "bazinga",

                    ProductQuantity = 2,
                    ProductQuantityLeft = 1,

                    ProductOriginalCostPriceCurrency = "5 zlotai",
                    ProductAllQuantityCostPriceAtOriginalCurrency = "10 zlotu",

                    ProductQuantityPriceInEuro = 1,
                    ProductAllQuantityPriceInEuro = 2,
                    ProductExpensesPerQuantityUnit = 0.5,
                    ProductExpectedSellingPrice = 2,
                    ProductProfit = 2,
                    ProductSoldPrice = 2

                });

            }
        }

        #endregion
    }
}

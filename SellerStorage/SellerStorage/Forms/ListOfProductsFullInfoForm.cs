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
            SetDataGridDefaultControl();
            FillFakeInfo();
        }

        private void OpenNewProductFormButton_Click(object sender, System.EventArgs e)
        {
            OpenAnotherForm(new NewProductForm());
        }

        private void CloseAnotherForm_Closed(object sender, System.EventArgs e)
        {
            this.Show();
        }

        #region Helpers

        private void SetDataGridDefaultControl()
        {
            ProductsListDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductsListDataGridView.AllowUserToResizeColumns = false;
            ProductsListDataGridView.AllowUserToAddRows = false;
            ProductsListDataGridView.AllowUserToDeleteRows = false;
            ProductsListDataGridView.AllowUserToOrderColumns = false;
        }

        private void FillFakeInfo()
        {
            BindingList<FullProductInfoModel> list = new BindingList<FullProductInfoModel>();

            ProductsListDataGridView.DataSource = list;

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

        private void OpenAnotherForm(Form form)
        {
            form.Closed += CloseAnotherForm_Closed;
            HideListOfProductsFullInfoForm(form);
        }

        private void HideListOfProductsFullInfoForm(Form form)
        {
            this.Hide();
            form.Show();

            if (this.WindowState == FormWindowState.Maximized)
            {
                form.WindowState = FormWindowState.Maximized;
            }
        }

        #endregion

    }
}

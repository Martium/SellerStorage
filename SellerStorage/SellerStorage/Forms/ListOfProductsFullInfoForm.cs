using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using SellerStorage.Enums;
using SellerStorage.Models;

namespace SellerStorage.Forms
{
    public partial class ListOfProductsFullInfoForm : Form
    {
        private const string DateFormat = "yyyy-MM-dd";
        public ListOfProductsFullInfoForm()
        {
            InitializeComponent();
            SetDataGridDefaultControl();
            FillFakeInfo();
        }

        private void OpenNewProductFormButton_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new NewProductForm(NewProductFormOperations.Create, null));
        }

        private void UpdateSelectedProductButton_Click(object sender, EventArgs e)
        {
            if (ProductsListDataGridView.Rows.Count != 0)
            {
                FullProductInfoWithIdModel getFullProductInfoWithId = GetAllProductInfo();
                OpenAnotherForm(new NewProductForm(NewProductFormOperations.Update, getFullProductInfoWithId));
            }
            else
            {
                OpenAnotherForm(new NewProductForm(NewProductFormOperations.Update, null));
            }
        }

        private void ProductsListDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductsListDataGridView.Rows.Count != 0)
            {
                UpdateSelectedProductButton_Click(this, new EventArgs());
            }
        }

        private void CloseAnotherForm_Closed(object sender, EventArgs e)
        {
            this.Show();
        }

        #region Helpers

        private void SetDataGridDefaultControl()
        {
            ProductsListDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductsListDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductsListDataGridView.AllowUserToResizeColumns = false;
            ProductsListDataGridView.AllowUserToAddRows = false;
            ProductsListDataGridView.AllowUserToDeleteRows = false;
            ProductsListDataGridView.AllowUserToOrderColumns = false;
            ProductsListDataGridView.AllowUserToResizeRows = false;

            ProductsListDataGridView.Columns[0].HeaderText = @"Id";
            ProductsListDataGridView.Columns[1].HeaderText = @"Data";
            ProductsListDataGridView.Columns[2].HeaderText = @"Produkto Tipas";
            ProductsListDataGridView.Columns[3].HeaderText = @"Aprašymas";

            ProductsListDataGridView.Columns[4].HeaderText = @"Kiekis";
            ProductsListDataGridView.Columns[5].HeaderText = @"Kiekio Likutis";
            ProductsListDataGridView.Columns[6].HeaderText = @"Vnt kaina pirktoje valiutoje";
            ProductsListDataGridView.Columns[7].HeaderText = @"Kiekio kaina pirktoje valiutoje";
            ProductsListDataGridView.Columns[8].HeaderText = @"Vnt kaina Eurais";
            ProductsListDataGridView.Columns[9].HeaderText = @"Kiekio kaina Eurais";
            ProductsListDataGridView.Columns[10].HeaderText = @"Produkto Vnt. išlaidos";

            ProductsListDataGridView.Columns[11].HeaderText = @"Planuojamas vnt pelnas";
            ProductsListDataGridView.Columns[12].HeaderText = @"Produkto kiekio pelnas";
            ProductsListDataGridView.Columns[13].HeaderText = @"Parduota vnt kaina";

        }

        private void FillFakeInfo()
        {
            BindingList<FullProductInfoWithIdModel> list = new BindingList<FullProductInfoWithIdModel>();

            ProductsListDataGridView.DataSource = list;

            for (int i = 1; i < 200; i++)
            {
                list.Add(new FullProductInfoWithIdModel()
                {
                    ProductId = i,
                    ProductReceiptDate = DateTime.Now.Date,
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

        private FullProductInfoWithIdModel GetAllProductInfo()
        {
            FullProductInfoWithIdModel getAllProductInfo = new FullProductInfoWithIdModel()
            {
                ProductId = int.Parse(ProductsListDataGridView.SelectedRows[0].Cells[0].Value.ToString()),
               
                ProductType = ProductsListDataGridView.SelectedRows[0].Cells[2].Value.ToString(),
                ProductDescription = ProductsListDataGridView.SelectedRows[0].Cells[3].Value.ToString(),

                ProductQuantity = int.Parse(ProductsListDataGridView.SelectedRows[0].Cells[4].Value.ToString()),
                ProductQuantityLeft = int.Parse(ProductsListDataGridView.SelectedRows[0].Cells[5].Value.ToString()),
                ProductOriginalCostPriceCurrency = ProductsListDataGridView.SelectedRows[0].Cells[6].Value.ToString(),
                ProductAllQuantityCostPriceAtOriginalCurrency = ProductsListDataGridView.SelectedRows[0].Cells[7].Value.ToString(),
                ProductQuantityPriceInEuro = double.Parse(ProductsListDataGridView.SelectedRows[0].Cells[8].Value.ToString()),
                ProductAllQuantityPriceInEuro = double.Parse(ProductsListDataGridView.SelectedRows[0].Cells[9].Value.ToString()),

                ProductExpensesPerQuantityUnit = double.Parse(ProductsListDataGridView.SelectedRows[0].Cells[10].Value.ToString()),
                ProductExpectedSellingPrice = double.Parse(ProductsListDataGridView.SelectedRows[0].Cells[11].Value.ToString()),
                ProductProfit = double.Parse(ProductsListDataGridView.SelectedRows[0].Cells[12].Value.ToString()),
                ProductSoldPrice = double.Parse(ProductsListDataGridView.SelectedRows[0].Cells[13].Value.ToString())

            };

            return getAllProductInfo;
        }

        #endregion

       
    }
}
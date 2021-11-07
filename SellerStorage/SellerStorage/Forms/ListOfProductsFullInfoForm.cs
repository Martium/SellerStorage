﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using SellerStorage.Enums;
using SellerStorage.Models;
using SellerStorage.Repository.SqlLiteDataBase;
using SellerStorage.Repository.SqlLiteDatabaseInterfaceClass;

namespace SellerStorage.Forms
{
    public partial class ListOfProductsFullInfoForm : Form
    {
        private const string DateFormat = "yyyy-MM-dd";
        private readonly FullProductInfoRepositorySql _fullProductInfoRepository;
        public ListOfProductsFullInfoForm()
        {
            _fullProductInfoRepository = new FullProductInfoRepositorySql(new SqLiteFullProductInfoRepository());
            InitializeComponent();
            SetDataGridDefaultControl();
            //FillFakeInfo();
        }

        private void ListOfProductsFullInfoForm_Load(object sender, EventArgs e)
        {
            LoadFullProductInfo();
        }

        private void OpenNewProductFormButton_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new NewProductForm(NewProductFormOperations.Create, null));
        }

        private void UpdateSelectedProductButton_Click(object sender, EventArgs e)
        {
            if (ProductsListDataGridView.Rows.Count != 0)
            {
                int productId = int.Parse(ProductsListDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                OpenAnotherForm(new NewProductForm(NewProductFormOperations.Update, productId));
            }
           
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchPhrase = SearchTextBox.Text;
            IEnumerable<FullProductInfoWithIdModel> loadFullProductInfo = _fullProductInfoRepository.GetAllProductInfo(searchPhrase);
            fullProductInfoWithIdModelBindingSource.DataSource = loadFullProductInfo;
            ProductsListDataGridView.DataSource = fullProductInfoWithIdModelBindingSource;
        }

        private void CancelSearchButton_Click(object sender, EventArgs e)
        {
            SearchTextBox.Text = default;
            LoadFullProductInfo();
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
            LoadFullProductInfo();
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
                    ProductReceiptDate = DateTime.Now.Date.ToString(CultureInfo.InvariantCulture),
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

        private void LoadFullProductInfo()
        {
            IEnumerable<FullProductInfoWithIdModel> loadFullProductInfo = _fullProductInfoRepository.GetAllProductInfo();
            fullProductInfoWithIdModelBindingSource.DataSource = loadFullProductInfo;
            ProductsListDataGridView.DataSource = fullProductInfoWithIdModelBindingSource;
        }



        #endregion
        
    }
}
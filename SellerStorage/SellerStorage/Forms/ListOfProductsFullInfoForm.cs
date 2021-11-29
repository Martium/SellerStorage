using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SellerStorage.Enums;
using SellerStorage.Forms.Constants;
using SellerStorage.Models;
using SellerStorage.Repository.SqlLiteDataBase;
using SellerStorage.Repository.SqlLiteDatabaseInterfaceClass;

namespace SellerStorage.Forms
{
    public partial class ListOfProductsFullInfoForm : Form
    {
        private readonly FullProductInfoRepositorySql _fullProductInfoRepository;

        public ListOfProductsFullInfoForm()
        {
            _fullProductInfoRepository = new FullProductInfoRepositorySql(new SqLiteFullProductInfoRepository());
            InitializeComponent();
            SetControlInitialState();
            SetTextBoxLength();
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
            TrySelectedFirstRowInDataGridView();
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
            TrySelectedFirstRowInDataGridView();
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
            ProductsListDataGridView.Columns[4].HeaderText = @"Pirkimo vieta";

            ProductsListDataGridView.Columns[5].HeaderText = @"Kiekis";
            ProductsListDataGridView.Columns[6].HeaderText = @"Kiekio Likutis";
            ProductsListDataGridView.Columns[7].HeaderText = @"Vnt kaina pirktoje valiutoje";
            ProductsListDataGridView.Columns[8].HeaderText = @"Kiekio kaina pirktoje valiutoje";
            ProductsListDataGridView.Columns[9].HeaderText = @"Vnt kaina Eurais";
            ProductsListDataGridView.Columns[10].HeaderText = @"Kiekio kaina Eurais";
            ProductsListDataGridView.Columns[11].HeaderText = @"Vnt kaina Eurais + išlaidos";

            ProductsListDataGridView.Columns[12].HeaderText = @"Pardavimo kaina";
            ProductsListDataGridView.Columns[13].HeaderText = @"Produota vienetų";
            ProductsListDataGridView.Columns[14].HeaderText = @"Pelnas";
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
            TrySelectedFirstRowInDataGridView();
        }

        private void TrySelectedFirstRowInDataGridView()
        {
            if (ProductsListDataGridView.Rows.Count != 0)
            {
                ProductsListDataGridView.Rows[0].Selected = true;
            }
        }

        private void SetTextBoxLength()
        {
            SearchTextBox.MaxLength = FormLengthLimitTextBox.ProductDescription;
        }

        private void SetControlInitialState()
        {
            SetDataGridDefaultControl();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        #endregion
    }
}
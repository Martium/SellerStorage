using System;
using System.Globalization;
using System.Windows.Forms;
using SellerStorage.Enums;
using SellerStorage.InterfaceHelpingClass;
using SellerStorage.Models;
using SellerStorage.Repository.SqlLiteDataBase;
using SellerStorage.Repository.SqlLiteDatabaseInterfaceClass;
using SellerStorage.Service;

namespace SellerStorage.Forms
{
    public partial class NewProductForm : Form
    {
        private const string DateFormat = "yyyy-MM-dd";

        private readonly NewProductFormOperations _productFormOperations;
        private readonly FullProductInfoRepositorySql _fullProductInfoRepository;
        private readonly MessageBoxService _messageBoxService;

        public NewProductForm(NewProductFormOperations productFormOperations, int? productId)
        {
            _productFormOperations = productFormOperations;
            _fullProductInfoRepository = new FullProductInfoRepositorySql(new SqLiteFullProductInfoRepository());
            _messageBoxService = new MessageBoxService(new MessageBoxBoxDialogService());

            InitializeComponent();

            if (_productFormOperations == NewProductFormOperations.Update && productId.HasValue)
            {
                FullProductInfoModel fullProductInfo = _fullProductInfoRepository.GetProductInfoById(productId.Value);
                FillTextBoxWithProductInfo(fullProductInfo, productId.Value);
            }
        }

        private void NewProductForm_Load(object sender, EventArgs e)
        {
            ChangeFormHeaderTextByOperation();
            ChangeFormCreateNewButtonHeaderTextByFormOperation();
        }

        private void CreateNewProductButton_Click(object sender, EventArgs e)
        {
            FullProductInfoModel getAllInfo = GetAllNewProductInfo();
            bool isSuccess = false;

            switch (_productFormOperations)
            {
                case NewProductFormOperations.Create:
                    isSuccess = _fullProductInfoRepository.CreateNewFullProductInfo(getAllInfo);
                    break;
                case NewProductFormOperations.Update:
                    int productId = int.Parse(ProductIdTextBox.Text);
                    isSuccess = _fullProductInfoRepository.UpdateFullProductInfo(productId,getAllInfo);
                    break;
            }

            ShowInfoMessageForSavedProduct(isSuccess);
        }

        #region Helpers

        private void ChangeFormHeaderTextByOperation()
        {
            switch (_productFormOperations)
            {
                case NewProductFormOperations.Create:
                    this.Text = @"Sukurti naują produktą";
                    break;
                case NewProductFormOperations.Update:
                    this.Text = @"Atnaujinti produktą";
                    break;
            }
        }

        private void ChangeFormCreateNewButtonHeaderTextByFormOperation()
        {
            switch (_productFormOperations)
            {
                case NewProductFormOperations.Create:
                    CreateNewProductButton.Text = @"Sukurti";
                    break;
                case NewProductFormOperations.Update:
                    CreateNewProductButton.Text = @"Atnaujinti";
                    break;
            }
        }

        private FullProductInfoModel GetAllNewProductInfo()
        {
            //todo defense programing before load this method

            var getAllNewProductInfo = new FullProductInfoModel()
            {
                ProductReceiptDate = DateTextBox.Text,
                ProductType = ProductTypeTextBox.Text,
                ProductDescription = ProductDescriptionTextBox.Text,

                ProductQuantity = int.Parse(ProductQuantityTextBox.Text),
                ProductQuantityLeft = int.Parse(ProductQuantityLeftTextBox.Text),

                ProductOriginalCostPriceCurrency = ProductOriginalCostPriceCurrencyTextBox.Text,
                ProductAllQuantityCostPriceAtOriginalCurrency = ProductAllQuantityCostPriceAtOriginalCurrencyTextBox.Text,

                ProductQuantityPriceInEuro = double.Parse(ProductQuantityPriceInEuroTextBox.Text, CultureInfo.InvariantCulture),
                ProductAllQuantityPriceInEuro = double.Parse(ProductAllQuantityPriceInEuroTextBox.Text,CultureInfo.InvariantCulture),

                ProductExpensesPerQuantityUnit = double.Parse(ProductExpensesPerQuantityUnitTextBox.Text, CultureInfo.InvariantCulture),
                ProductExpectedSellingPrice = double.Parse(ProductExpectedSellingPriceTextBox.Text, CultureInfo.InvariantCulture),
                ProductSoldPrice = double.Parse(ProductSoldPriceTextBox.Text, CultureInfo.InvariantCulture),
                ProductProfit = double.Parse(ProductProfitTextBox.Text, CultureInfo.InvariantCulture)
            };

            return getAllNewProductInfo;
        }

        private void ShowInfoMessageForSavedProduct(bool isSuccessfully)
        {
            if (isSuccessfully)
            {
                _messageBoxService.ShowInfoMessage("Išsaugota sekmingai");
            }
            else
            {
                _messageBoxService.ShowErrorMessage("nepavyko išsaugoti bandyti dar kartą arba kreiptis į Administratorių");
            }
        }

        private void FillTextBoxWithProductInfo(FullProductInfoModel fullProductInfo, int productId)
        {
            ProductIdTextBox.Text = productId.ToString();
            DateTextBox.Text = fullProductInfo.ProductReceiptDate;
            ProductTypeTextBox.Text = fullProductInfo.ProductType;
            ProductDescriptionTextBox.Text = fullProductInfo.ProductDescription;

            ProductQuantityTextBox.Text = fullProductInfo.ProductQuantity.ToString();
            ProductQuantityLeftTextBox.Text = fullProductInfo.ProductQuantityLeft.ToString();

            ProductOriginalCostPriceCurrencyTextBox.Text = fullProductInfo.ProductOriginalCostPriceCurrency;
            ProductAllQuantityCostPriceAtOriginalCurrencyTextBox.Text = fullProductInfo.ProductAllQuantityCostPriceAtOriginalCurrency;

            ProductQuantityPriceInEuroTextBox.Text = fullProductInfo.ProductQuantityPriceInEuro.ToString(CultureInfo.InvariantCulture);
            ProductAllQuantityPriceInEuroTextBox.Text = fullProductInfo.ProductAllQuantityPriceInEuro.ToString(CultureInfo.InvariantCulture);

            ProductExpensesPerQuantityUnitTextBox.Text = fullProductInfo.ProductExpensesPerQuantityUnit.ToString(CultureInfo.InvariantCulture);
            ProductExpectedSellingPriceTextBox.Text =
                fullProductInfo.ProductExpectedSellingPrice.ToString(CultureInfo.InvariantCulture);
            ProductSoldPriceTextBox.Text = fullProductInfo.ProductSoldPrice.ToString(CultureInfo.InvariantCulture);
            ProductProfitTextBox.Text = fullProductInfo.ProductProfit.ToString(CultureInfo.InvariantCulture);
        }

        #endregion
    }
}

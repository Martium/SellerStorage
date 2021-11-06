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
        private int? _productId;

        private readonly NewProductFormOperations _productFormOperations;
        private readonly FullProductInfoRepositorySql _fullProductInfoRepository;
        private readonly MessageBoxService _messageBoxService;

        public NewProductForm(NewProductFormOperations productFormOperations, int? productId)
        {
            _productFormOperations = productFormOperations;
            _fullProductInfoRepository = new FullProductInfoRepositorySql(new SqLiteFullProductInfoRepository());
            _messageBoxService = new MessageBoxService(new MessageBoxBoxDialogService());

            if (_productFormOperations == NewProductFormOperations.Update)
            {
                _productId = productId;
                FillProductTextBoxForUpdateOperation();
            }

            InitializeComponent();
        }

        private void NewProductForm_Load(object sender, EventArgs e)
        {
            ChangeFormHeaderTextByOperation();
            ChangeFormCreateNewButtonHeaderTextByFormOperation();
            FillProductTextBoxForUpdateOperation();
        }

        private void CreateNewProductButton_Click(object sender, EventArgs e)
        {
            FullProductInfoModel getAllInfo = GetAllNewProductInfo();
            bool isCreated = _fullProductInfoRepository.CreateNewFullProductInfo(getAllInfo);
            ShowInfoMessageForSavedProduct(isCreated);
        }

        #region Helpers

        private void ChangeFormHeaderTextByOperation()
        {
            switch (_productFormOperations)
            {
                case NewProductFormOperations.Create:
                    this.Text = "Sukurti naują produktą";
                    break;
                case NewProductFormOperations.Update:
                    this.Text = "Atnaujinti produktą";
                    break;
            }
        }

        private void ChangeFormCreateNewButtonHeaderTextByFormOperation()
        {
            switch (_productFormOperations)
            {
                case NewProductFormOperations.Create:
                    CreateNewProductButton.Text = "Sukurti";
                    break;
                case NewProductFormOperations.Update:
                    CreateNewProductButton.Text = "Atnaujinti";
                    break;
            }
        }

        private FullProductInfoModel GetAllNewProductInfo()
        {
            //todo defense programing before load this method

            var getAllNewProductInfo = new FullProductInfoModel()
            {
                ProductReceiptDate = DateTime.ParseExact(DateTextBox.Text, DateFormat, CultureInfo.InvariantCulture),
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

        private void FillProductTextBoxForUpdateOperation()
        {
            if (_productFormOperations == NewProductFormOperations.Update && _productId.HasValue)
            {
                FullProductInfoWithIdModel getFullInfoById =
                    _fullProductInfoRepository.GetProductInfoById(_productId.Value);
                FillTextBoxWithProductInfo(getFullInfoById);
            }
        }

        private void FillTextBoxWithProductInfo(FullProductInfoWithIdModel fullProductInfo)
        {
           // DateTextBox.Text = fullProductInfo.ProductReceiptDate.ToString(CultureInfo.InvariantCulture);
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

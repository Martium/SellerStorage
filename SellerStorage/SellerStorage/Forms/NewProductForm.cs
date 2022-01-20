using System;
using System.Globalization;
using System.Windows.Forms;
using SellerStorage.Enums;
using SellerStorage.Forms.Constants;
using SellerStorage.InterfaceHelpingClass;
using SellerStorage.Models;
using SellerStorage.Repository.SqlLiteDataBase;
using SellerStorage.Repository.SqlLiteDatabaseInterfaceClass;
using SellerStorage.Service;
using SellerStorage.Service.ServiceInterfaceClass;

namespace SellerStorage.Forms
{
    public partial class NewProductForm : Form
    {
        private readonly NewProductFormOperations _productFormOperations;
        private readonly FullProductInfoRepositorySql _fullProductInfoRepository;
        private readonly MessageBoxService _messageBoxService;
        private readonly NumberService _numberService;
        private readonly CalculatorService _calculatorService;

        private readonly int? _productId;

        private const string DateFormat = "yyyy-MM-dd";

        public NewProductForm(NewProductFormOperations productFormOperations, int? productId)
        {
            if (productId.HasValue)
            {
                _productId = productId.Value;
            }

            _productFormOperations = productFormOperations;
            _fullProductInfoRepository = new FullProductInfoRepositorySql(new SqLiteFullProductInfoRepository());
            _messageBoxService = new MessageBoxService(new MessageBoxBoxDialogService());
            _numberService = new NumberService(new NumberServiceForCultureInfoInvariantCulture());
            _calculatorService = new CalculatorService(new CalculatorServiceForCultureInfoInvariantCulture());

            InitializeComponent();
            SetTextBoxMaxLength();
            SetControlInitialState();
        }

        private void NewProductForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                //todo make labels and text box letters bigger 
            }

            if (WindowState == FormWindowState.Normal)
            {
                //todo make labels and text box letter default 
            }
        }

        private void NewProductForm_Load(object sender, EventArgs e)
        {
            ChangeFormHeaderTextByOperation();
            ChangeFormCreateNewButtonHeaderTextByFormOperation();

            if (_productFormOperations == NewProductFormOperations.Update && _productId.HasValue)
            {
                FullProductInfoModel fullProductInfo = _fullProductInfoRepository.GetProductInfoById(_productId.Value);
                FillTextBoxWithProductInfo(fullProductInfo, _productId.Value);
            }
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

        private void DateTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string dateTimeNow = DateTime.Now.Date.ToString(DateFormat);
            bool isValidDate = DateTime.TryParseExact(DateTextBox.Text, DateFormat, CultureInfo.InvariantCulture,
                DateTimeStyles.None, out _);

            if (string.IsNullOrWhiteSpace(DateTextBox.Text))
            {
                e.Cancel = true;
                CreateNewProductButton.Enabled = false;
                _messageBoxService.ShowErrorMessage($"Įveskite datą raudonam langelyje pvz {dateTimeNow}");
              
            }
            else if (isValidDate)
            {
                e.Cancel = false;
                CreateNewProductButton.Enabled = true;
            }
            else
            {
                e.Cancel = true;
                CreateNewProductButton.Enabled = false;
                _messageBoxService.ShowErrorMessage($"Įveskite teisingą datą raudonam langelyje pvz {dateTimeNow}");
            }
        }

        private void ProductQuantityTextBox_TextChanged(object sender, EventArgs e)
        {

            if (CheckIsNewProductOperationAndTextBoxIsNotNullWhiteSpace(ProductOriginalCostPriceCurrencyTextBox))
            {
                ChangeTextBoxTextForFullQuantityNewProductIfCalculationPossible(quantityTextBox: ProductQuantityTextBox, unitPriceTextBox: ProductOriginalCostPriceCurrencyTextBox, fullQuantityTextBox: ProductAllQuantityCostPriceAtOriginalCurrencyTextBox);
            }

            if (CheckIsNewProductOperationAndTextBoxIsNotNullWhiteSpace(ProductUnitPriceInEuroTextBox))
            {
                ChangeTextBoxTextForFullQuantityNewProductIfCalculationPossible(quantityTextBox: ProductQuantityTextBox,
                    unitPriceTextBox: ProductUnitPriceInEuroTextBox, fullQuantityTextBox: ProductAllQuantityPriceInEuroTextBox);
            }

            if (_productFormOperations == NewProductFormOperations.Create)
            {
                ProductQuantityLeftTextBox.Text = ProductQuantityTextBox.Text;
            }
        }

        private void ProductOriginalCostPriceCurrencyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CheckIsNewProductOperationAndTextBoxIsNotNullWhiteSpace(ProductQuantityTextBox))
            {
                ChangeTextBoxTextForFullQuantityNewProductIfCalculationPossible(quantityTextBox: ProductQuantityTextBox, unitPriceTextBox: ProductOriginalCostPriceCurrencyTextBox, fullQuantityTextBox: ProductAllQuantityCostPriceAtOriginalCurrencyTextBox);
            }

            if (CheckIsNewProductOperationAndTextBoxIsNotNullWhiteSpace(CurrencyRateTextBox))
            {
                TryConvertCurrencyToEuroIfPossible();
            }
        }

        private void ProductUnitPriceInEuroTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CheckIsNewProductOperationAndTextBoxIsNotNullWhiteSpace(ProductQuantityTextBox))
            {
                ChangeTextBoxTextForFullQuantityNewProductIfCalculationPossible(quantityTextBox: ProductQuantityTextBox, 
                    unitPriceTextBox: ProductUnitPriceInEuroTextBox, fullQuantityTextBox: ProductAllQuantityPriceInEuroTextBox);
            }

            if (CheckIsNewProductOperationAndTextBoxIsNotNullWhiteSpace(AdditionalExpensesTextBox))
            {
               ChangeProductExpensesForNewProductIfCalculationPossible();
            }
        }

        private void AdditionalExpensesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CheckIsNewProductOperationAndTextBoxIsNotNullWhiteSpace(ProductUnitPriceInEuroTextBox))
            {
                ChangeProductExpensesForNewProductIfCalculationPossible();
            }
        }

        private void CurrencyRateTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CheckIsNewProductOperationAndTextBoxIsNotNullWhiteSpace(ProductOriginalCostPriceCurrencyTextBox))
            {
                TryConvertCurrencyToEuroIfPossible();
            }
        }

        #region Helpers

        private void SetControlInitialState()
        {
            if (_productFormOperations == NewProductFormOperations.Create)
            {
                DateTextBox.Text = DateTime.Now.ToString(DateFormat);
            }

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

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
            var getAllNewProductInfo = new FullProductInfoModel()
            {
                ProductReceiptDate = DateTextBox.Text,
                ProductType = ProductTypeTextBox.Text,
                ProductDescription = ProductDescriptionTextBox.Text,
                ProductBuyPlace = ProductBuyPlaceTextBox.Text,

                ProductQuantity = _numberService.TryParseToNumberOrReturnZero(ProductQuantityTextBox.Text),
                ProductQuantityLeft = _numberService.TryParseToNumberOrReturnZero(ProductQuantityLeftTextBox.Text),

                ProductOriginalCostPriceCurrency = ProductOriginalCostPriceCurrencyTextBox.Text,
                ProductAllQuantityCostPriceAtOriginalCurrency = ProductAllQuantityCostPriceAtOriginalCurrencyTextBox.Text,

                ProductUnitPriceInEuro = _numberService.TryParseToDoubleOrReturnZero(ProductUnitPriceInEuroTextBox.Text),
                ProductAllQuantityPriceInEuro = _numberService.TryParseToDoubleOrReturnZero(ProductAllQuantityPriceInEuroTextBox.Text),

                ProductExpensesPerQuantityUnit = _numberService.TryParseToDoubleOrReturnZero(ProductExpensesPerQuantityUnitTextBox.Text),
                ProductExpectedSellingPrice = _numberService.TryParseToDoubleOrReturnZero(ProductExpectedSellingPriceTextBox.Text),
                ProductSoldPrice = _numberService.TryParseToDoubleOrReturnZero(ProductSoldPriceTextBox.Text),
                ProductProfit = _numberService.TryParseToDoubleOrReturnZero(ProductProfitTextBox.Text)
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
            ProductBuyPlaceTextBox.Text = fullProductInfo.ProductBuyPlace;

            ProductQuantityTextBox.Text = fullProductInfo.ProductQuantity.ToString();
            ProductQuantityLeftTextBox.Text = fullProductInfo.ProductQuantityLeft.ToString();

            ProductOriginalCostPriceCurrencyTextBox.Text = fullProductInfo.ProductOriginalCostPriceCurrency;
            ProductAllQuantityCostPriceAtOriginalCurrencyTextBox.Text = fullProductInfo.ProductAllQuantityCostPriceAtOriginalCurrency;

            ProductUnitPriceInEuroTextBox.Text = fullProductInfo.ProductUnitPriceInEuro.ToString(CultureInfo.InvariantCulture);
            ProductAllQuantityPriceInEuroTextBox.Text = fullProductInfo.ProductAllQuantityPriceInEuro.ToString(CultureInfo.InvariantCulture);

            ProductExpensesPerQuantityUnitTextBox.Text = fullProductInfo.ProductExpensesPerQuantityUnit.ToString(CultureInfo.InvariantCulture);
            ProductExpectedSellingPriceTextBox.Text =
                fullProductInfo.ProductExpectedSellingPrice.ToString(CultureInfo.InvariantCulture);
            ProductSoldPriceTextBox.Text = fullProductInfo.ProductSoldPrice.ToString(CultureInfo.InvariantCulture);
            ProductProfitTextBox.Text = fullProductInfo.ProductProfit.ToString(CultureInfo.InvariantCulture);
        }

        private void SetTextBoxMaxLength()
        {
            DateTextBox.MaxLength = FormLengthLimitTextBox.ProductReceiptDate;
            ProductTypeTextBox.MaxLength = FormLengthLimitTextBox.ProductType;
            ProductDescriptionTextBox.MaxLength = FormLengthLimitTextBox.ProductDescription;
            ProductBuyPlaceTextBox.MaxLength = FormLengthLimitTextBox.ProductBuyPlace;

            ProductQuantityTextBox.MaxLength = FormLengthLimitTextBox.ProductQuantity;
            ProductQuantityLeftTextBox.MaxLength = FormLengthLimitTextBox.ProductQuantityLeft;
            ProductOriginalCostPriceCurrencyTextBox.MaxLength = FormLengthLimitTextBox.ProductOriginalCostPriceCurrency;
            ProductAllQuantityCostPriceAtOriginalCurrencyTextBox.MaxLength =
                FormLengthLimitTextBox.ProductAllQuantityCostPriceAtOriginalCurrency;
            ProductUnitPriceInEuroTextBox.MaxLength = FormLengthLimitTextBox.ProductQuantityPriceInEuro;
            ProductAllQuantityPriceInEuroTextBox.MaxLength = FormLengthLimitTextBox.ProductAllQuantityPriceInEuro;
            ProductExpensesPerQuantityUnitTextBox.MaxLength = FormLengthLimitTextBox.ProductExpensesPerQuantityUnit;
            ProductExpectedSellingPriceTextBox.MaxLength = FormLengthLimitTextBox.ProductExpectedSellingPrice;
            ProductSoldPriceTextBox.MaxLength = FormLengthLimitTextBox.ProductSoldPrice;
            ProductProfitTextBox.MaxLength = FormLengthLimitTextBox.ProductProfit;
            CurrencyRateTextBox.MaxLength = FormLengthLimitTextBox.ProductOriginalCostPriceCurrency;
            AdditionalExpensesTextBox.MaxLength = FormLengthLimitTextBox.ProductExpensesPerQuantityUnit;
        }

        private bool CheckIsNewProductOperationAndTextBoxIsNotNullWhiteSpace(TextBox textBox)
        {
            bool isValid = _productFormOperations == NewProductFormOperations.Create &&
                           !string.IsNullOrWhiteSpace(textBox.Text);
            return isValid;
        }

        private void ChangeTextBoxTextForFullQuantityNewProductIfCalculationPossible(TextBox quantityTextBox, TextBox unitPriceTextBox, TextBox fullQuantityTextBox)
        {
            int quantity = _numberService.TryParseToNumberOrReturnZero(quantityTextBox.Text);
            double unitPrice = _numberService.TryParseToDoubleOrReturnZero(unitPriceTextBox.Text);

            if (quantity > 0 && unitPrice > 0)
            {
                string fullQuantity = _calculatorService.CalculateQuantityPriceToString(unitPrice, quantity);
                fullQuantityTextBox.Text = fullQuantity;
            }
            else
            {
                fullQuantityTextBox.Text = string.Empty;
            }
        }

        private void ChangeProductExpensesForNewProductIfCalculationPossible()
        {
            double unitPrice = _numberService.TryParseToDoubleOrReturnZero(ProductUnitPriceInEuroTextBox.Text);
            double expenses = _numberService.TryParseToDoubleOrReturnZero(AdditionalExpensesTextBox.Text);

            if (unitPrice > 0 && expenses > 0)
            {
                string result = _calculatorService.CalculateAdditionalExpensesToString(unitPrice, expenses);
                ProductExpensesPerQuantityUnitTextBox.Text = result;
            }
        }

        private void TryConvertCurrencyToEuroIfPossible()
        {
            double currency = _numberService.TryParseToDoubleOrReturnZero(ProductOriginalCostPriceCurrencyTextBox.Text);
            double euRate = _numberService.TryParseToDoubleOrReturnZero(CurrencyRateTextBox.Text);

            if (currency > 0 && euRate > 0)
            {
                string result = _calculatorService.CalculateEuCurrencyRate(currency, euRate);
                ProductUnitPriceInEuroTextBox.Text = result;
            }
        }

        #endregion
       
    }
}

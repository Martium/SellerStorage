
namespace SellerStorage.Forms
{
    partial class ListOfProductsFullInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ProductsListDataGridView = new System.Windows.Forms.DataGridView();
            this.OpenNewProductFormButton = new System.Windows.Forms.Button();
            this.fullProductInfoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productReceiptDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantityLeftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOriginalCostPriceCurrencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAllQuantityCostPriceAtOriginalCurrencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantityPriceInEuroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAllQuantityPriceInEuroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productExpensesPerQuantityUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productExpectedSellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSoldPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productProfitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullProductInfoModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsListDataGridView
            // 
            this.ProductsListDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsListDataGridView.AutoGenerateColumns = false;
            this.ProductsListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productReceiptDateDataGridViewTextBoxColumn,
            this.productTypeDataGridViewTextBoxColumn,
            this.productDescriptionDataGridViewTextBoxColumn,
            this.productQuantityDataGridViewTextBoxColumn,
            this.productQuantityLeftDataGridViewTextBoxColumn,
            this.productOriginalCostPriceCurrencyDataGridViewTextBoxColumn,
            this.productAllQuantityCostPriceAtOriginalCurrencyDataGridViewTextBoxColumn,
            this.productQuantityPriceInEuroDataGridViewTextBoxColumn,
            this.productAllQuantityPriceInEuroDataGridViewTextBoxColumn,
            this.productExpensesPerQuantityUnitDataGridViewTextBoxColumn,
            this.productExpectedSellingPriceDataGridViewTextBoxColumn,
            this.productSoldPriceDataGridViewTextBoxColumn,
            this.productProfitDataGridViewTextBoxColumn});
            this.ProductsListDataGridView.DataSource = this.fullProductInfoModelBindingSource;
            this.ProductsListDataGridView.Location = new System.Drawing.Point(12, 105);
            this.ProductsListDataGridView.Name = "ProductsListDataGridView";
            this.ProductsListDataGridView.Size = new System.Drawing.Size(1259, 433);
            this.ProductsListDataGridView.TabIndex = 1;
            // 
            // OpenNewProductFormButton
            // 
            this.OpenNewProductFormButton.Location = new System.Drawing.Point(12, 48);
            this.OpenNewProductFormButton.Name = "OpenNewProductFormButton";
            this.OpenNewProductFormButton.Size = new System.Drawing.Size(142, 40);
            this.OpenNewProductFormButton.TabIndex = 2;
            this.OpenNewProductFormButton.Text = "Pridėti naują produktą";
            this.OpenNewProductFormButton.UseVisualStyleBackColor = true;
            this.OpenNewProductFormButton.Click += new System.EventHandler(this.OpenNewProductFormButton_Click);
            // 
            // fullProductInfoModelBindingSource
            // 
            this.fullProductInfoModelBindingSource.DataSource = typeof(SellerStorage.Models.FullProductInfoModel);
            // 
            // productReceiptDateDataGridViewTextBoxColumn
            // 
            this.productReceiptDateDataGridViewTextBoxColumn.DataPropertyName = "ProductReceiptDate";
            this.productReceiptDateDataGridViewTextBoxColumn.HeaderText = "Data";
            this.productReceiptDateDataGridViewTextBoxColumn.Name = "productReceiptDateDataGridViewTextBoxColumn";
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            this.productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.HeaderText = "Produkto tipas";
            this.productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
            // 
            // productDescriptionDataGridViewTextBoxColumn
            // 
            this.productDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProductDescription";
            this.productDescriptionDataGridViewTextBoxColumn.HeaderText = "Produkto aprašymas";
            this.productDescriptionDataGridViewTextBoxColumn.Name = "productDescriptionDataGridViewTextBoxColumn";
            // 
            // productQuantityDataGridViewTextBoxColumn
            // 
            this.productQuantityDataGridViewTextBoxColumn.DataPropertyName = "ProductQuantity";
            this.productQuantityDataGridViewTextBoxColumn.HeaderText = "Produkto kiekis";
            this.productQuantityDataGridViewTextBoxColumn.Name = "productQuantityDataGridViewTextBoxColumn";
            // 
            // productQuantityLeftDataGridViewTextBoxColumn
            // 
            this.productQuantityLeftDataGridViewTextBoxColumn.DataPropertyName = "ProductQuantityLeft";
            this.productQuantityLeftDataGridViewTextBoxColumn.HeaderText = "Likes produkto kiekis";
            this.productQuantityLeftDataGridViewTextBoxColumn.Name = "productQuantityLeftDataGridViewTextBoxColumn";
            // 
            // productOriginalCostPriceCurrencyDataGridViewTextBoxColumn
            // 
            this.productOriginalCostPriceCurrencyDataGridViewTextBoxColumn.DataPropertyName = "ProductOriginalCostPriceCurrency";
            this.productOriginalCostPriceCurrencyDataGridViewTextBoxColumn.HeaderText = "Produkto kaina pirkta valiuta";
            this.productOriginalCostPriceCurrencyDataGridViewTextBoxColumn.Name = "productOriginalCostPriceCurrencyDataGridViewTextBoxColumn";
            // 
            // productAllQuantityCostPriceAtOriginalCurrencyDataGridViewTextBoxColumn
            // 
            this.productAllQuantityCostPriceAtOriginalCurrencyDataGridViewTextBoxColumn.DataPropertyName = "ProductAllQuantityCostPriceAtOriginalCurrency";
            this.productAllQuantityCostPriceAtOriginalCurrencyDataGridViewTextBoxColumn.HeaderText = "Produktų visa kaina pirkta valiuta";
            this.productAllQuantityCostPriceAtOriginalCurrencyDataGridViewTextBoxColumn.Name = "productAllQuantityCostPriceAtOriginalCurrencyDataGridViewTextBoxColumn";
            // 
            // productQuantityPriceInEuroDataGridViewTextBoxColumn
            // 
            this.productQuantityPriceInEuroDataGridViewTextBoxColumn.DataPropertyName = "ProductQuantityPriceInEuro";
            this.productQuantityPriceInEuroDataGridViewTextBoxColumn.HeaderText = "Produkto kaina Eurais";
            this.productQuantityPriceInEuroDataGridViewTextBoxColumn.Name = "productQuantityPriceInEuroDataGridViewTextBoxColumn";
            // 
            // productAllQuantityPriceInEuroDataGridViewTextBoxColumn
            // 
            this.productAllQuantityPriceInEuroDataGridViewTextBoxColumn.DataPropertyName = "ProductAllQuantityPriceInEuro";
            this.productAllQuantityPriceInEuroDataGridViewTextBoxColumn.HeaderText = "Produktų kaina Eurais";
            this.productAllQuantityPriceInEuroDataGridViewTextBoxColumn.Name = "productAllQuantityPriceInEuroDataGridViewTextBoxColumn";
            // 
            // productExpensesPerQuantityUnitDataGridViewTextBoxColumn
            // 
            this.productExpensesPerQuantityUnitDataGridViewTextBoxColumn.DataPropertyName = "ProductExpensesPerQuantityUnit";
            this.productExpensesPerQuantityUnitDataGridViewTextBoxColumn.HeaderText = "Produkto išlaidos";
            this.productExpensesPerQuantityUnitDataGridViewTextBoxColumn.Name = "productExpensesPerQuantityUnitDataGridViewTextBoxColumn";
            // 
            // productExpectedSellingPriceDataGridViewTextBoxColumn
            // 
            this.productExpectedSellingPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductExpectedSellingPrice";
            this.productExpectedSellingPriceDataGridViewTextBoxColumn.HeaderText = "Produkto pardavimo kaina";
            this.productExpectedSellingPriceDataGridViewTextBoxColumn.Name = "productExpectedSellingPriceDataGridViewTextBoxColumn";
            // 
            // productSoldPriceDataGridViewTextBoxColumn
            // 
            this.productSoldPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductSoldPrice";
            this.productSoldPriceDataGridViewTextBoxColumn.HeaderText = "Produkto parduota kaina";
            this.productSoldPriceDataGridViewTextBoxColumn.Name = "productSoldPriceDataGridViewTextBoxColumn";
            // 
            // productProfitDataGridViewTextBoxColumn
            // 
            this.productProfitDataGridViewTextBoxColumn.DataPropertyName = "ProductProfit";
            this.productProfitDataGridViewTextBoxColumn.HeaderText = "Bendras produkto pelnas";
            this.productProfitDataGridViewTextBoxColumn.Name = "productProfitDataGridViewTextBoxColumn";
            // 
            // ListOfProductsFullInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 588);
            this.Controls.Add(this.OpenNewProductFormButton);
            this.Controls.Add(this.ProductsListDataGridView);
            this.Name = "ListOfProductsFullInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produktai";
            ((System.ComponentModel.ISupportInitialize)(this.ProductsListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullProductInfoModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView ProductsListDataGridView;
        private System.Windows.Forms.BindingSource fullProductInfoModelBindingSource;
        private System.Windows.Forms.Button OpenNewProductFormButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn productReceiptDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityLeftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productOriginalCostPriceCurrencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAllQuantityCostPriceAtOriginalCurrencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityPriceInEuroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAllQuantityPriceInEuroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productExpensesPerQuantityUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productExpectedSellingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productSoldPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productProfitDataGridViewTextBoxColumn;
    }
}


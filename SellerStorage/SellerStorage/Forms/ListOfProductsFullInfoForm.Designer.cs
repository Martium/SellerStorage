
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
            this.UpdateSelectedProductButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CancelSearchButton = new System.Windows.Forms.Button();
            this.fullProductInfoWithIdModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullProductInfoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productReceiptDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBuyPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.fullProductInfoWithIdModelBindingSource)).BeginInit();
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
            this.productIdDataGridViewTextBoxColumn,
            this.productReceiptDateDataGridViewTextBoxColumn,
            this.productTypeDataGridViewTextBoxColumn,
            this.productDescriptionDataGridViewTextBoxColumn,
            this.productBuyPlaceDataGridViewTextBoxColumn,
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
            this.ProductsListDataGridView.DataSource = this.fullProductInfoWithIdModelBindingSource;
            this.ProductsListDataGridView.Location = new System.Drawing.Point(12, 105);
            this.ProductsListDataGridView.MultiSelect = false;
            this.ProductsListDataGridView.Name = "ProductsListDataGridView";
            this.ProductsListDataGridView.ReadOnly = true;
            this.ProductsListDataGridView.Size = new System.Drawing.Size(1259, 433);
            this.ProductsListDataGridView.TabIndex = 1;
            this.ProductsListDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsListDataGridView_CellDoubleClick);
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
            // UpdateSelectedProductButton
            // 
            this.UpdateSelectedProductButton.Location = new System.Drawing.Point(160, 48);
            this.UpdateSelectedProductButton.Name = "UpdateSelectedProductButton";
            this.UpdateSelectedProductButton.Size = new System.Drawing.Size(168, 40);
            this.UpdateSelectedProductButton.TabIndex = 3;
            this.UpdateSelectedProductButton.Text = "Atnaujinti pasirinktą produktą";
            this.UpdateSelectedProductButton.UseVisualStyleBackColor = true;
            this.UpdateSelectedProductButton.Click += new System.EventHandler(this.UpdateSelectedProductButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(353, 68);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(126, 20);
            this.SearchTextBox.TabIndex = 4;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(485, 66);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Ieškoti";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CancelSearchButton
            // 
            this.CancelSearchButton.Location = new System.Drawing.Point(566, 66);
            this.CancelSearchButton.Name = "CancelSearchButton";
            this.CancelSearchButton.Size = new System.Drawing.Size(75, 23);
            this.CancelSearchButton.TabIndex = 6;
            this.CancelSearchButton.Text = "Atšaukti";
            this.CancelSearchButton.UseVisualStyleBackColor = true;
            this.CancelSearchButton.Click += new System.EventHandler(this.CancelSearchButton_Click);
            // 
            // fullProductInfoWithIdModelBindingSource
            // 
            this.fullProductInfoWithIdModelBindingSource.DataSource = typeof(SellerStorage.Models.FullProductInfoWithIdModel);
            // 
            // fullProductInfoModelBindingSource
            // 
            this.fullProductInfoModelBindingSource.DataSource = typeof(SellerStorage.Models.FullProductInfoModel);
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productReceiptDateDataGridViewTextBoxColumn
            // 
            this.productReceiptDateDataGridViewTextBoxColumn.DataPropertyName = "ProductReceiptDate";
            this.productReceiptDateDataGridViewTextBoxColumn.HeaderText = "ProductReceiptDate";
            this.productReceiptDateDataGridViewTextBoxColumn.Name = "productReceiptDateDataGridViewTextBoxColumn";
            this.productReceiptDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            this.productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.HeaderText = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
            this.productTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productDescriptionDataGridViewTextBoxColumn
            // 
            this.productDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProductDescription";
            this.productDescriptionDataGridViewTextBoxColumn.HeaderText = "ProductDescription";
            this.productDescriptionDataGridViewTextBoxColumn.Name = "productDescriptionDataGridViewTextBoxColumn";
            this.productDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBuyPlaceDataGridViewTextBoxColumn
            // 
            this.productBuyPlaceDataGridViewTextBoxColumn.DataPropertyName = "ProductBuyPlace";
            this.productBuyPlaceDataGridViewTextBoxColumn.HeaderText = "ProductBuyPlace";
            this.productBuyPlaceDataGridViewTextBoxColumn.Name = "productBuyPlaceDataGridViewTextBoxColumn";
            this.productBuyPlaceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productQuantityDataGridViewTextBoxColumn
            // 
            this.productQuantityDataGridViewTextBoxColumn.DataPropertyName = "ProductQuantity";
            this.productQuantityDataGridViewTextBoxColumn.HeaderText = "ProductQuantity";
            this.productQuantityDataGridViewTextBoxColumn.Name = "productQuantityDataGridViewTextBoxColumn";
            this.productQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productQuantityLeftDataGridViewTextBoxColumn
            // 
            this.productQuantityLeftDataGridViewTextBoxColumn.DataPropertyName = "ProductQuantityLeft";
            this.productQuantityLeftDataGridViewTextBoxColumn.HeaderText = "ProductQuantityLeft";
            this.productQuantityLeftDataGridViewTextBoxColumn.Name = "productQuantityLeftDataGridViewTextBoxColumn";
            this.productQuantityLeftDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productOriginalCostPriceCurrencyDataGridViewTextBoxColumn
            // 
            this.productOriginalCostPriceCurrencyDataGridViewTextBoxColumn.DataPropertyName = "ProductOriginalCostPriceCurrency";
            this.productOriginalCostPriceCurrencyDataGridViewTextBoxColumn.HeaderText = "ProductOriginalCostPriceCurrency";
            this.productOriginalCostPriceCurrencyDataGridViewTextBoxColumn.Name = "productOriginalCostPriceCurrencyDataGridViewTextBoxColumn";
            this.productOriginalCostPriceCurrencyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productAllQuantityCostPriceAtOriginalCurrencyDataGridViewTextBoxColumn
            // 
            this.productAllQuantityCostPriceAtOriginalCurrencyDataGridViewTextBoxColumn.DataPropertyName = "ProductAllQuantityCostPriceAtOriginalCurrency";
            this.productAllQuantityCostPriceAtOriginalCurrencyDataGridViewTextBoxColumn.HeaderText = "ProductAllQuantityCostPriceAtOriginalCurrency";
            this.productAllQuantityCostPriceAtOriginalCurrencyDataGridViewTextBoxColumn.Name = "productAllQuantityCostPriceAtOriginalCurrencyDataGridViewTextBoxColumn";
            this.productAllQuantityCostPriceAtOriginalCurrencyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productQuantityPriceInEuroDataGridViewTextBoxColumn
            // 
            this.productQuantityPriceInEuroDataGridViewTextBoxColumn.DataPropertyName = "ProductQuantityPriceInEuro";
            this.productQuantityPriceInEuroDataGridViewTextBoxColumn.HeaderText = "ProductQuantityPriceInEuro";
            this.productQuantityPriceInEuroDataGridViewTextBoxColumn.Name = "productQuantityPriceInEuroDataGridViewTextBoxColumn";
            this.productQuantityPriceInEuroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productAllQuantityPriceInEuroDataGridViewTextBoxColumn
            // 
            this.productAllQuantityPriceInEuroDataGridViewTextBoxColumn.DataPropertyName = "ProductAllQuantityPriceInEuro";
            this.productAllQuantityPriceInEuroDataGridViewTextBoxColumn.HeaderText = "ProductAllQuantityPriceInEuro";
            this.productAllQuantityPriceInEuroDataGridViewTextBoxColumn.Name = "productAllQuantityPriceInEuroDataGridViewTextBoxColumn";
            this.productAllQuantityPriceInEuroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productExpensesPerQuantityUnitDataGridViewTextBoxColumn
            // 
            this.productExpensesPerQuantityUnitDataGridViewTextBoxColumn.DataPropertyName = "ProductExpensesPerQuantityUnit";
            this.productExpensesPerQuantityUnitDataGridViewTextBoxColumn.HeaderText = "ProductExpensesPerQuantityUnit";
            this.productExpensesPerQuantityUnitDataGridViewTextBoxColumn.Name = "productExpensesPerQuantityUnitDataGridViewTextBoxColumn";
            this.productExpensesPerQuantityUnitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productExpectedSellingPriceDataGridViewTextBoxColumn
            // 
            this.productExpectedSellingPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductExpectedSellingPrice";
            this.productExpectedSellingPriceDataGridViewTextBoxColumn.HeaderText = "ProductExpectedSellingPrice";
            this.productExpectedSellingPriceDataGridViewTextBoxColumn.Name = "productExpectedSellingPriceDataGridViewTextBoxColumn";
            this.productExpectedSellingPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productSoldPriceDataGridViewTextBoxColumn
            // 
            this.productSoldPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductSoldPrice";
            this.productSoldPriceDataGridViewTextBoxColumn.HeaderText = "ProductSoldPrice";
            this.productSoldPriceDataGridViewTextBoxColumn.Name = "productSoldPriceDataGridViewTextBoxColumn";
            this.productSoldPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productProfitDataGridViewTextBoxColumn
            // 
            this.productProfitDataGridViewTextBoxColumn.DataPropertyName = "ProductProfit";
            this.productProfitDataGridViewTextBoxColumn.HeaderText = "ProductProfit";
            this.productProfitDataGridViewTextBoxColumn.Name = "productProfitDataGridViewTextBoxColumn";
            this.productProfitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ListOfProductsFullInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 588);
            this.Controls.Add(this.CancelSearchButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.UpdateSelectedProductButton);
            this.Controls.Add(this.OpenNewProductFormButton);
            this.Controls.Add(this.ProductsListDataGridView);
            this.Name = "ListOfProductsFullInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produktai";
            this.Load += new System.EventHandler(this.ListOfProductsFullInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullProductInfoWithIdModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullProductInfoModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ProductsListDataGridView;
        private System.Windows.Forms.BindingSource fullProductInfoModelBindingSource;
        private System.Windows.Forms.Button OpenNewProductFormButton;
        private System.Windows.Forms.BindingSource fullProductInfoWithIdModelBindingSource;
        private System.Windows.Forms.Button UpdateSelectedProductButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button CancelSearchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productReceiptDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productBuyPlaceDataGridViewTextBoxColumn;
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


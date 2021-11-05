
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
            this.productsListDataGridView = new System.Windows.Forms.DataGridView();
            this.fullProductInfoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.productsListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullProductInfoModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productsListDataGridView
            // 
            this.productsListDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsListDataGridView.AutoGenerateColumns = false;
            this.productsListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.productsListDataGridView.DataSource = this.fullProductInfoModelBindingSource;
            this.productsListDataGridView.Location = new System.Drawing.Point(12, 105);
            this.productsListDataGridView.Name = "productsListDataGridView";
            this.productsListDataGridView.Size = new System.Drawing.Size(1259, 433);
            this.productsListDataGridView.TabIndex = 1;
            // 
            // fullProductInfoModelBindingSource
            // 
            this.fullProductInfoModelBindingSource.DataSource = typeof(SellerStorage.Models.FullProductInfoModel);
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            this.productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.HeaderText = "Produkto Tipas";
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
            this.productQuantityLeftDataGridViewTextBoxColumn.HeaderText = "Prodkuto kiekio likutis";
            this.productQuantityLeftDataGridViewTextBoxColumn.Name = "productQuantityLeftDataGridViewTextBoxColumn";
            // 
            // productOriginalCostPriceCurrencyDataGridViewTextBoxColumn
            // 
            this.productOriginalCostPriceCurrencyDataGridViewTextBoxColumn.DataPropertyName = "ProductOriginalCostPriceCurrency";
            this.productOriginalCostPriceCurrencyDataGridViewTextBoxColumn.HeaderText = "Produkto pirkimo kaina";
            this.productOriginalCostPriceCurrencyDataGridViewTextBoxColumn.Name = "productOriginalCostPriceCurrencyDataGridViewTextBoxColumn";
            // 
            // productAllQuantityCostPriceAtOriginalCurrencyDataGridViewTextBoxColumn
            // 
            this.productAllQuantityCostPriceAtOriginalCurrencyDataGridViewTextBoxColumn.DataPropertyName = "ProductAllQuantityCostPriceAtOriginalCurrency";
            this.productAllQuantityCostPriceAtOriginalCurrencyDataGridViewTextBoxColumn.HeaderText = "Produkto kiekio pirkimo kaina ";
            this.productAllQuantityCostPriceAtOriginalCurrencyDataGridViewTextBoxColumn.Name = "productAllQuantityCostPriceAtOriginalCurrencyDataGridViewTextBoxColumn";
            // 
            // productQuantityPriceInEuroDataGridViewTextBoxColumn
            // 
            this.productQuantityPriceInEuroDataGridViewTextBoxColumn.DataPropertyName = "ProductQuantityPriceInEuro";
            this.productQuantityPriceInEuroDataGridViewTextBoxColumn.HeaderText = "Produkto pirkimo kaina Eurais";
            this.productQuantityPriceInEuroDataGridViewTextBoxColumn.Name = "productQuantityPriceInEuroDataGridViewTextBoxColumn";
            // 
            // productAllQuantityPriceInEuroDataGridViewTextBoxColumn
            // 
            this.productAllQuantityPriceInEuroDataGridViewTextBoxColumn.DataPropertyName = "ProductAllQuantityPriceInEuro";
            this.productAllQuantityPriceInEuroDataGridViewTextBoxColumn.HeaderText = "Produkto pirkimo kiekio kaina Eurais";
            this.productAllQuantityPriceInEuroDataGridViewTextBoxColumn.Name = "productAllQuantityPriceInEuroDataGridViewTextBoxColumn";
            // 
            // productExpensesPerQuantityUnitDataGridViewTextBoxColumn
            // 
            this.productExpensesPerQuantityUnitDataGridViewTextBoxColumn.DataPropertyName = "ProductExpensesPerQuantityUnit";
            this.productExpensesPerQuantityUnitDataGridViewTextBoxColumn.HeaderText = "Produkto išlaidų kaina";
            this.productExpensesPerQuantityUnitDataGridViewTextBoxColumn.Name = "productExpensesPerQuantityUnitDataGridViewTextBoxColumn";
            // 
            // productExpectedSellingPriceDataGridViewTextBoxColumn
            // 
            this.productExpectedSellingPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductExpectedSellingPrice";
            this.productExpectedSellingPriceDataGridViewTextBoxColumn.HeaderText = "Produkto Pardavimo kaina";
            this.productExpectedSellingPriceDataGridViewTextBoxColumn.Name = "productExpectedSellingPriceDataGridViewTextBoxColumn";
            // 
            // productSoldPriceDataGridViewTextBoxColumn
            // 
            this.productSoldPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductSoldPrice";
            this.productSoldPriceDataGridViewTextBoxColumn.HeaderText = "Produkto parduota ";
            this.productSoldPriceDataGridViewTextBoxColumn.Name = "productSoldPriceDataGridViewTextBoxColumn";
            // 
            // productProfitDataGridViewTextBoxColumn
            // 
            this.productProfitDataGridViewTextBoxColumn.DataPropertyName = "ProductProfit";
            this.productProfitDataGridViewTextBoxColumn.HeaderText = "Produkto bendras pelnas";
            this.productProfitDataGridViewTextBoxColumn.Name = "productProfitDataGridViewTextBoxColumn";
            // 
            // ListOfProductsFullInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 588);
            this.Controls.Add(this.productsListDataGridView);
            this.Name = "ListOfProductsFullInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produktai";
            ((System.ComponentModel.ISupportInitialize)(this.productsListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullProductInfoModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView productsListDataGridView;
        private System.Windows.Forms.BindingSource fullProductInfoModelBindingSource;
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


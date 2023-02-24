namespace FuelStation.Win {
    partial class TransactionsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.grdTransactions = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransactionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionEmployee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionsTotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionsPaymentMethod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelTransactions = new System.Windows.Forms.Label();
            this.labelTransactionLines = new System.Windows.Forms.Label();
            this.bsTransactions = new System.Windows.Forms.BindingSource(this.components);
            this.bsTransactionLines = new System.Windows.Forms.BindingSource(this.components);
            this.grdTransactionLines = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.colTransactionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionsCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTranLineID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTranLineTransactionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTranLineItemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTranLineQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTranLineItemPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTranLineNetValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTranLineDiscountValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTranLineTotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(681, 457);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 43);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // grdTransactions
            // 
            this.grdTransactions.Location = new System.Drawing.Point(12, 44);
            this.grdTransactions.MainView = this.gridView1;
            this.grdTransactions.Name = "grdTransactions";
            this.grdTransactions.Size = new System.Drawing.Size(776, 178);
            this.grdTransactions.TabIndex = 6;
            this.grdTransactions.UseEmbeddedNavigator = true;
            this.grdTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransactionDate,
            this.colTransactionEmployee,
            this.colTransactionsTotalValue,
            this.colTransactionsPaymentMethod,
            this.colTransactionID,
            this.colTransactionsCustomerId});
            this.gridView1.GridControl = this.grdTransactions;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTransactionDate
            // 
            this.colTransactionDate.Caption = "Date";
            this.colTransactionDate.FieldName = "Date";
            this.colTransactionDate.Name = "colTransactionDate";
            this.colTransactionDate.Visible = true;
            this.colTransactionDate.VisibleIndex = 1;
            // 
            // colTransactionEmployee
            // 
            this.colTransactionEmployee.Caption = "Employee";
            this.colTransactionEmployee.FieldName = "EmployeeID";
            this.colTransactionEmployee.Name = "colTransactionEmployee";
            this.colTransactionEmployee.Visible = true;
            this.colTransactionEmployee.VisibleIndex = 2;
            // 
            // colTransactionsTotalValue
            // 
            this.colTransactionsTotalValue.Caption = "Total Value";
            this.colTransactionsTotalValue.FieldName = "TotalValue";
            this.colTransactionsTotalValue.Name = "colTransactionsTotalValue";
            this.colTransactionsTotalValue.Visible = true;
            this.colTransactionsTotalValue.VisibleIndex = 3;
            // 
            // colTransactionsPaymentMethod
            // 
            this.colTransactionsPaymentMethod.Caption = "Payment Method";
            this.colTransactionsPaymentMethod.FieldName = "PaymentMethod";
            this.colTransactionsPaymentMethod.Name = "colTransactionsPaymentMethod";
            this.colTransactionsPaymentMethod.Visible = true;
            this.colTransactionsPaymentMethod.VisibleIndex = 0;
            // 
            // labelTransactions
            // 
            this.labelTransactions.AutoSize = true;
            this.labelTransactions.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTransactions.Location = new System.Drawing.Point(22, 9);
            this.labelTransactions.Name = "labelTransactions";
            this.labelTransactions.Size = new System.Drawing.Size(144, 32);
            this.labelTransactions.TabIndex = 5;
            this.labelTransactions.Text = "Transactions";
            // 
            // labelTransactionLines
            // 
            this.labelTransactionLines.AutoSize = true;
            this.labelTransactionLines.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTransactionLines.Location = new System.Drawing.Point(22, 225);
            this.labelTransactionLines.Name = "labelTransactionLines";
            this.labelTransactionLines.Size = new System.Drawing.Size(195, 32);
            this.labelTransactionLines.TabIndex = 8;
            this.labelTransactionLines.Text = "Transaction Lines";
            // 
            // grdTransactionLines
            // 
            this.grdTransactionLines.Location = new System.Drawing.Point(12, 260);
            this.grdTransactionLines.MainView = this.gridView2;
            this.grdTransactionLines.Name = "grdTransactionLines";
            this.grdTransactionLines.Size = new System.Drawing.Size(776, 191);
            this.grdTransactionLines.TabIndex = 9;
            this.grdTransactionLines.UseEmbeddedNavigator = true;
            this.grdTransactionLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTranLineID,
            this.colTranLineTransactionID,
            this.colTranLineItemID,
            this.colTranLineQuantity,
            this.colTranLineItemPrice,
            this.colTranLineNetValue,
            this.colTranLineDiscountValue,
            this.colTranLineTotalValue});
            this.gridView2.GridControl = this.grdTransactionLines;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(568, 457);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 43);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // colTransactionID
            // 
            this.colTransactionID.Caption = "ID";
            this.colTransactionID.FieldName = "ID";
            this.colTransactionID.Name = "colTransactionID";
            // 
            // colTransactionsCustomerId
            // 
            this.colTransactionsCustomerId.Caption = "CustomerID";
            this.colTransactionsCustomerId.FieldName = "CustomerID";
            this.colTransactionsCustomerId.Name = "colTransactionsCustomerId";
            // 
            // colTranLineID
            // 
            this.colTranLineID.Caption = "ID";
            this.colTranLineID.FieldName = "ID";
            this.colTranLineID.Name = "colTranLineID";
            // 
            // colTranLineTransactionID
            // 
            this.colTranLineTransactionID.Caption = "TransactionID";
            this.colTranLineTransactionID.FieldName = "TransactionID";
            this.colTranLineTransactionID.Name = "colTranLineTransactionID";
            // 
            // colTranLineItemID
            // 
            this.colTranLineItemID.Caption = "Item";
            this.colTranLineItemID.FieldName = "ItemID";
            this.colTranLineItemID.Name = "colTranLineItemID";
            this.colTranLineItemID.Visible = true;
            this.colTranLineItemID.VisibleIndex = 0;
            // 
            // colTranLineQuantity
            // 
            this.colTranLineQuantity.Caption = "Quantity";
            this.colTranLineQuantity.FieldName = "Quantity";
            this.colTranLineQuantity.Name = "colTranLineQuantity";
            this.colTranLineQuantity.Visible = true;
            this.colTranLineQuantity.VisibleIndex = 1;
            // 
            // colTranLineItemPrice
            // 
            this.colTranLineItemPrice.Caption = "Item Price";
            this.colTranLineItemPrice.FieldName = "ItemPrice";
            this.colTranLineItemPrice.Name = "colTranLineItemPrice";
            this.colTranLineItemPrice.Visible = true;
            this.colTranLineItemPrice.VisibleIndex = 2;
            // 
            // colTranLineNetValue
            // 
            this.colTranLineNetValue.Caption = "Net Value";
            this.colTranLineNetValue.FieldName = "Net Value";
            this.colTranLineNetValue.Name = "colTranLineNetValue";
            this.colTranLineNetValue.Visible = true;
            this.colTranLineNetValue.VisibleIndex = 3;
            // 
            // colTranLineDiscountValue
            // 
            this.colTranLineDiscountValue.Caption = "Discount Value";
            this.colTranLineDiscountValue.FieldName = "DiscountValue";
            this.colTranLineDiscountValue.Name = "colTranLineDiscountValue";
            this.colTranLineDiscountValue.Visible = true;
            this.colTranLineDiscountValue.VisibleIndex = 4;
            // 
            // colTranLineTotalValue
            // 
            this.colTranLineTotalValue.Caption = "Total Value";
            this.colTranLineTotalValue.FieldName = "TotalValue";
            this.colTranLineTotalValue.Name = "colTranLineTotalValue";
            this.colTranLineTotalValue.Visible = true;
            this.colTranLineTotalValue.VisibleIndex = 5;
            // 
            // TransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grdTransactionLines);
            this.Controls.Add(this.labelTransactionLines);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grdTransactions);
            this.Controls.Add(this.labelTransactions);
            this.Name = "TransactionsForm";
            this.Text = "Transaction Management";
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSave;
        private DevExpress.XtraGrid.GridControl grdTransactions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsTotalValue;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsPaymentMethod;
        private Label labelTransactions;
        private Label labelTransactionLines;
        private BindingSource bsTransactions;
        private BindingSource bsTransactionLines;
        private DevExpress.XtraGrid.GridControl grdTransactionLines;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private Button btnClose;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionID;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsCustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn colTranLineID;
        private DevExpress.XtraGrid.Columns.GridColumn colTranLineTransactionID;
        private DevExpress.XtraGrid.Columns.GridColumn colTranLineItemID;
        private DevExpress.XtraGrid.Columns.GridColumn colTranLineQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colTranLineItemPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTranLineNetValue;
        private DevExpress.XtraGrid.Columns.GridColumn colTranLineDiscountValue;
        private DevExpress.XtraGrid.Columns.GridColumn colTranLineTotalValue;
    }
}
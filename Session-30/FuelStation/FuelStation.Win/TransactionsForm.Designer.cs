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
            components = new System.ComponentModel.Container();
            btnSaveTranLines = new Button();
            grdTransactions = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colTransactionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colTransactionID = new DevExpress.XtraGrid.Columns.GridColumn();
            colTransactionsCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            colTransactionsPaymentMethod = new DevExpress.XtraGrid.Columns.GridColumn();
            colTransactionsEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            colTransactionsTotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
            repCustomersCard = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            repEmployeesSurname = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            labelTransactions = new Label();
            labelTransactionLines = new Label();
            bsTransactions = new BindingSource(components);
            bsTransactionLines = new BindingSource(components);
            grdTransactionLines = new DevExpress.XtraGrid.GridControl();
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colTranLineID = new DevExpress.XtraGrid.Columns.GridColumn();
            colTranLineTransactionID = new DevExpress.XtraGrid.Columns.GridColumn();
            colTranLineItemID = new DevExpress.XtraGrid.Columns.GridColumn();
            colTranLineQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            colTranLineItemPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            colTranLineNetValue = new DevExpress.XtraGrid.Columns.GridColumn();
            colTranLineDiscountValue = new DevExpress.XtraGrid.Columns.GridColumn();
            colTranLineTotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
            btnClose = new Button();
            btnSaveTransactions = new Button();
            btnDeleteTransaction = new Button();
            btnDeleteTranLines = new Button();
            ((System.ComponentModel.ISupportInitialize)grdTransactions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repCustomersCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repEmployeesSurname).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsTransactions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsTransactionLines).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdTransactionLines).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            SuspendLayout();
            // 
            // btnSaveTranLines
            // 
            btnSaveTranLines.Location = new Point(681, 486);
            btnSaveTranLines.Name = "btnSaveTranLines";
            btnSaveTranLines.Size = new Size(107, 35);
            btnSaveTranLines.TabIndex = 7;
            btnSaveTranLines.Text = "Save";
            btnSaveTranLines.UseVisualStyleBackColor = true;
            // 
            // grdTransactions
            // 
            grdTransactions.Location = new Point(12, 44);
            grdTransactions.MainView = gridView1;
            grdTransactions.Name = "grdTransactions";
            grdTransactions.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repCustomersCard, repEmployeesSurname });
            grdTransactions.Size = new Size(776, 178);
            grdTransactions.TabIndex = 6;
            grdTransactions.UseEmbeddedNavigator = true;
            grdTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colTransactionDate, colTransactionID, colTransactionsCustomerId, colTransactionsPaymentMethod, colTransactionsEmployeeID, colTransactionsTotalValue });
            gridView1.GridControl = grdTransactions;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTransactionDate
            // 
            colTransactionDate.Caption = "Date";
            colTransactionDate.FieldName = "Date";
            colTransactionDate.Name = "colTransactionDate";
            colTransactionDate.Visible = true;
            colTransactionDate.VisibleIndex = 2;
            // 
            // colTransactionID
            // 
            colTransactionID.Caption = "ID";
            colTransactionID.FieldName = "ID";
            colTransactionID.Name = "colTransactionID";
            // 
            // colTransactionsCustomerId
            // 
            colTransactionsCustomerId.Caption = "Customer";
            colTransactionsCustomerId.ColumnEdit = repCustomersCard;
            colTransactionsCustomerId.FieldName = "CustomerId";
            colTransactionsCustomerId.Name = "colTransactionsCustomerId";
            colTransactionsCustomerId.Visible = true;
            colTransactionsCustomerId.VisibleIndex = 0;
            // 
            // colTransactionsPaymentMethod
            // 
            colTransactionsPaymentMethod.Caption = "Payment Method";
            colTransactionsPaymentMethod.FieldName = "PaymentMethod";
            colTransactionsPaymentMethod.Name = "colTransactionsPaymentMethod";
            colTransactionsPaymentMethod.Visible = true;
            colTransactionsPaymentMethod.VisibleIndex = 1;
            // 
            // colTransactionsEmployeeID
            // 
            colTransactionsEmployeeID.Caption = "Employee";
            colTransactionsEmployeeID.ColumnEdit = repEmployeesSurname;
            colTransactionsEmployeeID.FieldName = "EmployeeId";
            colTransactionsEmployeeID.Name = "colTransactionsEmployeeID";
            colTransactionsEmployeeID.Visible = true;
            colTransactionsEmployeeID.VisibleIndex = 3;
            // 
            // colTransactionsTotalValue
            // 
            colTransactionsTotalValue.Caption = "Total Value";
            colTransactionsTotalValue.FieldName = "TotalValue";
            colTransactionsTotalValue.Name = "colTransactionsTotalValue";
            colTransactionsTotalValue.Visible = true;
            colTransactionsTotalValue.VisibleIndex = 4;
            // 
            // repCustomersCard
            // 
            repCustomersCard.AutoHeight = false;
            repCustomersCard.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repCustomersCard.Name = "repCustomersCard";
            // 
            // repEmployeesSurname
            // 
            repEmployeesSurname.AutoHeight = false;
            repEmployeesSurname.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repEmployeesSurname.Name = "repEmployeesSurname";
            // 
            // labelTransactions
            // 
            labelTransactions.AutoSize = true;
            labelTransactions.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelTransactions.Location = new Point(22, 9);
            labelTransactions.Name = "labelTransactions";
            labelTransactions.Size = new Size(127, 30);
            labelTransactions.TabIndex = 5;
            labelTransactions.Text = "Transactions";
            // 
            // labelTransactionLines
            // 
            labelTransactionLines.AutoSize = true;
            labelTransactionLines.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelTransactionLines.Location = new Point(22, 256);
            labelTransactionLines.Name = "labelTransactionLines";
            labelTransactionLines.Size = new Size(171, 30);
            labelTransactionLines.TabIndex = 8;
            labelTransactionLines.Text = "Transaction Lines";
            // 
            // grdTransactionLines
            // 
            grdTransactionLines.Location = new Point(12, 291);
            grdTransactionLines.MainView = gridView2;
            grdTransactionLines.Name = "grdTransactionLines";
            grdTransactionLines.Size = new Size(776, 191);
            grdTransactionLines.TabIndex = 9;
            grdTransactionLines.UseEmbeddedNavigator = true;
            grdTransactionLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView2 });
            // 
            // gridView2
            // 
            gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colTranLineID, colTranLineTransactionID, colTranLineItemID, colTranLineQuantity, colTranLineItemPrice, colTranLineNetValue, colTranLineDiscountValue, colTranLineTotalValue });
            gridView2.GridControl = grdTransactionLines;
            gridView2.Name = "gridView2";
            gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colTranLineID
            // 
            colTranLineID.Caption = "ID";
            colTranLineID.FieldName = "ID";
            colTranLineID.Name = "colTranLineID";
            // 
            // colTranLineTransactionID
            // 
            colTranLineTransactionID.Caption = "TransactionID";
            colTranLineTransactionID.FieldName = "TransactionID";
            colTranLineTransactionID.Name = "colTranLineTransactionID";
            // 
            // colTranLineItemID
            // 
            colTranLineItemID.Caption = "Item";
            colTranLineItemID.FieldName = "ItemID";
            colTranLineItemID.Name = "colTranLineItemID";
            colTranLineItemID.Visible = true;
            colTranLineItemID.VisibleIndex = 0;
            // 
            // colTranLineQuantity
            // 
            colTranLineQuantity.Caption = "Quantity";
            colTranLineQuantity.FieldName = "Quantity";
            colTranLineQuantity.Name = "colTranLineQuantity";
            colTranLineQuantity.Visible = true;
            colTranLineQuantity.VisibleIndex = 1;
            // 
            // colTranLineItemPrice
            // 
            colTranLineItemPrice.Caption = "Item Price";
            colTranLineItemPrice.FieldName = "ItemPrice";
            colTranLineItemPrice.Name = "colTranLineItemPrice";
            colTranLineItemPrice.Visible = true;
            colTranLineItemPrice.VisibleIndex = 2;
            // 
            // colTranLineNetValue
            // 
            colTranLineNetValue.Caption = "Net Value";
            colTranLineNetValue.FieldName = "Net Value";
            colTranLineNetValue.Name = "colTranLineNetValue";
            colTranLineNetValue.Visible = true;
            colTranLineNetValue.VisibleIndex = 3;
            // 
            // colTranLineDiscountValue
            // 
            colTranLineDiscountValue.Caption = "Discount Value";
            colTranLineDiscountValue.FieldName = "DiscountValue";
            colTranLineDiscountValue.Name = "colTranLineDiscountValue";
            colTranLineDiscountValue.Visible = true;
            colTranLineDiscountValue.VisibleIndex = 4;
            // 
            // colTranLineTotalValue
            // 
            colTranLineTotalValue.Caption = "Total Value";
            colTranLineTotalValue.FieldName = "TotalValue";
            colTranLineTotalValue.Name = "colTranLineTotalValue";
            colTranLineTotalValue.Visible = true;
            colTranLineTotalValue.VisibleIndex = 5;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(22, 500);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(107, 32);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSaveTransactions
            // 
            btnSaveTransactions.Location = new Point(681, 228);
            btnSaveTransactions.Name = "btnSaveTransactions";
            btnSaveTransactions.Size = new Size(107, 35);
            btnSaveTransactions.TabIndex = 11;
            btnSaveTransactions.Text = "Save";
            btnSaveTransactions.UseVisualStyleBackColor = true;
            btnSaveTransactions.Click += btnSaveTransactions_Click;
            // 
            // btnDeleteTransaction
            // 
            btnDeleteTransaction.Location = new Point(568, 228);
            btnDeleteTransaction.Name = "btnDeleteTransaction";
            btnDeleteTransaction.Size = new Size(107, 35);
            btnDeleteTransaction.TabIndex = 12;
            btnDeleteTransaction.Text = "Delete";
            btnDeleteTransaction.UseVisualStyleBackColor = true;
            btnDeleteTransaction.Click += btnDeleteTransaction_Click;
            // 
            // btnDeleteTranLines
            // 
            btnDeleteTranLines.Location = new Point(568, 486);
            btnDeleteTranLines.Name = "btnDeleteTranLines";
            btnDeleteTranLines.Size = new Size(107, 35);
            btnDeleteTranLines.TabIndex = 13;
            btnDeleteTranLines.Text = "Delete";
            btnDeleteTranLines.UseVisualStyleBackColor = true;
            // 
            // TransactionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 544);
            Controls.Add(btnDeleteTranLines);
            Controls.Add(btnDeleteTransaction);
            Controls.Add(btnSaveTransactions);
            Controls.Add(btnClose);
            Controls.Add(grdTransactionLines);
            Controls.Add(labelTransactionLines);
            Controls.Add(btnSaveTranLines);
            Controls.Add(grdTransactions);
            Controls.Add(labelTransactions);
            Name = "TransactionsForm";
            Text = "Transaction Management";
            Load += TransactionsForm_Load;
            ((System.ComponentModel.ISupportInitialize)grdTransactions).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repCustomersCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)repEmployeesSurname).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsTransactions).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsTransactionLines).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdTransactionLines).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveTranLines;
        private DevExpress.XtraGrid.GridControl grdTransactions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsEmployeeID;
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
        private Button btnSaveTransactions;
        private Button btnDeleteTransaction;
        private Button btnDeleteTranLines;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCustomersCard;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repEmployeesSurname;
    }
}
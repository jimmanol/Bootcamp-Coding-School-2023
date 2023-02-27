namespace FuelStation.Win {
    partial class ItemsForm {
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
            grdItems = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colItemId = new DevExpress.XtraGrid.Columns.GridColumn();
            colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            colItemType = new DevExpress.XtraGrid.Columns.GridColumn();
            colItemCost = new DevExpress.XtraGrid.Columns.GridColumn();
            colItemPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            labelItems = new Label();
            btnSave = new Button();
            bsItems = new BindingSource(components);
            btnClose = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)grdItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsItems).BeginInit();
            SuspendLayout();
            // 
            // grdItems
            // 
            grdItems.Location = new Point(12, 37);
            grdItems.MainView = gridView1;
            grdItems.Name = "grdItems";
            grdItems.Size = new Size(623, 255);
            grdItems.TabIndex = 0;
            grdItems.UseEmbeddedNavigator = true;
            grdItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            grdItems.Click += grdItems_Click;
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colItemId, colItemCode, colItemDescription, colItemType, colItemCost, colItemPrice });
            gridView1.GridControl = grdItems;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colItemId
            // 
            colItemId.Caption = "ID";
            colItemId.FieldName = "ID";
            colItemId.Name = "colItemId";
            // 
            // colItemCode
            // 
            colItemCode.Caption = "Code";
            colItemCode.FieldName = "Code";
            colItemCode.Name = "colItemCode";
            colItemCode.Visible = true;
            colItemCode.VisibleIndex = 0;
            // 
            // colItemDescription
            // 
            colItemDescription.Caption = "Description";
            colItemDescription.FieldName = "Description";
            colItemDescription.Name = "colItemDescription";
            colItemDescription.Visible = true;
            colItemDescription.VisibleIndex = 1;
            // 
            // colItemType
            // 
            colItemType.Caption = "Type";
            colItemType.FieldName = "ItemType";
            colItemType.Name = "colItemType";
            colItemType.Visible = true;
            colItemType.VisibleIndex = 2;
            // 
            // colItemCost
            // 
            colItemCost.Caption = "Cost";
            colItemCost.FieldName = "Cost";
            colItemCost.Name = "colItemCost";
            colItemCost.Visible = true;
            colItemCost.VisibleIndex = 3;
            // 
            // colItemPrice
            // 
            colItemPrice.Caption = "Price";
            colItemPrice.FieldName = "Price";
            colItemPrice.Name = "colItemPrice";
            colItemPrice.Visible = true;
            colItemPrice.VisibleIndex = 4;
            // 
            // labelItems
            // 
            labelItems.AutoSize = true;
            labelItems.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelItems.Location = new Point(255, 5);
            labelItems.Name = "labelItems";
            labelItems.Size = new Size(82, 29);
            labelItems.TabIndex = 2;
            labelItems.Text = "Items ";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(528, 298);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(107, 43);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(12, 303);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(107, 43);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(415, 298);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 43);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ItemsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 358);
            Controls.Add(btnDelete);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(labelItems);
            Controls.Add(grdItems);
            Name = "ItemsForm";
            Text = "Item Management";
            Load += ItemsForm_Load;
            ((System.ComponentModel.ISupportInitialize)grdItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Label labelItems;
        private Button btnSave;
        private BindingSource bsItems;
        private DevExpress.XtraGrid.Columns.GridColumn colItemId;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colItemType;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCost;
        private DevExpress.XtraGrid.Columns.GridColumn colItemPrice;
        private Button btnClose;
        private Button btnDelete;
    }
}
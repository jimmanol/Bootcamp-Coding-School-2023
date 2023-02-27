namespace FuelStation.Win {
    partial class MainForm {
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
            btnCustomers = new Button();
            btnItems = new Button();
            btnTransactions = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnCustomers
            // 
            btnCustomers.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomers.Location = new Point(79, 56);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(217, 45);
            btnCustomers.TabIndex = 0;
            btnCustomers.Text = "Customers";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnItems
            // 
            btnItems.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnItems.Location = new Point(79, 123);
            btnItems.Name = "btnItems";
            btnItems.Size = new Size(217, 48);
            btnItems.TabIndex = 1;
            btnItems.Text = "Items";
            btnItems.UseVisualStyleBackColor = true;
            btnItems.Click += btnItems_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTransactions.Location = new Point(79, 195);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(217, 46);
            btnTransactions.TabIndex = 2;
            btnTransactions.Text = "Transactions";
            btnTransactions.UseVisualStyleBackColor = true;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Shaumy", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(34, 33);
            btnBack.TabIndex = 13;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 289);
            Controls.Add(btnBack);
            Controls.Add(btnTransactions);
            Controls.Add(btnItems);
            Controls.Add(btnCustomers);
            Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Main Menu";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnBack;
        public Button btnCustomers;
        public Button btnItems;
        public Button btnTransactions;
    }
}
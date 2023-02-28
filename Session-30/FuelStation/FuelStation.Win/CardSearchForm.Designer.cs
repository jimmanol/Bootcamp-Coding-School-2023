namespace FuelStation.Win {
    partial class CardSearchForm {
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
            labelSearchCustomer = new Label();
            txtCardNumber = new TextBox();
            btnSearch = new Button();
            btnNewCustomer = new Button();
            btnExistingCustomer = new Button();
            btnSkip = new Button();
            SuspendLayout();
            // 
            // labelSearchCustomer
            // 
            labelSearchCustomer.AutoSize = true;
            labelSearchCustomer.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelSearchCustomer.Location = new Point(41, 9);
            labelSearchCustomer.Name = "labelSearchCustomer";
            labelSearchCustomer.Size = new Size(382, 23);
            labelSearchCustomer.TabIndex = 0;
            labelSearchCustomer.Text = "Asign Transaction to Customer by Card Number";
            // 
            // txtCardNumber
            // 
            txtCardNumber.Enabled = false;
            txtCardNumber.Location = new Point(29, 146);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(255, 23);
            txtCardNumber.TabIndex = 2;
            txtCardNumber.Text = "Please Insert Card Number...";
            txtCardNumber.Visible = false;
            // 
            // btnSearch
            // 
            btnSearch.Enabled = false;
            btnSearch.Location = new Point(300, 140);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(95, 32);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Visible = false;
            // 
            // btnNewCustomer
            // 
            btnNewCustomer.Location = new Point(239, 61);
            btnNewCustomer.Name = "btnNewCustomer";
            btnNewCustomer.Size = new Size(137, 48);
            btnNewCustomer.TabIndex = 4;
            btnNewCustomer.Text = "New Customer";
            btnNewCustomer.UseVisualStyleBackColor = true;
            btnNewCustomer.Click += btnNewCustomer_Click;
            // 
            // btnExistingCustomer
            // 
            btnExistingCustomer.Location = new Point(76, 61);
            btnExistingCustomer.Name = "btnExistingCustomer";
            btnExistingCustomer.Size = new Size(136, 48);
            btnExistingCustomer.TabIndex = 6;
            btnExistingCustomer.Text = "Existing Customer";
            btnExistingCustomer.UseVisualStyleBackColor = true;
            btnExistingCustomer.Click += btnExistingCustomer_Click;
            // 
            // btnSkip
            // 
            btnSkip.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSkip.Location = new Point(405, 190);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new Size(28, 30);
            btnSkip.TabIndex = 7;
            btnSkip.Text = ">";
            btnSkip.UseVisualStyleBackColor = true;
            btnSkip.Click += btnSkip_Click;
            // 
            // CardSearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 226);
            Controls.Add(btnSkip);
            Controls.Add(btnExistingCustomer);
            Controls.Add(btnNewCustomer);
            Controls.Add(btnSearch);
            Controls.Add(txtCardNumber);
            Controls.Add(labelSearchCustomer);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CardSearchForm";
            Text = "Card Search ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSearchCustomer;
        private TextBox txtCardNumber;
        private Button btnSearch;
        private Button btnNewCustomer;
        private Button btnExistingCustomer;
        private Button btnSkip;
    }
}
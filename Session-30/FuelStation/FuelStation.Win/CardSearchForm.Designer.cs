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
            this.labelSearchCustomer = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnExistingCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSearchCustomer
            // 
            this.labelSearchCustomer.AutoSize = true;
            this.labelSearchCustomer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSearchCustomer.Location = new System.Drawing.Point(41, 9);
            this.labelSearchCustomer.Name = "labelSearchCustomer";
            this.labelSearchCustomer.Size = new System.Drawing.Size(382, 23);
            this.labelSearchCustomer.TabIndex = 0;
            this.labelSearchCustomer.Text = "Asign Transaction to Customer by Card Number";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Enabled = false;
            this.txtCardNumber.Location = new System.Drawing.Point(29, 146);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(255, 23);
            this.txtCardNumber.TabIndex = 2;
            this.txtCardNumber.Text = "Please Insert Card Number...";
            this.txtCardNumber.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(300, 140);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 32);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(239, 61);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(137, 48);
            this.btnNewCustomer.TabIndex = 4;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            // 
            // btnExistingCustomer
            // 
            this.btnExistingCustomer.Location = new System.Drawing.Point(76, 61);
            this.btnExistingCustomer.Name = "btnExistingCustomer";
            this.btnExistingCustomer.Size = new System.Drawing.Size(136, 48);
            this.btnExistingCustomer.TabIndex = 6;
            this.btnExistingCustomer.Text = "Existing Customer";
            this.btnExistingCustomer.UseVisualStyleBackColor = true;
            this.btnExistingCustomer.Click += new System.EventHandler(this.btnExistingCustomer_Click);
            // 
            // CardSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 226);
            this.Controls.Add(this.btnExistingCustomer);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.labelSearchCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CardSearchForm";
            this.Text = "Card Search ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelSearchCustomer;
        private TextBox txtCardNumber;
        private Button btnSearch;
        private Button btnNewCustomer;
        private Button btnExistingCustomer;
    }
}
namespace FuelStation.Win {
    partial class LoginForm {
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
            btnCashierLogin = new Button();
            btnStaffLogin = new Button();
            btnManagerLogin = new Button();
            labelIdentity = new Label();
            SuspendLayout();
            // 
            // btnCashierLogin
            // 
            btnCashierLogin.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCashierLogin.Location = new Point(12, 47);
            btnCashierLogin.Name = "btnCashierLogin";
            btnCashierLogin.Size = new Size(202, 54);
            btnCashierLogin.TabIndex = 0;
            btnCashierLogin.Text = "Cashier";
            btnCashierLogin.UseVisualStyleBackColor = true;
            btnCashierLogin.Click += btnCashierLogin_Click;
            // 
            // btnStaffLogin
            // 
            btnStaffLogin.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnStaffLogin.Location = new Point(155, 107);
            btnStaffLogin.Name = "btnStaffLogin";
            btnStaffLogin.Size = new Size(202, 54);
            btnStaffLogin.TabIndex = 1;
            btnStaffLogin.Text = "Staff";
            btnStaffLogin.UseVisualStyleBackColor = true;
            btnStaffLogin.Click += btnStaffLogin_Click;
            // 
            // btnManagerLogin
            // 
            btnManagerLogin.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnManagerLogin.Location = new Point(292, 167);
            btnManagerLogin.Name = "btnManagerLogin";
            btnManagerLogin.Size = new Size(202, 54);
            btnManagerLogin.TabIndex = 2;
            btnManagerLogin.Text = "Manager";
            btnManagerLogin.UseVisualStyleBackColor = true;
            btnManagerLogin.Click += btnManagerLogin_Click;
            // 
            // labelIdentity
            // 
            labelIdentity.AutoSize = true;
            labelIdentity.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelIdentity.Location = new Point(205, 9);
            labelIdentity.Name = "labelIdentity";
            labelIdentity.Size = new Size(90, 25);
            labelIdentity.TabIndex = 3;
            labelIdentity.Text = "Login as:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 249);
            Controls.Add(labelIdentity);
            Controls.Add(btnManagerLogin);
            Controls.Add(btnStaffLogin);
            Controls.Add(btnCashierLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            Text = "Welcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnStaffLogin;
        private Button btnManagerLogin;
        private Label labelIdentity;
        public Button btnCashierLogin;
    }
}
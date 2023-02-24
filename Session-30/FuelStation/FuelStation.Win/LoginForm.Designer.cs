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
            this.btnCashierLogin = new System.Windows.Forms.Button();
            this.btnStaffLogin = new System.Windows.Forms.Button();
            this.btnManagerLogin = new System.Windows.Forms.Button();
            this.labelIdentity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCashierLogin
            // 
            this.btnCashierLogin.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCashierLogin.Location = new System.Drawing.Point(12, 47);
            this.btnCashierLogin.Name = "btnCashierLogin";
            this.btnCashierLogin.Size = new System.Drawing.Size(202, 54);
            this.btnCashierLogin.TabIndex = 0;
            this.btnCashierLogin.Text = "Cashier";
            this.btnCashierLogin.UseVisualStyleBackColor = true;
            // 
            // btnStaffLogin
            // 
            this.btnStaffLogin.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStaffLogin.Location = new System.Drawing.Point(155, 107);
            this.btnStaffLogin.Name = "btnStaffLogin";
            this.btnStaffLogin.Size = new System.Drawing.Size(202, 54);
            this.btnStaffLogin.TabIndex = 1;
            this.btnStaffLogin.Text = "Staff";
            this.btnStaffLogin.UseVisualStyleBackColor = true;
            // 
            // btnManagerLogin
            // 
            this.btnManagerLogin.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnManagerLogin.Location = new System.Drawing.Point(292, 167);
            this.btnManagerLogin.Name = "btnManagerLogin";
            this.btnManagerLogin.Size = new System.Drawing.Size(202, 54);
            this.btnManagerLogin.TabIndex = 2;
            this.btnManagerLogin.Text = "Manager";
            this.btnManagerLogin.UseVisualStyleBackColor = true;
            // 
            // labelIdentity
            // 
            this.labelIdentity.AutoSize = true;
            this.labelIdentity.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelIdentity.Location = new System.Drawing.Point(177, 9);
            this.labelIdentity.Name = "labelIdentity";
            this.labelIdentity.Size = new System.Drawing.Size(163, 21);
            this.labelIdentity.TabIndex = 3;
            this.labelIdentity.Text = "Choose your Identity";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 233);
            this.Controls.Add(this.labelIdentity);
            this.Controls.Add(this.btnManagerLogin);
            this.Controls.Add(this.btnStaffLogin);
            this.Controls.Add(this.btnCashierLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCashierLogin;
        private Button btnStaffLogin;
        private Button btnManagerLogin;
        private Label labelIdentity;
    }
}
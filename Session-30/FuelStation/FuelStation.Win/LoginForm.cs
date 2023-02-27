using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Win {
    public partial class LoginForm : Form {

        public LoginForm() {
            InitializeComponent();
        }

        private void btnCashierLogin_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Are you sure you want to login as a Cashier?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                MainForm mainForm = new MainForm();
                mainForm.btnItems.Hide();
                this.Enabled = false;
                mainForm.ShowDialog();
                this.Enabled = true;

            }
        }

        private void btnStaffLogin_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Are you sure you want to login as a Staff Member?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) { 
                MainForm mainForm = new MainForm();
                mainForm.btnCustomers.Hide();
                mainForm.btnTransactions.Hide();
                this.Enabled = false;
                mainForm.ShowDialog();
                this.Enabled = true;
            }
        }

        private void btnManagerLogin_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Are you sure you want to login as a Manager?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                MainForm mainForm = new MainForm();
                this.Enabled = false;
                mainForm.ShowDialog();
                this.Enabled = true;
            }
        }


    }
}

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
    public partial class MainForm : Form {

        
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            
        }

        private void btnCustomers_Click(object sender, EventArgs e) {
            CustomersForm custForm = new CustomersForm();
            custForm.ShowDialog();
        }

        private void btnItems_Click(object sender, EventArgs e) {
            ItemsForm itemForm = new ItemsForm();
            itemForm.ShowDialog();
        }

        private void btnTransactions_Click(object sender, EventArgs e) {
            TransactionsForm tranForm = new TransactionsForm();
            tranForm.ShowDialog();
        }
    }
}

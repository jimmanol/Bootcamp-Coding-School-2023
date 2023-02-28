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
    public partial class CardSearchForm : Form {
        public CardSearchForm() {
            InitializeComponent();
        }

        private void btnExistingCustomer_Click(object sender, EventArgs e) {
            txtCardNumber.Visible = true;
            btnSearch.Visible = true;
            txtCardNumber.Enabled = true;
            btnSearch.Enabled = true;
        }

        private void btnSkip_Click(object sender, EventArgs e) {
            TransactionsForm transactionsForm = new TransactionsForm();
            transactionsForm.ShowDialog();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e) {
            CustomersForm customersForm = new CustomersForm();
            customersForm.ShowDialog();
        }
    }
}

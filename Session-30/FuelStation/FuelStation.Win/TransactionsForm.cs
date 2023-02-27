using DevExpress.XtraEditors.Repository;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Blazor.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Win {
    public partial class TransactionsForm : Form {
        HttpClient client = new HttpClient();
        


        public TransactionsForm() {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7137/");
        }

        private void TransactionsForm_Load(object sender, EventArgs e) {
            BindTransactionsToDataSource();
        }


        private async Task BindTransactionsToDataSource() {
            var transactions = await GetTransactions();
            var customers = await GetCustomers();
            var employees = await GetEmployees();
            if (transactions != null) {
                bsTransactions.DataSource = transactions;
                grdTransactions.DataSource = bsTransactions;
            }
            SetLookUpEdit(repCustomersCard, customers, "CardNumber", "ID");
            SetLookUpEdit(repEmployeesSurname, employees, "Surname", "Id");
        }


        private void SetLookUpEdit<T>(RepositoryItemLookUpEdit rep, List<T> list, String displayMembers, String valueMember) {
            rep.DataSource = list;
            rep.DisplayMember = displayMembers;
            rep.ValueMember = valueMember;
        }

        //get transactions
        private async Task<List<TransactionListDto>> GetTransactions() {
            var response = await client.GetAsync("transaction");
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<TransactionListDto>>(content);
            }
            return null;
        }

        //get customers
        private async Task<List<CustomerListDto>> GetCustomers() {
            var response = await client.GetAsync("customer");
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<CustomerListDto>>(content);
            }
            return null;
        }

        //get employees
        private async Task<List<EmployeeListDto>> GetEmployees() {
            var response = await client.GetAsync("employee");
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<EmployeeListDto>>(content);
            }
            return null;
        }


        private async Task CreateTransaction(TransactionListDto transaction) {
            HttpResponseMessage? response = null;
            response = await client.PostAsJsonAsync("transaction", transaction);
            if (response.IsSuccessStatusCode) {
                MessageBox.Show("Transaction Created successfully!");
                BindTransactionsToDataSource();
            }
            else {
                MessageBox.Show("ERROR Creating Transaction.");
            }
        }

        private async Task UpdateTransaction(TransactionListDto transaction) {
            HttpResponseMessage? response = null;
            response = await client.PutAsJsonAsync("transaction", transaction);
            if (response.IsSuccessStatusCode) {
                MessageBox.Show("Transaction Updated successfully!");
                BindTransactionsToDataSource();
            }
            else {
                MessageBox.Show("ERROR Updating transaction.");
            }
        }

        private async Task DeleteTransaction(TransactionListDto? transaction) {
            HttpResponseMessage? response = null;

            if (transaction != null) {
                response = await client.DeleteAsync($"transaction/{transaction.Id}");
                if (response.IsSuccessStatusCode) {
                    MessageBox.Show("Transaction Deleted successfully!");
                    BindTransactionsToDataSource();
                }
                else {
                    MessageBox.Show("ERROR Deleting Transaction.");
                }
            }
            else {
                MessageBox.Show("Transaction not selected.");
            }
        }




        // Buttons
        private void btnSaveTransactions_Click(object sender, EventArgs e) {
            TransactionListDto transaction = (TransactionListDto)bsTransactions.Current;

            if (transaction.Id == Guid.Empty) {

                CreateTransaction(transaction);
            }
            else if (transaction.Id == null) {
                MessageBox.Show("Cannot Delete all Transactions.");
            }
            else {
                UpdateTransaction(transaction);

            }
        }
        private void btnDeleteTransaction_Click(object sender, EventArgs e) {
            TransactionListDto transaction = (TransactionListDto)bsTransactions.Current;
            DeleteTransaction(transaction);
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}




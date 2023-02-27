using DevExpress.DataAccess.Native.Sql;
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
            //var transactionLines = await GetTransactionLines();
            var items = await GetItems();
            var customers = await GetCustomers();
            var employees = await GetEmployees();
            if (transactions != null) {
                bsTransactions.DataSource = transactions;
                grdTransactions.DataSource = bsTransactions;
                bsTransactionLines.DataSource = bsTransactions;
                bsTransactionLines.DataMember = "TransactionLines";
                grdTransactionLines.DataSource = bsTransactionLines;
            }
            SetLookUpEdit(repCustomersCard, customers, "CardNumber", "ID");
            SetLookUpEdit(repEmployeesSurname, employees, "Surname", "Id");
            SetLookUpEdit(repItemsDescription, items, "Description", "Id");
        }


        private void SetLookUpEdit<T>(RepositoryItemLookUpEdit rep, List<T> list, String displayMembers, String valueMember) {
            rep.DataSource = list;
            rep.DisplayMember = displayMembers;
            rep.ValueMember = valueMember;
        }

        //get transactions
        private async Task<List<TransactionEditDto>> GetTransactions() {
            var response = await client.GetAsync("transaction");
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<TransactionEditDto>>(content);
            }
            return null;
        }

        //get transactionLines
        private async Task<List<TransactionLineEditDto>> GetTransactionLines() {
            var response = await client.GetAsync("transactionLine");
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<TransactionLineEditDto>>(content);
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

        //get items
        private async Task<List<ItemListDto>> GetItems() {
            var response = await client.GetAsync("item");
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<ItemListDto>>(content);
            }
            return null;
        }




        //transactions create-update-delete 
        private async Task CreateTransaction(TransactionEditDto transaction) {
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

        private async Task UpdateTransaction(TransactionEditDto transaction) {
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

        private async Task DeleteTransaction(TransactionEditDto? transaction) {
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




        //transactionLines create-update-delete 

        private async Task CreateTransactionLine(TransactionLineEditDto transactionLine) {
            HttpResponseMessage? response = null;
            response = await client.PostAsJsonAsync("transactionLine", transactionLine);
            if (response.IsSuccessStatusCode) {
                MessageBox.Show("Transaction Line Created successfully!");
                //BindTransactionLinesToDataSource();
            }
            else {
                MessageBox.Show("ERROR Creating Transaction Line.");
            }
        }

        private async Task UpdateTransactionLine(TransactionLineEditDto transactionLine) {
            HttpResponseMessage? response = null;
            response = await client.PutAsJsonAsync("transactionLine", transactionLine);
            if (response.IsSuccessStatusCode) {
                MessageBox.Show("Transaction Line Updated successfully!");
                //BindTransactionLinesToDataSource();
            }
            else {
                MessageBox.Show("ERROR Updating Transaction Line.");
            }
        }

        private async Task DeleteTransactionLine(TransactionLineEditDto? transactionLine) {
            HttpResponseMessage? response = null;

            if (transactionLine != null) {
                response = await client.DeleteAsync($"transactionLine/{transactionLine.Id}");
                if (response.IsSuccessStatusCode) {
                    MessageBox.Show("Transaction Line Deleted successfully!");
                    //BindTransactionLinesToDataSource();
                }
                else {
                    MessageBox.Show("ERROR Deleting Transaction Line.");
                }
            }
            else {
                MessageBox.Show("Transaction Line not selected.");
            }
        }






        //Transaction Buttons
        private void btnSaveTransactions_Click(object sender, EventArgs e) {
            TransactionEditDto transaction = (TransactionEditDto)bsTransactions.Current;

            if (transaction.Id == Guid.Empty) {

                CreateTransaction(transaction);
            }
            else {
                UpdateTransaction(transaction);

            }
        }
        private void btnDeleteTransaction_Click(object sender, EventArgs e) {
            TransactionEditDto transaction = (TransactionEditDto)bsTransactions.Current;
            DeleteTransaction(transaction);
        }



        //Transaction Lines Buttons
        private void btnSaveTranLines_Click(object sender, EventArgs e) {
            TransactionLineEditDto transactionLine = (TransactionLineEditDto)bsTransactionLines.Current;
            if (transactionLine.Id == Guid.Empty) {

                CreateTransactionLine(transactionLine);
            }
            else {
                UpdateTransactionLine(transactionLine);

            }
        }

        private void btnDeleteTranLines_Click(object sender, EventArgs e) {
            TransactionLineEditDto transactionLine = (TransactionLineEditDto)bsTransactionLines.Current;
            DeleteTransactionLine(transactionLine);
        }





        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

    }
}




using FuelStation.Web.Blazor.Shared;
using System.Net.Http;
using System.Net.Http.Json;
using Newtonsoft.Json;

namespace FuelStation.Win {
    public partial class CustomersForm : Form {
        HttpClient client = new HttpClient();
        public CustomersForm() {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7137/");
        }

        private void CustomersForm_Load(object sender, EventArgs e) {
            BindCustomersToDataSource();
        }

        private async Task BindCustomersToDataSource() {
            var customers = await GetCustomers();
            if (customers != null) {
                bsCustomers.DataSource = customers;
                grdCustomers.DataSource = bsCustomers;
            }
        }

        //get
        private async Task<List<CustomerListDto>> GetCustomers() {
            var response = await client.GetAsync("customer");
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<CustomerListDto>>(content);
            }
            return null;
        }


        private async Task CreateCustomer(CustomerListDto customer) {
            HttpResponseMessage? response = null;
            response = await client.PostAsJsonAsync("customer", customer);
            if (response.IsSuccessStatusCode) {
                MessageBox.Show("Customer Created successfully!");
                BindCustomersToDataSource();
            }
            else {
                MessageBox.Show("ERROR Creating customer.");
            }
        }

        private async Task UpdateCustomer(CustomerListDto customer) {
            HttpResponseMessage? response = null;
            response = await client.PutAsJsonAsync("customer", customer);
            if (response.IsSuccessStatusCode) {
                MessageBox.Show("Customer Updated successfully!");
                BindCustomersToDataSource();
            }
            else {
                MessageBox.Show("ERROR Updating customer.");
            }
        }



        private async Task DeleteCustomer(CustomerListDto? customer) {
            HttpResponseMessage? response = null;
            
            if (customer != null) {
                response = await client.DeleteAsync($"customer/{customer.ID}");
                if (response.IsSuccessStatusCode) {
                    MessageBox.Show("Customer Deleted successfully!");
                    BindCustomersToDataSource();
                }
                else {
                    MessageBox.Show("ERROR Deleting customer.");
                }
            }
            else {
                MessageBox.Show("Customer not selected.");
            }
        }

        private async void btnSave_Click(object sender, EventArgs e) {
            CustomerListDto customer = (CustomerListDto)bsCustomers.Current;

            if (customer.ID == Guid.Empty) {

                CreateCustomer(customer);
            }
            else {

                UpdateCustomer(customer);
            }
        }


        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            CustomerListDto customer = (CustomerListDto)bsCustomers.Current;
            DeleteCustomer(customer);
        }
    }
}

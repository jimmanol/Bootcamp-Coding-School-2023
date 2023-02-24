using FuelStation.Web.Blazor.Shared;
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
using System.Net.Http.Json;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using System.Text.RegularExpressions;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraRichEdit.Import.Html;
using Newtonsoft.Json;

namespace FuelStation.Win {
    public partial class CustomersForm : Form {
        public CustomersForm() {
            InitializeComponent();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7137/");
        }

        private async void CustomersForm_Load(object sender, EventArgs e) {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7137/");
            var response = await client.GetAsync("/customer");
            var temp = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode) {
                var customers = JsonConvert.DeserializeObject<List<CustomerListDto?>>(temp);
                bsCustomers.DataSource = customers;
                grdCustomers.DataSource = bsCustomers;
            }
        }

    }
}

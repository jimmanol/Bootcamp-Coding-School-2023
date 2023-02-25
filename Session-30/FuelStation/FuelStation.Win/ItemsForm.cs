using DevExpress.Diagram.Core.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraVerticalGrid.Native;
using FuelStation.Model.Enums;
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
    public partial class ItemsForm : Form {
        HttpClient client = new HttpClient();
        
        public ItemsForm() {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7137/");
            cboxItemType.Properties.Items.AddRange(typeof(ItemType).GetEnumValues());


        }
        private void ItemsForm_Load(object sender, EventArgs e) {
            BindItemsToDataSource();
        }

        private async Task BindItemsToDataSource() {
            var items = await GetItems();
            if (items != null) {
                bsItems.DataSource = items;
                grdItems.DataSource = bsItems;
            }
        }            
  

        //get
        private async Task<List<ItemListDto>> GetItems() {
            var response = await client.GetAsync("item");
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<ItemListDto>>(content);
            }
            return null;
        }

        private async Task CreateItem(ItemListDto item) {
            HttpResponseMessage? response = null;
            response = await client.PostAsJsonAsync("item", item);
            if (response.IsSuccessStatusCode) {
                MessageBox.Show("Item Created successfully!");
                BindItemsToDataSource();
            }
            else {
                MessageBox.Show("ERROR Creating Item.");
            }
        }

        private async Task UpdateItem(ItemListDto item) {
            HttpResponseMessage? response = null;
            response = await client.PutAsJsonAsync("item", item);
            if (response.IsSuccessStatusCode) {
                MessageBox.Show("Item Updated successfully!");
                BindItemsToDataSource();
            }
            else {
                MessageBox.Show("ERROR Updating Item.");
            }
        }



        private async Task DeleteItem(ItemListDto? item) {
            HttpResponseMessage? response = null;

            if (item != null) {
                response = await client.DeleteAsync($"item/{item.Id}");
                if (response.IsSuccessStatusCode) {
                    MessageBox.Show("Item Deleted successfully!");
                    BindItemsToDataSource();
                }
                else {
                    MessageBox.Show("ERROR Deleting Item.");
                }
            }
            else {
                MessageBox.Show("Item not selected.");
            }
        }


        private void btnSave_Click(object sender, EventArgs e) {
            ItemListDto item = (ItemListDto)bsItems.Current;

            if (item.Id == Guid.Empty) {

                CreateItem(item);
            }
            else {

                UpdateItem(item);
            }
        }
        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            ItemListDto item = (ItemListDto)bsItems.Current;
            DeleteItem(item);
        }



        private void grdItems_Click(object sender, EventArgs e) {
           
        }
    }
}

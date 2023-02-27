using FuelStation.Model;
using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Blazor.Shared {
    public class ItemListDto {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ItemType ItemType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }


        //ctors

        public ItemListDto() {

        }
        public ItemListDto(Item item) {
            Id = item.ID;
            Code = item.Code;
            Description = item.Description;
            ItemType = item.ItemType;
            Price = item.Price;
            Cost = item.Cost;
        }
    }
}

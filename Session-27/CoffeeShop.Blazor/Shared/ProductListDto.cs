using CoffeeShop.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Blazor.Shared {
    public class ProductListDto {

        public int Id { get; set; }
        public String Code { get; set; } = null!;
        public String Description { get; set; } = null!;
        public ProductType ProductType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public int ProductCategoryId { get; set; }
    }
}

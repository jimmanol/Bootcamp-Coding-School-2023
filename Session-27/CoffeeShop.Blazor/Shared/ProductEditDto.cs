using CoffeeShop.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Blazor.Shared {
    public class ProductEditDto {

       
        public int Id { get; set; }

        [Required]
        public String Code { get; set; } = null!;

        [Required]
        public String Description { get; set; } = null!;

        [Required]
        public ProductType ProductType { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public decimal Cost { get; set; }

        [Required]
        public int ProductCategoryId { get; set; }
    }
}

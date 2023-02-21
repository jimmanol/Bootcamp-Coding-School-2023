using CoffeeShop.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Blazor.Shared {
    public class ProductCategoryEditDto {

       
        public int Id { get; set; }

        [Required]
        public String Code { get; set; } = null!;

        [Required]
        public String Description { get; set; } = null!;

        [Required]
        public ProductType ProductType { get; set; }
    }
}
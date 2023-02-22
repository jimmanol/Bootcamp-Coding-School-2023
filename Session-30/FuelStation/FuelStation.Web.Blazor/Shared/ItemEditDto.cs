using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Blazor.Shared {
    public class ItemEditDto {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "This code has more than 10 characters")]
        public string Code { get; set; }
        [Required]
        [MaxLength(40, ErrorMessage = "This description cannot be added")]
        public string Description { get; set; }
        [Required]

        public ItemType ItemType { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public decimal Cost { get; set; }
    }
}
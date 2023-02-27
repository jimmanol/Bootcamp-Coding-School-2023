using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Blazor.Shared {
    public class TransactionLineEditDto {

        public Guid Id { get; set; }

        [Required]
        [Range(0, 1000)]
        public int Quantity { get; set; }

        [Required]
        [Range(0, 99999999.99, ErrorMessage = "Price range is 0 to 99999999.99!")]
        public decimal ItemPrice { get; set; }

        [Required]
        [Range(0, 99999999.99)]
        public decimal NetValue { get; set; }

        [Required]
        [Range(0, 100.00, ErrorMessage = "Range 0% to 100%!")]
        public decimal DiscountPercent { get; set; }

        [Required]
        [Range(0, 99999999.99)]
        public decimal DiscountValue { get; set; }


        [Required]
        [Range(0, 99999999.99)]
        public decimal TotalValue { get; set; }

        // Relations
        public Guid TransactionId { get; set; }
        public Guid ItemId { get; set; }
        public ItemListDto Item { get; set; } = null!;

    }
}

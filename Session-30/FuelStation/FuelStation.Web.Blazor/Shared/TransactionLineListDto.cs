using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Blazor.Shared {
    public class TransactionLineListDto {

        public Guid Id { get; set; }


        public int Quantity { get; set; }

        public decimal ItemPrice { get; set; }

        public decimal NetValue { get; set; }

        public decimal DiscountPercent { get; set; }

        public decimal DiscountValue { get; set; }

        public decimal TotalValue { get; set; }

        // relations
        public Guid TransactionId { get; set; }
        public Guid ItemId { get; set; }
        public ItemListDto Item { get; set; } = null!;
    }
}

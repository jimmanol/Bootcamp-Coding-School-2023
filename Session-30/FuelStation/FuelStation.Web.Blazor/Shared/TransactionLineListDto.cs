using FuelStation.Model;
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
        
        public ItemListDto Item { get; set; } = null!;


        public TransactionLineListDto() {

        }
        public TransactionLineListDto(TransactionLine transactionLine) {
            Id = transactionLine.ID;
            Quantity = transactionLine.Quantity;
            DiscountPercent = transactionLine.DiscountPercent;
            Item = new ItemListDto(transactionLine.Item);
            ItemPrice = transactionLine.ItemPrice;
            NetValue = transactionLine.NetValue;
            DiscountValue = transactionLine.DiscountValue;
            TotalValue = transactionLine.TotalValue;
        }
    }
}

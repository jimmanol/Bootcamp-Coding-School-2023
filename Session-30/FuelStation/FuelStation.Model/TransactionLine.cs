using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model {
    public class TransactionLine {

        //properties
        public Guid ID { get; set; }
        public Guid TransactionID { get; set; }
        public Guid ItemID { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal NetValue { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal TotalValue { get; set; }

        //constructors
        public TransactionLine() {
            ID = Guid.NewGuid();
        }
        public TransactionLine(int quantity, decimal netValue, decimal discountPercent, decimal discountValue, decimal totalValue, Guid transactionId, Guid itemId) {
            ID = Guid.NewGuid();
            Quantity = quantity;
            NetValue = netValue;
            DiscountPercent = discountPercent;
            DiscountValue = discountValue;
            TotalValue = totalValue;
            TransactionID = transactionId;
            ItemID = itemId;
        }

        //relations
        public Transaction Transaction { get; set; }
        public Item Item { get; set; }


    }
}

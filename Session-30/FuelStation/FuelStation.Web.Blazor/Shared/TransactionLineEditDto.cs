using FuelStation.Model;
using FuelStation.Model.Enums;
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

        public ItemType ItemType { get; set; }

        // Relations
        public Guid TransactionId { get; set; }
        public Guid ItemId { get; set; }
        


        //ctors
        public TransactionLineEditDto() {

        }
        public TransactionLineEditDto(TransactionLine transactionLine) {
            Id = transactionLine.ID;
            Quantity = transactionLine.Quantity;
            DiscountPercent = transactionLine.DiscountPercent;
            ItemPrice = transactionLine.ItemPrice;
            NetValue = transactionLine.NetValue;
            DiscountValue = transactionLine.DiscountValue;
            TotalValue = transactionLine.TotalValue;
            TransactionId = transactionLine.TransactionID;
            ItemId = transactionLine.ItemID;
        }

    }
}

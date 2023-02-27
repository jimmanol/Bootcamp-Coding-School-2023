using FuelStation.Model.Enums;
using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Blazor.Shared {
    public class TransactionEditDto {


        // Properties
        public Guid Id { get; set; }

        [Required]
        public DateTime Date { get; set; }
        public decimal TotalValue { get; set; }

        [Required]
        public PaymentMethod PaymentMethod { get; set; }

        
        // Relations
        public Guid CustomerId { get; set; }
        public Customer? Customer { get; set; } = null!;

        public Guid EmployeeId { get; set; }
        public Employee? Employee { get; set; } = null!;

        public List<TransactionLineEditDto>? TransactionLines { get; set; } = new(); //List<TransactionLineEditDto>();


        // ctors
        public TransactionEditDto() {

        }
        public TransactionEditDto(Transaction transaction) {
            Id = transaction.ID;
            Date = transaction.Date;
            PaymentMethod = transaction.PaymentMethod;
            TotalValue = transaction.TotalValue;
            EmployeeId = transaction.EmployeeID;
            CustomerId = transaction.CustomerID;
            TransactionLines = transaction.TransactionLines.Select(t => new TransactionLineEditDto(t)).ToList();
        }

    }
}

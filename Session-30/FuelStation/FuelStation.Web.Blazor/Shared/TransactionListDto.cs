using FuelStation.Model.Enums;
using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Blazor.Shared {
    public class TransactionListDto {

        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalValue { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        
        // Relations
        public List<TransactionLineListDto> TransactionLines { get; set; } = new();
        public EmployeeListDto Employee { get; set; } = null!;
        public CustomerListDto Customer { get; set; } = null!;


        //ctors
        public TransactionListDto() {
        }

        public TransactionListDto(Transaction transaction) {
            Id = transaction.ID;
            Date = transaction.Date;
            PaymentMethod = transaction.PaymentMethod;
            TotalValue = transaction.TotalValue;
            Employee = new EmployeeListDto(transaction.Employee);
            Customer = new CustomerListDto(transaction.Customer);
        }

    }
}

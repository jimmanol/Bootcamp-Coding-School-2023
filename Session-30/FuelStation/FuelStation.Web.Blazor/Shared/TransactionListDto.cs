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
        public Guid CustomerId { get; set; }
        public Customer? Customer { get; set; } = null!;

        public Guid EmployeeId { get; set; }
        public List<TransactionLineEditDto> TransactionLines { get; set; } = new();

    }
}

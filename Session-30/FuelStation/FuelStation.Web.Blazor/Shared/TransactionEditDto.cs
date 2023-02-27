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
        [Range(1, 2, ErrorMessage = "You must choose a Payment Method!")]
        public PaymentMethod PaymentMethod { get; set; }

        // Relations
        public Guid CustomerId { get; set; }
        public Customer? Customer { get; set; } = null!;

        public Guid EmployeeId { get; set; }
        public Employee? Employee { get; set; } = null!;

        public List<TransactionLineEditDto>? TransactionLines { get; set; } = new List<TransactionLineEditDto>();


    }
}

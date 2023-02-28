using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelStation.Model;

namespace FuelStation.Web.Blazor.Shared {
    public class CustomerEditDto {

        [Required]
        public Guid ID { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 1)]
        public String Name { get; set; } = null!;

        [Required]
        [StringLength(20, MinimumLength = 1)]
        public String Surname { get; set; } = null!;

        [Required]
        [RegularExpression("^A.{0,}$", ErrorMessage = "CardNumber should start with 'A'.")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "CardNumber must be between 1 and 20 characters.")]
        public String CardNumber { get; set; } = null!;


        public CustomerEditDto() {
        }
        public CustomerEditDto(Customer customer) {
            ID = customer.ID;
            Name = customer.Name;
            Surname = customer.Surname;
            CardNumber = customer.CardNumber;
        }

        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelStation.Model;

namespace FuelStation.Web.Blazor.Shared {
    public class CustomerEditDto {

        public Guid ID { get; set; }
        public String Name { get; set; } = null!;

        public String Surname { get; set; } = null!;

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

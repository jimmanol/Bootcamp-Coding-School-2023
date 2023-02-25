using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelStation.Model;

namespace FuelStation.Web.Blazor.Shared {
    public class CustomerListDto {
        public Guid ID { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string CardNumber { get; set; } = null!;


        public CustomerListDto() {

        }
        public CustomerListDto(Customer customer) {
            ID = customer.ID;
            Name = customer.Name;
            Surname = customer.Surname;
            CardNumber = customer.CardNumber;
        }
    }
}


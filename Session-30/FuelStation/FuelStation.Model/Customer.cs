using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model {
    public class Customer {

        //properties
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CardNumber { get; set; }

        //constructors
        public Customer(string name, string surname, string cardNumber) {
            Name = name;
            Surname = surname;
            CardNumber = cardNumber;
            Transactions = new List<Transaction>();
        }


        //relations
        public List<Transaction> Transactions { get; set; } = null!;
    }
}



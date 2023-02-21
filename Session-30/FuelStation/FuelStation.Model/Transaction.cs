using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model {
    public class Transaction {

        //properties
        public Guid ID { get; set; }
        public DateTime Date { get; set; }
        public Guid EmployeeID { get; set; }
        public Guid CustomerID { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }
        public List<TransactionLine> TransactionLines { get; set; }  // part of relations too

        //constructors
        public Transaction() {
            ID = Guid.NewGuid();
            TransactionLines = new();
        }

        //relations
        public Employee Employee { get; set; }
        public Customer Customer { get; set; }
    }
}

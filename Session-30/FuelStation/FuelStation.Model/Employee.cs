using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model {
    public class Employee {

        //properties
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime HireDateStart { get; set; }
        public DateTime? HireDateEnd { get; set; }
        public decimal SalaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }

        //contructors
        public Employee() {
            ID = Guid.NewGuid();
        }

        //relations
        public List<Transaction> Transactions { get; set; } = null!;

    }
}

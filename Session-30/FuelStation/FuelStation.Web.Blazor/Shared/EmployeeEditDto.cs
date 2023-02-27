using FuelStation.Model.Enums;
using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FuelStation.Web.Blazor.Shared {
    public class EmployeeEditDto {
        public Guid Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Surname { get; set; }
        [Required]
        public DateTime HireDateStart { get; set; }
        public DateTime? HireDateEnd { get; set; }
        [Required]
        public decimal SalaryPerMonth { get; set; }
        [Required]
        public EmployeeType EmployeeType { get; set; }



        //relations
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();


        //ctors
        public EmployeeEditDto() {

        }
        public EmployeeEditDto(Employee employee) {
            Id = employee.Id;
            Name = employee.Name;
            Surname = employee.Surname;
            HireDateStart = employee.HireDateStart;
            HireDateEnd = employee.HireDateEnd;
            SalaryPerMonth = employee.SalaryPerMonth;
            EmployeeType = employee.EmployeeType;
        }
    }
}

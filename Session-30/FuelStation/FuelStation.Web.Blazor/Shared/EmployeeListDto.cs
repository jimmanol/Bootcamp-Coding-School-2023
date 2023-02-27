using FuelStation.Model;
using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Blazor.Shared {
    public class EmployeeListDto {

        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string Surname { get; set; } = null!;
        [Required]
        public DateTime HireDateStart { get; set; }
        public DateTime? HireDateEnd { get; set; }
        [Required]
        public decimal SalaryPerMonth { get; set; }
        [Required]
        public EmployeeType EmployeeType { get; set; }

        public EmployeeListDto() {

        }

        public EmployeeListDto(Employee employee) {
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

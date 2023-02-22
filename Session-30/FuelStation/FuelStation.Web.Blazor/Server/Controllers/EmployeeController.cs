using FuelStation.Web.Blazor.Shared;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace FuelStation.Web.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase {

        private readonly IEntityRepo<Employee> _employeeRepo;

        public EmployeeController(IEntityRepo<Employee> employeeRepo) {
            _employeeRepo = employeeRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeListDto>> Get() {
            var result = _employeeRepo.GetAll();
            return result.Select(employee => new EmployeeListDto {
                Id = employee.Id,
                Name = employee.Name,
                Surname = employee.Surname,
                EmployeeType = employee.EmployeeType,
                HireDateStart = employee.HireDateStart,
                HireDateEnd = employee.HireDateEnd,
                SalaryPerMonth = employee.SalaryPerMonth

            });
        }

        [HttpGet("{Id}")]
        public async Task<EmployeeEditDto> GetById(Guid id) {
            var result = _employeeRepo.GetById(id);
            return new EmployeeEditDto {
                Id = id,
                Name = result.Name,
                Surname = result.Surname,
                EmployeeType = result.EmployeeType,
                HireDateStart = result.HireDateStart,
                HireDateEnd = result.HireDateEnd,
                SalaryPerMonth = result.SalaryPerMonth
            };
        }

        [HttpPost]
        public async Task Post(EmployeeEditDto employee) {
            var newEmployee = new Employee(employee.Name, employee.Surname, employee.HireDateStart, employee.HireDateEnd, employee.SalaryPerMonth, employee.EmployeeType);
            newEmployee.Transactions = new();
            _employeeRepo.Add(newEmployee);
        }

        [HttpPut]
        public async Task Put(EmployeeEditDto employee) {
            var itemToUpdate = _employeeRepo.GetById(employee.Id);
            itemToUpdate.Id = employee.Id;
            itemToUpdate.Name = employee.Name;
            itemToUpdate.Surname = employee.Surname;
            itemToUpdate.EmployeeType = employee.EmployeeType;
            itemToUpdate.HireDateStart = employee.HireDateStart;
            itemToUpdate.HireDateEnd = employee.HireDateEnd;
            itemToUpdate.SalaryPerMonth = employee.SalaryPerMonth;

            _employeeRepo.Update(employee.Id, itemToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id) {
                _employeeRepo.Delete(id);
        }
    }
}

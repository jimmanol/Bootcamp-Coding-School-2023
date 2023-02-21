using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories {
    public class EmployeeRepo : IEntityRepo<Employee> {

        public IList<Employee> GetAll() {
            using var context = new FuelStationDbContext();
            return context.Employees
            .Include(employee => employee.Transactions)
            .ToList();

        }

        public Employee? GetById(Guid ID) {
            using var context = new FuelStationDbContext();
            return context.Employees
            .Where(employee => employee.ID == ID)
           .Include(employee => employee.Transactions).SingleOrDefault();

        }

        public void Add(Employee entity) {
            using var context = new FuelStationDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Update(Guid ID, Employee entity) {
            using var context = new FuelStationDbContext();
            var EmployeeDb = context.Employees
                .Where(employee => employee.ID == ID)
                .Include(employee => employee.Transactions)
                .SingleOrDefault();
            if (EmployeeDb is null) 
                throw new Exception($"Given id '{ID}' was not found");
            EmployeeDb.Name = entity.Name;
            EmployeeDb.Surname = entity.Surname;
            EmployeeDb.SalaryPerMonth = entity.SalaryPerMonth;
            EmployeeDb.EmployeeType = entity.EmployeeType;
            EmployeeDb.HireDateStart = entity.HireDateStart;
            EmployeeDb.HireDateEnd = entity.HireDateEnd;
            context.SaveChanges();
        }

        public void Delete(Guid ID) {
            using var context = new FuelStationDbContext();
            var EmployeeDb = context.Employees
                .Where(employee => employee.ID == ID)
                .Include(employee => employee.Transactions)
                .SingleOrDefault();
            if (EmployeeDb is null)
                throw new Exception($"Given id '{ID}' was not found");
            context.Remove(EmployeeDb);
            context.SaveChanges();
        }
    }
}

using FuelStation.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelStation.Model.Enums;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Configurations {
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee> {

        public void Configure(EntityTypeBuilder<Employee> builder) {

            //table  
            builder.ToTable("Employees");

            //primary Key
            builder.HasKey(employee => employee.ID);

            builder.Property(employee => employee.Name).HasMaxLength(20).IsRequired();
            builder.Property(employee => employee.Surname).HasMaxLength(20).IsRequired();
            builder.Property(employee => employee.EmployeeType).HasMaxLength(20).IsRequired();
            builder.Property(employee => employee.HireDateStart).IsRequired();
            builder.Property(employee => employee.HireDateEnd);
            builder.Property(employee => employee.SalaryPerMonth).HasPrecision(7, 2).IsRequired();
        }
    }
}

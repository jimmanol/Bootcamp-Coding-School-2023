using Microsoft.EntityFrameworkCore;
using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuelStation.EF.Configurations {
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction> {

        public void Configure(EntityTypeBuilder<Transaction> builder) {

            builder.ToTable("Transactions");

            builder.HasKey(transaction => transaction.ID);

            builder.Property(transaction => transaction.Date).IsRequired();
            builder.Property(transaction => transaction.EmployeeID).IsRequired();
            builder.Property(transaction => transaction.CustomerID).IsRequired();
            builder.Property(transaction => transaction.PaymentMethod).HasMaxLength(20).IsRequired();
            builder.Property(transaction => transaction.TotalValue).HasPrecision(9, 2).IsRequired();

            builder.HasOne(transaction => transaction.Customer)
               .WithMany(customer => customer.Transactions)
               .HasForeignKey(transaction => transaction.CustomerID)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(transaction => transaction.Employee)
                .WithMany(employee => employee.Transactions)
                .HasForeignKey(transaction => transaction.EmployeeID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

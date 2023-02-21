using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configurations {
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer> {

        public void Configure(EntityTypeBuilder<Customer> builder) {
            
            //table  
            builder.ToTable("Customers");

            //primary Key
            builder.HasKey(customer => customer.ID);

            builder.Property(customer => customer.Name).HasMaxLength(20).IsRequired();
            builder.Property(customer => customer.Surname).HasMaxLength(20).IsRequired();
            builder.Property(customer => customer.CardNumber).HasMaxLength(20).IsRequired();

            builder.HasIndex(customer => customer.CardNumber).IsUnique();


        }
    }
}

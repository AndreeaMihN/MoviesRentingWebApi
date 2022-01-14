using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movies.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Persistance.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(p => p.Id).HasColumnName("CustomerID");
            builder.Property(p => p.Name).HasMaxLength(40).IsRequired();
            builder.Property(p => p.Phone).HasMaxLength(12).IsRequired();
        }
    }
}

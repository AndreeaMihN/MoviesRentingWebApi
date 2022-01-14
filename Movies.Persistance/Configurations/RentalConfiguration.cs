using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movies.Domain.Entities;
using Movies.Persistance.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Persistance.Configurations
{
    public class RentalConfiguration : IEntityTypeConfiguration<Rental>
    {
        public void Configure(EntityTypeBuilder<Rental> builder)
        {
            builder.Property(e => e.Id).HasColumnName("RentalID");
            builder.Property(e => e.DateOut).IsRequired();
            builder.Property(e => e.RentalFee).HasPrecision(8, 2);
        }
    }
}

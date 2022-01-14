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
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.Property(e => e.Id).HasColumnName("MovieID");
            builder.Property(e => e.Title).IsRequired().HasMaxLength(15);
            builder.Property(e => e.DailyRentalRate).HasPrecision(8, 2);
        }
    }
}

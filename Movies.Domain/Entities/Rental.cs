using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Domain.Entities
{
    public class Rental
    {
        public int Id { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime? DateReturned { get; set; }
        public decimal? RentalFee { get; set; }
        public int CustomerId { get; set; }
        public int MovieId { get; set; }
        public Customer Customer { get; set; }
        public Movie Movie { get; set; }
    }
}

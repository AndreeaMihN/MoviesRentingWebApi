using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Domain.Entities
{
    public class Movie
    {
        public Movie()
        {
            Rental = new Collection<Rental>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int NumberInStock { get; set; }
        public decimal DailyRentalRate { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public ICollection<Rental> Rental { get; set; }

    }
}

using Movies.Domain.Entities;
using Movies.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Persistance.Repositories
{
    public class GenreRepositoy : Repository<Genre>, IGenreRepository
    {
        private readonly ApplicationContext context;
        GenreRepositoy(ApplicationContext context) : base(context) => this.context = context;

    }
}

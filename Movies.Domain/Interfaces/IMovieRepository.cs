using Movies.Domain.Entities;
using Movies.Domain.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Domain.Interfaces
{
    public interface IMovieRepository : IRepository<Movie>
    {
        Task<QueryResult<Movie>> GetPagedMovieList(MovieQuery movieQuery, CancellationToken cancellationToken);

        Task<Movie> GetMovieWithGenre(int movieId, CancellationToken cancellationToken);
    }
}

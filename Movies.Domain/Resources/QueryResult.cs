using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Domain.Resources
{
    public class QueryResult<TEntity>
    {
        public int TotalItems { get; set; }
        public IEnumerable<TEntity> Items { get; set; }
    }
}

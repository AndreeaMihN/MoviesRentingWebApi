using Movies.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Persistance.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext context;
        public UnitOfWork(ApplicationContext context) => this.context = context;

        public Task<int> SaveAsync(CancellationToken cancellationToken)
        {
            return this.context.SaveChangesAsync(cancellationToken);
        }
    }
}

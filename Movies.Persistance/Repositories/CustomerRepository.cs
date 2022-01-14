using Movies.Domain.Entities;
using Movies.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Persistance.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private readonly ApplicationContext context;
        public CustomerRepository(ApplicationContext context) : base(context) => this.context = context;
    }
}

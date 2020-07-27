using ReadExcelAndInsertMySQL.Domain.Entities;
using ReadExcelAndInsertMySQL.Domain.Interfaces.Repository;
using ReadExcelAndInsertMySQL.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ReadExcelAndInsertMySQL.Infra.Data.RepositoryCustomers
{
    public class CustomersRepository : ICustomersRepository
    {

        private readonly CustomersContext _context;
        public IQueryable<Customers> Entity { get; set; }

        public CustomersRepository(CustomersContext db, CustomersContext context)
        {
            Entity = db.Customers.AsQueryable();
            _context = context;
        }

        
        public void Insert(IEnumerable<Customers> customers)
        {
            _context.Customers.Add(customers.First());
        }
    }
    
}

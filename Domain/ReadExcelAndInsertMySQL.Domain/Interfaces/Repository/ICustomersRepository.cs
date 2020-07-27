using ReadExcelAndInsertMySQL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ReadExcelAndInsertMySQL.Domain.Interfaces.Repository
{
    public interface ICustomersRepository
    {
        void Insert(IEnumerable<Customers> customers);
    }
}

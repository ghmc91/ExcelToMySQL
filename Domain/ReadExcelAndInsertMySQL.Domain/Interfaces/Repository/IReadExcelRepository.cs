using ReadExcelAndInsertMySQL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadExcelAndInsertMySQL.Domain.Interfaces.Repository
{
    public interface IReadExcelRepository
    {
        IEnumerable<CustomersExcel> GetCustomers();
    }
}

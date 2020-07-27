using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadExcelAndInsertMySQL.Domain.Entities
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Customers> LoadData(IEnumerable<CustomersExcel> customersExcels, 
                                               IEnumerable<Customers> data)
        {
            return data.Select(x => new Customers
            {
                Id = x.Id,
                Name = customersExcels.Select(x => x.Name).Distinct().First()
            }).ToArray();
        }

    }
}

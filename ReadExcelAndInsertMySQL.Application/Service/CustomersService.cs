using ReadExcelAndInsertMySQL.Domain.Entities;
using ReadExcelAndInsertMySQL.Domain.Interfaces.Repository;
using ReadExcelAndInsertMySQL.Domain.Interfaces.Service;
using System.Collections.Generic;

namespace ReadExcelAndInsertMySQL.Application.Service
{
    public class CustomersService : ICustomersService
    {
        private readonly IReadExcelRepository _readExcelRepository;
        private readonly ICustomersRepository _customersRepository;


        public CustomersService(IReadExcelRepository readExcelRepository, ICustomersRepository customersRepository)
        {
            _readExcelRepository = readExcelRepository;
            _customersRepository = customersRepository;
        }
        public void InsertCustomer()
        {
            var customersExcel = _readExcelRepository.GetCustomers();
            IEnumerable<Customers> customersList = new List<Customers>();
            Customers customers = new Customers();

            var customers2 = customers.LoadData(customersExcel, customersList);
            _customersRepository.Insert(customers2);
        }
    }
}

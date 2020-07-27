using ReadExcelAndInsertMySQL.Domain.Interfaces.Service;
using System;

namespace ConsoleApp1
{
    public class Program
    {
        private readonly ICustomersService _customersService;
        
        public static void Main(string[] args)
        {
            ICustomersService customersService;
            customersService.InsertCustomer();
        }
    }
}

using ReadExcelAndInsertMySQL.Domain.Interfaces.Service;
using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp2
{
    public static class InsertInMySQL
    {
        private static readonly ICustomersService _customersService;
        public InsertInMySQL(ICustomersService customersService)
        {
            _customersService = customersService;
        }

        public void Insert()
        {
            _customersService.InsertCustomer();
        }

        public static void Main()
        {
            _customersService.InsertCustomer();
            
        }
    } 
    
}

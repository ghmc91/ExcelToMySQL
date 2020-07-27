using ReadExcelAndInsertMySQL.Application.Service;
using ReadExcelAndInsertMySQL.Domain.Interfaces.Repository;
using ReadExcelAndInsertMySQL.Domain.Interfaces.Service;

namespace ReadExcelAndInsertMySQL.Application
{
    public class Program
    {
       private readonly ICustomersService _customersService;        
        
       public void Insert()
        {
            _customersService.InsertCustomer();
        }
        

        public static void Main()
        {
            Program program = new Program();
            program.Insert();
        }


    }
}

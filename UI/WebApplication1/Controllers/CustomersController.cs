using Microsoft.AspNetCore.Mvc;
using ReadExcelAndInsertMySQL.Application.Service;

namespace WebApplication1.Controllers
{
    public class CustomersController : ControllerBase
    {
        private readonly CustomersService _customersService;
        public CustomersController(CustomersService customersService)
        {
            _customersService = customersService;
        }

        public void Insert()
        {
            _customersService.InsertCustomer();
        }
    }
}

using OfficeOpenXml;
using ReadExcelAndInsertMySQL.Application.Service;
using ReadExcelAndInsertMySQL.Domain.Entities;
using ReadExcelAndInsertMySQL.Domain.Interfaces.Service;
using ReadExcelAndInsertMySQL.Infra.Data.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    public class Insert
    {
        private readonly ICustomersService _customersService;

        public void Main()
        {
            _customersService.InsertCustomer();
        }
    }
}

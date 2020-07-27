using OfficeOpenXml;
using ReadExcelAndInsertMySQL.Domain.Entities;
using ReadExcelAndInsertMySQL.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ReadExcelAndInsertMySQL.Infra.Data.ReadExcelRepository
{
    public class ReadExcelRepository : IReadExcelRepository
    {
        public IEnumerable<CustomersExcel> GetCustomers()
        {
            var fi = new FileInfo(@"D:\\Arquivos\\clientes.xlsx");
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(fi))
            {
                var workbook = package.Workbook;
                var worksheet = workbook.Worksheets.First();
                int colCount = worksheet.Dimension.End.Column;  //get Column Count
                int rowCount = worksheet.Dimension.End.Row;
                List<CustomersExcel> customers = new List<CustomersExcel>();


                for (int row = 2; row <= rowCount; row++)
                {
                    CustomersExcel customer = new CustomersExcel();
                    for (int col = 1; col <= colCount; col++)
                    {

                        if (col == 1)
                        {
                            customer.Name = worksheet.Cells[row, col].Value?.ToString().Trim();
                        }
                        else
                        {
                            customer.Email = worksheet.Cells[row, col].Value?.ToString().Trim();
                        }
                    }

                    customers.Add(customer);
                }
                return customers;
            }
        }
    }
}

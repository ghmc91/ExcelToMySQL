using System;
using System.Collections.Generic;
using System.Text;

namespace ReadExcelAndInsertMySQL.Domain.Entities
{
    public class CustomersInfo
    {
        public int CustomersId { get; set; }
        public string Email { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }
    }
}

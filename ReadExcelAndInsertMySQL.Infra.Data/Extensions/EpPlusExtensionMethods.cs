using OfficeOpenXml;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReadExcelAndInsertMySQL.Infra.Data.Extensions
{
    public static class EpPlusExtensionMethods
    {
        public static IEnumerable<T> ConvertTableToObject<T>(this ExcelTable table) where T : new()
        {
            var tprops = (new T())
                .GetType()
                .GetProperties()
                .ToList();

            var start = table.Address.Start;
            var end = table.Address.End;
            var cells = new List<ExcelRangeBase>();

            for (var r = start.Row; r < end.Row; r++)
                for (var c = start.Column; c < end.Column; c++)
                    cells.Add(table.WorkSheet.Cells[r, c]);

            var groups = cells
                    .GroupBy(cell => cell.Start.Row)
                    .ToList();

            var colnames = groups
                    .First()
                    .Select((hcell, idx) => new { Name = hcell.Value.ToString(), index = idx })
                    .Where(o => tprops.Select(p => p.Name).Contains(o.Name))
                    .ToList();

            var rowvalues = groups
                    .Skip(1) //Exclude header
                    .Select(cg => cg.Select(c => c.Value).ToList());


            var collection = rowvalues.Select(row => 
            {
                var tNew = new T();
                colnames.ForEach(colname =>
                {
                    var val = row[colname.index];
                    var prop = tprops.First(p => p.Name == colname.Name);
                    prop.SetValue(tNew, val);
                });
                return tNew;
            });

            return collection;
        }
    }
}

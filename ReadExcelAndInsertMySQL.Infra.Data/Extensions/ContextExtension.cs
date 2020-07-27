using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;

namespace ReadExcelAndInsertMySQL.Infra.Data.Extensions
{
    public static class ContextExtension
    {
        public static void LoadMappings(this ModelBuilder m)
        {
            var typesToMap = Assembly.GetExecutingAssembly()
                                     .GetTypes()
                                     .Where(x => x.Namespace == "ReadExcelAndInsertMySQL.Infra.Data.Mappings"
                                              && x.IsClass
                                              && !x.IsSealed).ToArray();

            foreach (var t in typesToMap)
            {
                dynamic mappingClass = Activator.CreateInstance(t);
                m.ApplyConfiguration(mappingClass);
            }
        }
    }
}

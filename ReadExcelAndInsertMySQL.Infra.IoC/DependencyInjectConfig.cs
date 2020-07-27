using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ReadExcelAndInsertMySQL.Application.Service;
using ReadExcelAndInsertMySQL.Domain.Interfaces.Repository;
using ReadExcelAndInsertMySQL.Domain.Interfaces.Service;
using ReadExcelAndInsertMySQL.Infra.Data.Context;
using ReadExcelAndInsertMySQL.Infra.Data.ReadExcelRepository;
using ReadExcelAndInsertMySQL.Infra.Data.RepositoryCustomers;

namespace ReadExcelAndInsertMySQL.Infra.IoC
{
    public static class DependencyInjectConfig
    {
        public static void Register(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CustomersContext>(option => option
                                                               .UseMySql("server=127.0.0.1;user id=root;pwd=raca1981;database=customers",
                                                                                m => m.MigrationsAssembly("ReadExcelAndInsertMySQL.Infra.Data")));

            
            services.AddScoped<ICustomersRepository, CustomersRepository>();
            services.AddScoped<IReadExcelRepository, ReadExcelRepository>();

            services.AddTransient<ICustomersService, CustomersService>();

            services.BuildServiceProvider();
        }
    }
}

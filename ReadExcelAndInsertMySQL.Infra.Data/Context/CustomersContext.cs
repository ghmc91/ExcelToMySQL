using Microsoft.EntityFrameworkCore;
using ReadExcelAndInsertMySQL.Domain.Entities;
using ReadExcelAndInsertMySQL.Infra.Data.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadExcelAndInsertMySQL.Infra.Data.Context
{
    public class CustomersContext : DbContext
    {
        public CustomersContext(DbContextOptions<CustomersContext> options)
            : base(options)
        {

        }

        public DbSet<Customers> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.LoadMappings();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {

        }
    }
}

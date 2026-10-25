using C48EFCoreSession01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C48EFCoreSession01.DbContexts
{
    internal class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;DataBase=EFCoreDemo;Trusted_Connection=true;TrustServerCertificate=true");
        }
        #region DbSets
        public DbSet<Product>Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
       
        #endregion
    }
}

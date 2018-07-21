using Neudesic.EmployeeEntityFrame.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neudesic.EmployeeEntityFrame.DataContext
{
    public class EmployeeDataContext : DbContext
    {
        public DbSet<EmployeeModel> EmployeesDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost; Database=Employee; Trusted_Connection=True; MultipleActiveResultSets=True;");
            base.OnConfiguring(optionsBuilder);
        }

    }
}

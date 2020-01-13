using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreTestApp.Models
{
    public class SolDbContext: DbContext
    {

       public SolDbContext(DbContextOptions<SolDbContext> options) : base (options)
        {

        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreTestApp.Models
{
    public class SqlEmployeeRepository : IEmployeeRepository
    {
        private readonly SolDbContext db;
        public SqlEmployeeRepository(SolDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<Employee> GetAll()
        {
            return db.Employees;
        }

        public IList<Employee> ListAll()
        {
            return  db.Employees.ToList();
        }
    }
}

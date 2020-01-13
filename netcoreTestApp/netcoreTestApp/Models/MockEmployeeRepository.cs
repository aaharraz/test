using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreTestApp.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Department> _departmentList;
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _departmentList = new List<Department>() {
              new  Department() {Id = 1, Name = "IT", Address = "40 2 ST NW Calgary"},
              new  Department() {Id = 2, Name = "HR", Address = "12 3 ST NW Calgary"},
              new  Department() {Id = 3, Name = "PayRoll", Address = "103 50 AVE SW Calgary"}
        };
            _employeeList = new List<Employee>()
            {
                new Employee() {Id = 5, FirstName = "Nasser", LastName = "Harraz", JobTitle = "Software Developer", Address = "4032 44 AVE NE Calgary", DepartmentId = 1},
                new Employee() {Id = 6, FirstName = "John", LastName = "Mike", JobTitle = "Software Developer", Address = "4000 45 AVE SE Calgary", DepartmentId = 1},
                new Employee() {Id = 3, FirstName = "Edward", LastName = "Bat", JobTitle = "Software Developer", Address = "101 4 St NW Calgary", DepartmentId = 2},
                new Employee() {Id = 4, FirstName = "Sara", LastName = "Farwa", JobTitle = "Software Developer", Address = "205 12 ST SW Calgary", DepartmentId = 2}
            };
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employeeList;
        }

        public IList<Employee> ListAll()
        {
            return _employeeList;
        }
    }
}

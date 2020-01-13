using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using netcoreTestApp.Models;

namespace netcoreTestApp.Controllers
{

    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeesController(IEmployeeRepository employeeRepositry)
        {
            this._employeeRepository = employeeRepositry;
        }

        [HttpGet]
        public ActionResult<List<Employee>> Get()
        {
            //return _employeeRepository.GetAll().ToList();

            return new List<Employee>()
            {
                new Employee() {Id = 5, FirstName = "Nasser", LastName = "Harraz", JobTitle = "Software Developer", Address = "4032 44 AVE NE Calgary", DepartmentId = 1},
                new Employee() {Id = 6, FirstName = "John", LastName = "Mike", JobTitle = "Software Developer", Address = "4000 45 AVE SE Calgary", DepartmentId = 1},
                new Employee() {Id = 3, FirstName = "Edward", LastName = "Bat", JobTitle = "Software Developer", Address = "101 4 St NW Calgary", DepartmentId = 2},
                new Employee() {Id = 4, FirstName = "Sara", LastName = "Farwa", JobTitle = "Software Developer", Address = "205 12 ST SW Calgary", DepartmentId = 2}
            };
        }

        //department/{departmentId

        [HttpGet("department/{departmentId}")]
        public IActionResult getEmployeesbyDeptId(int departmentId)
        {

            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreTestApp.Models
{
    public class Department
    {
        public Department()
        {
            Employees = new Collection<Employee>();

        }
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string Address { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}

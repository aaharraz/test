﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreTestApp.Models
{
    [Table("Employees")]
    public class Employee
    {
        public Employee()
        {
        }

        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
        [Required]
        [StringLength(100)]
        public string JobTitle { get; set; }
        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        public Department Department { get; set; }
        public int DepartmentId { get; set; }
    }
}

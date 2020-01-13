﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreTestApp.Models
{
   public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        IList<Employee> ListAll();

    }
}

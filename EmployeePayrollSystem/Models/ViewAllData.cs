using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePayrollSystem.Models
{
    public class ViewAllData
    {
        public Department department { get; set; }
        public Designation designation { get; set; }
        public Employee employee { get; set; }
        public Salary salary { get; set; }
    }
}
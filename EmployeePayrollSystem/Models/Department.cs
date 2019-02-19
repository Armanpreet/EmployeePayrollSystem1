using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeePayrollSystem.Models
{
    public class Department
    {
        [Key]
        public int DepttId { get; set; }
        public string DepttName { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
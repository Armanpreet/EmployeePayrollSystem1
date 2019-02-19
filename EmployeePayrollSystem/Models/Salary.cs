using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeePayrollSystem.Models
{
    public class Salary
    {
        [Key]
        public int SalaryId { get; set; }
        public int EmpId { get; set; }
        public Employee Employee { get; set; }
        public double BasicSalary { get; set; }
        public double Taxes { get; set; }
        public double TotalSalary { get; set; }

    }
}
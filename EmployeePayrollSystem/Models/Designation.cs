using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeePayrollSystem.Models
{
    public class Designation
    {
        [Key]
        public int DesignId { get; set; }
        [Display(Name ="Designation Name")]
        public string DesiName { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
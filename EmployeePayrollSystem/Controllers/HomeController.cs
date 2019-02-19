using EmployeePayrollSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeePayrollSystem.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        public ActionResult ManagerData()
        {
            using (var de = new ApplicationDbContext())
            {
                var data = (from d in db.Departments
                            join e in db.Employees on d.DepttId equals e.DepttId
                            join ds in db.Designations on e.DesignId equals ds.DesignId
                            select new ViewAllData {department = d,designation = ds, employee = e }).ToList();
                return View(data);
            }
                
                     
           // return View();
        }
    }
}
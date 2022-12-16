using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomFilter.Models;
using CustomFilter.CustomFilter;

namespace CustomFilter.Controllers
{
    [SwadhinFilter]
    public class EmployeeController : Controller
    {
        // GET: Employee

        //[Authorize]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1_clientsidevalidations.Models;

namespace Task1_clientsidevalidations.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Registration reg)
        {
            return RedirectToAction("empdashboard");
        }
        public ActionResult empdashboard()
        {
            return View();
        }
    }
}
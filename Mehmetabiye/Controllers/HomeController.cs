using Mehmetabiye.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mehmetabiye.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            StudentModel _studentmodel = new StudentModel();
            return View(_studentmodel);
        }
        [HttpPost]

        public ActionResult Index(String StudentName)
        {
            return View();
        }
    }
}
using HomeworkAssignment4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeworkAssignment4.Controllers
{
    public class HomeController : Controller
    {
     
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyEcoPlan()

        {
            ViewBag.Message = "My Eco Plan";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Plans()
        {

            return View();
        }

        public static List<Plan> plans = new List<Plan>();

        public ActionResult TPlans()
        {

            return View(plans);
        }
    }
}
using ReadWayInternationCollege.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReadWayInternationCollege.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult Contact()
        {
            var sendAMessageViewModel = new SendAMessageViewModel();
            return View(sendAMessageViewModel);
        }


        [HttpPost]
        public ActionResult Contact(SendAMessageViewModel sendAMessageViewModel)
        {
            return Content("message sent");
        }
    }
}
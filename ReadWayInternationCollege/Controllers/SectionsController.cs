using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReadWayInternationCollege.Controllers
{
    public class SectionsController : Controller
    {
        public ActionResult Kindergarten()
        {
            return View();
        }

        public ActionResult Primary()
        {
            return View();
        }

        public ActionResult Secondary()
        {
            return View();
        }
    }
}
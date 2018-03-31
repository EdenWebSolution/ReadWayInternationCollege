using ReadWayInternationalCollege.Services.ImagePathService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReadWayInternationCollege.Controllers
{
    public class HomeController : Controller
    {
        private readonly ImagePathService _imagePathService;
        public HomeController(ImagePathService imagePathService)
        {
            _imagePathService = imagePathService;
        }
        public ActionResult Index()
        {
            var paths = _imagePathService.GetImagePath();
            return View(paths);
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
    }
}
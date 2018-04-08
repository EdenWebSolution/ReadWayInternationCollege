using ReadWayInternationCollege.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Web.Mvc;
using RedWillow.MvcToastrFlash;
using ReadWayInternationCollege.Mailer;

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
        public async Task<ActionResult> Contact(SendAMessageViewModel sendAMessageViewModel)
        {
            try
            {
                var messageBuilder = new EmailBuilder()
                {
                    To = "principal@readwayinternalcollege.com",
                    Subject = sendAMessageViewModel.Subject,
                    Body = "Sender Name: " + sendAMessageViewModel.Name + "\n\nSender Email: " + sendAMessageViewModel.EmailAddress + "\n\n" + sendAMessageViewModel.Message,
                };
                await EmailBuilder.SendEmailAsync(messageBuilder);
                this.Flash(Toastr.SUCCESS, "Sent", "Your message has been sent successfull");
                return RedirectToAction("Contact", "Home");

            }

            catch(Exception ex)

            {
                this.Flash(Toastr.ERROR, "Fail", "Oops! Something went wrong while sending your message. Please try again");
                return RedirectToAction("Contact", "Home");
            }
        }
    }
}
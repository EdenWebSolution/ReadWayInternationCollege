using ReadWayInternationCollege.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Web.Mvc;
using RedWillow.MvcToastrFlash;
using ReadWayInternationCollege.Mailer;
using ReadWayInternationCollege.Enumerations;

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
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(SendAMessageViewModel sendAMessageViewModel)
        {
            try
            {
                var messageBuilder = new EmailBuilder()
                {
                    From = "d015240@student.nibm.lk",
                    To = "tnlthanzeel@gmail.com",
                    Subject = sendAMessageViewModel.Subject,
                    Body = "Dear Sir/Madam, I am " + sendAMessageViewModel.Name + ".\nMy Email address is " + sendAMessageViewModel.EmailAddress + ".\n\n" + sendAMessageViewModel.Message,
                };
                await EmailBuilder.SendEmailAsync(messageBuilder);

                return Json(new { status = TransactionStatusEnum.success, subject = "Sent", message = "Your message has been sent successfully" }, JsonRequestBehavior.AllowGet);
            }

            catch (Exception)
            {
                return Json(new { status = TransactionStatusEnum.fail, subject = "Failed", message = "Oops! Something went wrong while sending your message. Please try again" }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Gallery(SendAMessageViewModel sendAMessageViewModel)
        {
            return View();
        }
    }
}
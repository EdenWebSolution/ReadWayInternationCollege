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
using Microsoft.Security.Application;
using ReadWayInternationCollege.MailTemplates;
using System.ComponentModel.DataAnnotations;
using ReadWayInternationCollege.Services;

namespace ReadWayInternationCollege.Controllers
{

    public class HomeController : Controller
    {
        private readonly GalleryFilePathService _galleryFilePathService;

        public HomeController(GalleryFilePathService galleryFilePathService)
        {
            _galleryFilePathService = galleryFilePathService;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        [HttpGet]
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
                sendAMessageViewModel.PhoneNumber = Sanitizer.GetSafeHtmlFragment(sendAMessageViewModel.PhoneNumber);
                sendAMessageViewModel.Message = Sanitizer.GetSafeHtmlFragment(sendAMessageViewModel.Message);
                sendAMessageViewModel.Name = Sanitizer.GetSafeHtmlFragment(sendAMessageViewModel.Name);
                sendAMessageViewModel.Subject = Sanitizer.GetSafeHtmlFragment(sendAMessageViewModel.Subject);
                sendAMessageViewModel.EmailAddress = Sanitizer.GetSafeHtmlFragment(sendAMessageViewModel.EmailAddress);

                var messageBuilder = new EmailBuilder()
                {
                    From = MailingList.MailFromNoReply,
                    To = MailingList.ToAllStaff,
                    Subject = "Inquiry",
                    IsBodyHtml = true,
                    Body = BuildMailTemplate.CreateContactUsTemplate(sendAMessageViewModel)
                };
                await EmailBuilder.SendEmailAsync(messageBuilder, sendAMessageViewModel.EmailAddress);
                return Json(new { status = TransactionStatusEnum.success, subject = "Sent", message = "Your message has been sent successfully" }, JsonRequestBehavior.AllowGet);
            }

            catch (Exception ex)
            {
                return Json(new { status = TransactionStatusEnum.fail, subject = "Failed", message = ex.Message.ToString() }, JsonRequestBehavior.AllowGet);

                //return Json(new { status = TransactionStatusEnum.fail, subject = "Failed", message = "Oops! Something went wrong while sending your message. Please try again" }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Gallery()
        {
            return View();
        }

        public ActionResult ShowImages(string id)
        {
            if (string.IsNullOrEmpty(id)) return RedirectToAction("Gallery");
            var ImagePaths = _galleryFilePathService.GetImagePath(id);
            return View("album", ImagePaths);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SendMoreInfo(string emailAddress)
        {
            var safeEmail = Sanitizer.GetSafeHtmlFragment(emailAddress);
            try
            {
                return Json(new { status = TransactionStatusEnum.success, subject = "Sent", message = "Your message has been sent successfully" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                return Json(new { status = TransactionStatusEnum.fail, subject = "Failed", message = "Oops! Something went wrong while sending your message. Please try again" }, JsonRequestBehavior.AllowGet);
            }

        }
        public ActionResult Admissions()
        {
            return View();
        }

        public ActionResult Career()
        {
            return View();

        }



    }
}
using ReadWayInternationCollege.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace ReadWayInternationCollege.MailTemplates
{

    public static class BuildMailTemplate
    {
        public static string CreateContactUsTemplate(SendAMessageViewModel sendAMessageViewModel)
        {

            //string body = string.Empty;
            //using (var reader = new StreamReader(HttpContext.Current.Server.MapPath("~/MailTemplates/ContactUsTemplate.html")))
            //{
            //    body = reader.ReadToEnd();
            //}
            //body = body.Replace("{name}", sendAMessageViewModel.Name);
            //body = body.Replace("{email}", sendAMessageViewModel.EmailAddress);
            //body = body.Replace("{date}", DateTime.Now.Date.ToShortDateString());
            //body = body.Replace("{phonenumber}", sendAMessageViewModel.PhoneNumber);
            //body = body.Replace("{subject}", sendAMessageViewModel.Subject);
            //body = body.Replace("{message}", sendAMessageViewModel.Message);
            //return body;

            var template = new StringBuilder();

            template.Append("<html>");
            template.Append("<head>");
            template.Append("</head>");
            template.Append("<body style=\"background:#f5eeee\">");
            template.Append("<div style=\"max-width:700px; margin:auto; background:#fff; height:700px\">");
            template.Append("<h1 style=\"display: block; margin: 0;padding: 20px 0;font-size: 30px;font-weight: 400;color: #0740a0;text-align: center;background: #ccc;\">Mail from readway international college</h1>");
            template.Append("<table width=\"100%\" style=\"max-width:700px\" cellspacing=\"0\" cellpadding=\"0\" border-color=\"#fff\">");
            template.Append("<tr>");
            template.Append("<td>");
            template.Append("<p style=\"background: #6d6d6d; padding: 20px; color: #fff; margin: 0; font-size: 22px; margin: 0;\">");
            template.Append("<i style=\"margin: 5px;\" class=\"fa fa-user-circle\"></i>{name}");
            template.Append("</p>");
            template.Append("</td>");
            template.Append("<td>");
            template.Append("<p style=\"background: #0740a0; padding: 20px; color: #fff; margin: 0;font-size: 22px;margin: 0;\">");
            template.Append("<i style=\"margin: 5px;\" class=\"fa fa-envelope\"></i><a style=\"color: #fff; text-decoration: none;\" href=\"mailto:{email}\">{email}</a>");
            template.Append("</p>");
            template.Append("</td>");
            template.Append("</tr>");
            template.Append("<tr>");
            template.Append("<td>");
            template.Append("<p style=\"background: #0740a0; padding: 10px 20px; color: #fff; margin: 0;font-size: 22px;\">");
            template.Append("<i style=\"margin: 5px;\" class=\"fa fa-calendar\"></i>{date}");
            template.Append("</p>");
            template.Append("</td>");
            template.Append("<td>");
            template.Append("<p style=\"background: #6d6d6d; padding: 10px 20px; color: #fff; margin: 0; font-size: 22px;\"><i style=\"margin: 5px;\" class=\"fa fa-phone\"></i>{phonenumber}</p>");
            template.Append("</td>");
            template.Append("</tr>");
            template.Append("</table>");
            template.Append("<table width=\"100%\" style=\"max-width:700px\" cellspacing=\"0\" cellpadding=\"0\" border-color=\"#fff\">");
            template.Append("<tr>");
            template.Append("<td>");
            template.Append("<p style=\"border-bottom: 2px solid #ccc;font-size: 35px; padding: 20px; margin: 0;\">Subject-</p>");
            template.Append("</td>");
            template.Append("<td>");
            template.Append("<p style=\"border-bottom: 2px solid #ccc;font-size: 35px; padding: 20px; margin: 0;\">{subject}</p>");
            template.Append("</td>");
            template.Append("</tr>");
            template.Append("<tr>");
            template.Append("<td>");
            template.Append("<p style=\"font-size: 35px; padding:20px; margin: 0;\">Message-</p>");
            template.Append("</td>");
            template.Append("<td>");
            template.Append("<p style=\"padding: 20px; margin: 0;\">{message}</p>");
            template.Append("</td>");
            template.Append("</tr>");
            template.Append("</table>");
            template.Append("</div>");
            template.Append("</body>");
            template.Append("</html>");


            template = template.Replace("{name}", sendAMessageViewModel.Name);
            template = template.Replace("{email}", sendAMessageViewModel.EmailAddress);
            template = template.Replace("{date}", DateTime.Now.Date.ToShortDateString());
            template = template.Replace("{phonenumber}", sendAMessageViewModel.PhoneNumber);
            template = template.Replace("{subject}", sendAMessageViewModel.Subject);
            template = template.Replace("{message}", sendAMessageViewModel.Message);

            return template.ToString();
        }
    }
}
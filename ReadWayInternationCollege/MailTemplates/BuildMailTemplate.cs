using ReadWayInternationCollege.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ReadWayInternationCollege.MailTemplates
{

    public static class BuildMailTemplate
    {
        public static string CreateContactUsTemplate(SendAMessageViewModel sendAMessageViewModel)
        {

            string body = string.Empty;
            using (var reader = new StreamReader(HttpContext.Current.Server.MapPath("~/MailTemplates/ContactUsTemplate.html")))
            {
                body = reader.ReadToEnd();
            }
            body = body.Replace("{subject}", sendAMessageViewModel.Subject);
            body = body.Replace("{parentName}", sendAMessageViewModel.Name);

            return body;
        }
    }
}
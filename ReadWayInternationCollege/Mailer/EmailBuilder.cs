using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace ReadWayInternationCollege.Mailer
{
    public class EmailBuilder
    {
        //private static readonly string EncryptionKey = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static MailMessage mailMessage;
        private static SmtpClient smtpClient;

        public EmailBuilder()
        {
            smtpClient = new SmtpClient();
        }

        public string Subject { get; set; }

        public string Body { get; set; }

        public bool IsBodyHtml { get; set; }

        public string[] To { get; set; }

        public static async Task SendEmailAsync(EmailBuilder messageBuilder, string replyTo)
        {
            mailMessage = new MailMessage
            {
                IsBodyHtml = messageBuilder.IsBodyHtml,
                Subject = messageBuilder.Subject,
                Body = messageBuilder.Body
            };
            mailMessage.From = new MailAddress(mailMessage.From.Address, mailMessage.From.DisplayName);
            if (replyTo != "") mailMessage.ReplyToList.Add(replyTo);

            foreach (var emailAddress in messageBuilder.To)
                mailMessage.To.Add(emailAddress);

            await smtpClient.SendMailAsync(mailMessage);
            mailMessage.Dispose();

        }
    }
}



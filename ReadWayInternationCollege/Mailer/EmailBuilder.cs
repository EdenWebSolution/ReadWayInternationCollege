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
        private static readonly string EncryptionKey = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static MailMessage mailMessage;
        private static SmtpClient smtpClient;

        public EmailBuilder()
        {
            smtpClient = new SmtpClient();
        }

        public string Subject { get; set; }

        public string Body { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public bool IsBodyHtml { get; set; }

        public string[] ToMany { get; set; }


        public static async Task SendEmailAsync(EmailBuilder messageBuilder)
        {
            mailMessage = new MailMessage(messageBuilder.From, messageBuilder.To)
            {
                IsBodyHtml = messageBuilder.IsBodyHtml,
                Subject = messageBuilder.Subject,
                Body = messageBuilder.Body
            };
            await smtpClient.SendMailAsync(mailMessage);
        }
    }
}


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

        public bool IsBodyHtml { get; set; }

        public string[] To { get; set; }


        public static async Task SendEmailAsync(EmailBuilder messageBuilder, string replyTo)
        {
            foreach (var emailAddress in messageBuilder.To)
            {
                mailMessage = new MailMessage(messageBuilder.From, emailAddress)
                {
                    IsBodyHtml = messageBuilder.IsBodyHtml,
                    Subject = messageBuilder.Subject,
                    Body = messageBuilder.Body,
                };

                if (replyTo != "") mailMessage.ReplyToList.Add(replyTo);
                await smtpClient.SendMailAsync(mailMessage);
            }
        }
    }
}


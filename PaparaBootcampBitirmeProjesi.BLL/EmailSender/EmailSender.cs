using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.BLL.EmailSender
{
    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration configuration;

        public EmailSender(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public void SendEmail(string email, string subject, string message)
        {
            MailMessage mail = new MailMessage();
            mail.IsBodyHtml = true;
            mail.To.Add(email);
            mail.From = new MailAddress(configuration["Mail:name"], "Papara", System.Text.Encoding.UTF8);
            mail.Subject = subject;
            mail.Body = message;

            SmtpClient smp = new SmtpClient();
            smp.UseDefaultCredentials = false;
            smp.Credentials = new NetworkCredential(configuration["Mail:name"], configuration["Mail:password"]);
            smp.Port = 587;
            smp.Host = "smtp.office365.com";
            smp.EnableSsl = true;
            smp.Send(mail);

        }
    }
}

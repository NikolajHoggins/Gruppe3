using System;
using System.Net.Mail;

namespace Gruppe3
{
    class MailController
    {
        public static SmtpClient CreateConnection(string username, string password, string host = "smtp.gmail.com", int port = 587)
        {
            SmtpClient mailClient = new SmtpClient(host);
            mailClient.Port = port;
            mailClient.Credentials = new System.Net.NetworkCredential(username, password);
            return mailClient;
        }

        public static MailMessage CreateMail(string username, string toMail, string subject, string body = "")
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(username);
            mail.To.Add(toMail);
            mail.Subject = subject;
            mail.Body = body;
            return mail;
        }
    }
}

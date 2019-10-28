using System;
using System.Net.Mail;

namespace Gruppe3
{
    class Functions
    {
        public static bool SendEmail()
        {
            string username = "niko9743@gmail.com";
            SmtpClient mailClient = MailController.CreateConnection(username, "olivia75");
            try
            {
                mailClient.Send(MailController.CreateMail(username, "mollevip@gmail.com", "Dinmor", "Yeet nibba"));
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            
        }
    }
}

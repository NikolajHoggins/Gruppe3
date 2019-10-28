using System;
using System.Net.Mail;

namespace Gruppe3
{
    class Functions
    {
        public static bool SendEmail(string reciever, string subject, string body = "")
        {
            string username = "niko9743@gmail.com";
            string password = "olivia75";

            SmtpClient mailClient = MailController.CreateConnection(username, password);
            try
            {
                mailClient.Send(MailController.CreateMail(username, reciever, subject, body));
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            
        }

        public static void WriteInfo(string[] info)
        {
            
        }

        public static Array UserInfo()
        {
            string[] output = new string[3];
            return output;
        }
    }
}

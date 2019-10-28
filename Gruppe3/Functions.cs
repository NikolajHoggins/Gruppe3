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

        public static void WriteInfo(string[] info)
        {
            using System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"Gruppe3\Gruppe3\UserInfo.text", true); // define the folder and file path.
            file.WriteLine(info[0], info[1], info[3]); // write to the file.
        }

        public static Array UserInfo()
        {
            string[] output = System.IO.File.ReadAllLines(@"Gruppe3\Gruppe3\UserInfo.text"); // read all lines and put them in a new string called output.
            return output;
        }
    }
}

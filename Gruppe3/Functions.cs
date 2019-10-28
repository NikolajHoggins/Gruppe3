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

        // Append user data to the file.
        public static void WriteInfo(string[] info)
        {
            string CurDir = System.IO.Directory.GetCurrentDirectory(); // gets current directory.
            using System.IO.StreamWriter file =
                new System.IO.StreamWriter(@""+ CurDir + "/UserInfo.text", true); // define the folder and file path.
            file.WriteLine(info[0], info[1], info[3]); // write to the file. note this will add a new line after it has written all valuses.
            Console.WriteLine("Write success! (i hope.)");
        }

        // This is for pulling the user data from the text file.
        public static Array[] UserInfo()
        {
            string CurDir = System.IO.Directory.GetCurrentDirectory();
            string[] output = System.IO.File.ReadAllLines(@""+ CurDir +"/UserInfo.text"); // read all lines and put them in a new string called output.
            return output;
        }
    }
}

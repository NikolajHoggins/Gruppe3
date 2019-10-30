using System;
using System.Net.Mail;
using System.Net.Http;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

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
        public static string AddUser(string[] info)
        {
            string requesturl = $"https://nikolaj.bricksite.net/adduser/{info[1]}/{info[0]}/{info[2]}";
            string html = string.Empty;
            string url = requesturl;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }

            return html;
        }

        public static string GetUsers(string hoved)
        {
            string requesturl = $"https://nikolaj.bricksite.net/getusergroup/asasds/{hoved}";
            string html = string.Empty;
            string url = requesturl;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }
            foreach (var item in html)
            {
                Console.WriteLine(item);
            }
            
            return html;
        }
        //public static void S
    }
}

using System;
using System.Net.Mail;
using System.Net.Http;
using System.Net;
using System.IO;

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

        // Append user data to the file.
        public static void WriteInfo(string[] info)
        {
            string CurDir = System.IO.Directory.GetCurrentDirectory(); // gets current directory.
            using System.IO.StreamWriter file =
                new System.IO.StreamWriter(@""+ CurDir + "/UserInfo.text", true); // define the folder and file path.

            foreach (var item in info)
            {
                file.Write(item+",");
            }
            file.Write("\n");// write to the file. note this will add a new line after it has written all valuses.
            Console.WriteLine("Write success! (i hope.)");
        }

        // This is for pulling the user data from the text file.
        public static string[] UserInfo()
        {
            string CurDir = System.IO.Directory.GetCurrentDirectory();
            string[] output = System.IO.File.ReadAllLines(@""+ CurDir +"/UserInfo.text"); // read all lines and put them in a new string called output.
            return output;
        }

        private static readonly HttpClient client = new HttpClient();

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

        /*public static string HttpPostRequest() // if this is not what you were looking for dellet it.
        {
            var values = new Dictionary<string, string>
            {
            { "thing1", "hello" },
            { "thing2", "world" }
            };

            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync("http://www.example.com/recepticle.aspx", content);

            var responseString = await response.Content.ReadAsStringAsync();
        }*/

        //public static void S
    }
}

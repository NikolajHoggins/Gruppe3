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
        public static string AddUser(string[] info)
        {
            string requesturl = $"https://nikolaj.bricksite.net/adduser/{info[0]}/{info[1]}/{info[2]}";
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
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Gruppe3
{

    class JSONHandler
    {
        public static string WriteJson(int type, string[] data) {
            
            using (StreamWriter file = File.CreateText(@""+ Directory.GetCurrentDirectory() + "\\movie.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, data);
                return "saved to " + Directory.GetCurrentDirectory();
            }
            return "fat error";
        }
        public static string[] GetJson(int type)
        {
            string[] response = { "meme", "joinks"};
            return response;
        }

    }
}

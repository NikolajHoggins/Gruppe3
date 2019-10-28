using System;

namespace Gruppe3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answer = Functions.SendEmail();
            //string[] info =  Emails();
        }

        static string[] Emails()
        {
            Console.WriteLine("Sign up for emails with your classroom");
            Console.Write("Enter name: ");
            string name = Console.ReadLine().ToLower().Trim();
            Console.Write("Enter email: " );
            string email = Console.ReadLine().ToLower().Trim();
            Console.WriteLine("Courses: h1, h2, h3, h4, h5, h6");
            Console.Write("Enter course: ");
            string course = Console.ReadLine().ToLower().Trim();
            string[] info = { name, email, course}; 
            return info;
        }

    }
}

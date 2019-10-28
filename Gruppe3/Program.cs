using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace mailregextest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] info = Emails();
            foreach (var item in info)
            {
                Console.WriteLine(item);
            }
        }

        static string[] Emails()
        {
            Console.WriteLine("Sign up for emails, to get notified with classroom location");
            Console.Write("Enter name: ");
            string name = Console.ReadLine().ToLower().Trim();
            Console.Write("Enter email: ");
            string email = Console.ReadLine().ToLower().Trim();
            IsValidEmail(email);
            while (IsValidEmail(email) != true)
            {
                if (IsValidEmail(email) == false)
                {
                    Console.WriteLine("Email invalid!");
                    Console.Write("Enter email: ");
                    email = Console.ReadLine().ToLower().Trim();
                }
            }
            Console.WriteLine("Courses: h1, h2, h3, h4, h5, h6");
            Console.Write("Enter course: ");
            string course = Console.ReadLine().ToLower().Trim();
            course = CourseCheck(course);
            while (course == "invalid")
            {
                Console.WriteLine("Courses: h1, h2, h3, h4, h5, h6");
                Console.Write("Enter course: ");
                course = Console.ReadLine().ToLower().Trim();
                course = CourseCheck(course);
            }
            string[] info = { name, email, course };
            return info;
        }

        static bool IsValidEmail(string inputEmail)
        {
            string strRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string CourseCheck(string course)
        {
            if (course == "h1")
            {
                return course;
            }
            else if (course == "h2")
            {
                return course;
            }
            else if (course == "h3")
            {
                return course;
            }
            else if (course == "h4")
            {
                return course;
            }
            else if (course == "h5")
            {
                return course;
            }
            else if (course == "h6")
            {
                return course;
            }
            else
            {
                Console.WriteLine("Invalid input");
                return "invalid";
            }
        }
    }
}

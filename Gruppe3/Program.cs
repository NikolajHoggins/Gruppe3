using System;
using System.Text.RegularExpressions;

namespace Gruppe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Functions.GetUsers("h1"));
            Console.ReadKey();
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("============================================================");
                Console.WriteLine("Email notification with class room for your course!");
                Console.WriteLine("============================================================");
                Console.WriteLine("Enter the number to subscribe, unsubscribe or exit the app");
                Console.WriteLine("[1] Subscribe");
                Console.WriteLine("[2] Unsubscribe");
                Console.WriteLine("[3] Exit the app");
                Console.WriteLine("============================================================");
                string number = TryToParse(Console.ReadLine());
                Console.Clear();
                if (number == "1")
                {
                    string[] signupInfo = Emails();
                    Console.WriteLine(Functions.AddUser(signupInfo)); 
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (number == "2")
                {
                    Unsub();
                    Console.Clear();
                }
                else if (number == "3")
                {
                    isRunning = false;
                }
            } 
        }

        static string[] Emails()
        {
            Console.WriteLine("Sign up for emails, to get notified with classroom location");
            Console.Write("Enter name: ");
            string name = Console.ReadLine().Trim();
            IsValidName(name);
            while (IsValidName(name) != true)
            {
                if (IsValidName(name) == false)
                {
                    Console.WriteLine("Name invalid!");
                    Console.Write("Enter name: ");
                    name = Console.ReadLine().ToLower().Trim();
                }
            }
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

        static bool IsValidName(string inputName)
        {
            string strRegex = @"^[a-zA-Z\s]+$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string Unsub()
        {
            Console.WriteLine("unsubcribe emails");
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
            return email;
        }

        static string TryToParse(string parseString)
        {
            bool result = Int32.TryParse(parseString, out int j);
            if (result == true)
            {
                return parseString;
            }
            else
            {
                return ("Did you type 1, 2 or 3? Try again!");
                
            }
        }
    }
}

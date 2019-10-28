using System;

namespace Gruppe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static string Emails()
        {
            Console.WriteLine("Sign up for emails with your classroom");
            Console.Write("Enter name: ");
            string nameToLower = Console.ReadLine().ToLower();
            Console.Write("Enter email: " );
            string email = Console.ReadLine();


            return nameToLower;
        }

    }
}

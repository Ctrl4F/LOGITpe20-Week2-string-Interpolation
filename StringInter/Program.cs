using System;

namespace StringInter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string FirstName;
            string LastName;
            Console.WriteLine("What is your first name?");
            FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            LastName = Console.ReadLine();

            Console.WriteLine($"Hello, {FirstName} {LastName}");


        }
    }
}

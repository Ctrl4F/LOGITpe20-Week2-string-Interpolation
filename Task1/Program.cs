using System;

namespace Task1
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
            
            Console.WriteLine("What is your year of birth?");
            string UserInput;
            UserInput = Console.ReadLine();
            int YearOfBirth;
            YearOfBirth = Int32.Parse(UserInput);
            int Age = 2020 - YearOfBirth;
            
            Console.WriteLine($"Hello, {FirstName} {LastName} {Age}");
            
            

        }
    }
}

using System;

namespace MoreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name!");
            string firstname = Console.ReadLine();
            Console.WriteLine("What is your last name!");
            string lastname = Console.ReadLine();

            Console.WriteLine($"Your initlas are {firstname[0]}. {lastname[0]}.");

        }
    }
}

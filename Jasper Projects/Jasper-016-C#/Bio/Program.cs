using System;

namespace Bio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opdracht 1.1
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your address?");
            string address = Console.ReadLine();
            Console.WriteLine("What is your postal code?");
            string postalCode = Console.ReadLine();
            Console.WriteLine("How old are you");
            string age = Console.ReadLine();

            Console.WriteLine($"{name} \n{address} \n{postalCode} \n{age}");

            // Opdracht 1.2
            Console.WriteLine($"********************* \n***{name}***\n*********************");
        }
    }
}

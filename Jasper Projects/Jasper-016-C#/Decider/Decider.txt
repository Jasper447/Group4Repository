using System;

namespace Decider
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your yes or no question?!");
            Console.ReadLine();
            Random rand = new Random();
            int roll = rand.Next(10);
            if (roll < 5)
            {
                Console.WriteLine("Most certainly yes");
            }
            else
            {
                Console.WriteLine("All signs point to no");
            }

        }
    }
}

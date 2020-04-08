using System;

namespace SunDay
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop over elk nummer van 1 tot 100
            for (int i = 1; i <= 100; i++)
            {
                // Kijk eerst of het getal deelbaar is door 3 EN 5
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("SunDay!");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Sun!");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Day!");
                }
                else
                {
                    continue;
                }
            }
        }
    }
}

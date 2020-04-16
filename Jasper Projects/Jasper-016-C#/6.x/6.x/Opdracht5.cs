using System;
using System.Collections.Generic;
using System.Text;

namespace _6.x
{
    class Opdracht5
    {
        public Opdracht5()
        {
            // Get user input
            Console.WriteLine("Enter a number, the console will print that many empty lines");
            int lines = Convert.ToInt32(Console.ReadLine());

            // Write empty lines according to the number

            for (int i = 0; i < lines; i++)
            {
                Console.WriteLine("");
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

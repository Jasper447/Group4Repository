using System;
using System.Collections.Generic;
using System.Text;

namespace _6.x
{
    class Opdracht6
    {
        public Opdracht6(int baseNumber, int exponent)
        {
            // Calculate the power of basenumber to the exponent

            int total = 1;
            for (int i = 0; i < exponent; i++)
            {
                total *= baseNumber;
            }

            // Print out the total and keep the program running

            Console.WriteLine(total);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

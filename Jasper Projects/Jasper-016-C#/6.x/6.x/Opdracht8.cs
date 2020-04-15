using System;
using System.Collections.Generic;
using System.Text;

namespace _6.x
{
    class Opdracht8
    {
        public Opdracht8(string sum)
        {
            // Convert every character to an int and add it to total

            int total = 0;
            for (int i = 0; i < sum.Length; i++)
            {
                total += Convert.ToInt32(sum.Substring(i, 1));
                
            }

            // Print out total and keep the program running

            Console.WriteLine(total);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

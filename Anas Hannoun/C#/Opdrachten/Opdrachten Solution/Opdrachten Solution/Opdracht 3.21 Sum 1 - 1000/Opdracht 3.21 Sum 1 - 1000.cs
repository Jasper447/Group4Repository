using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_1_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write($"Number that can be devided by 3 and/or 5 are :\n\n");

            for (int i = 1; i <= 1000; i++)
            {
                int rest3 = i % 3;
                int rest5 = i % 5;

                if (rest3 == 0 || rest5 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    total = total + i;
                    Console.Write(i + ", ");
                }

            }
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\nSum of these numbers = " + total);

            Console.ReadKey();
        }
    }
}

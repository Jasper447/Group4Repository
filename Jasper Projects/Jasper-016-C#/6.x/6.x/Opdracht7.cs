using System;
using System.Collections.Generic;
using System.Text;

namespace _6.x
{
    class Opdracht7
    {
        public Opdracht7()
        {
            // Get user input

            Console.WriteLine("Enter a number to determine the length of your Fibonacci sequence");
            int fibLength = Convert.ToInt32(Console.ReadLine());

            int temp = 0;
            int low = 0;
            int high = 1;

            // Print a Fibonacci sequence

            for (int i = 1; i < fibLength; i++)
            {
                if (temp == 0)
                {
                    Console.Write(temp + " ");
                    temp++;
                }
                else
                {
                    temp = high;
                    high = low + high;
                    low = temp;
                    Console.Write(low + " ");
                }
            }

            // Keep the program from exiting automatically

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

using System;
using System.Linq;

namespace _3._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 10 whole numbers");
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Find highest int
            int highValue = numbers.Max();

            //Find lower int
            int lowValue = numbers.Min();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == highValue)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (numbers[i] == lowValue)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.Write(numbers[i] + "\t");
                Console.ResetColor();
            }


        }



    }
}


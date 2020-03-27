using System;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter original amount");
            double originalAmount = Convert.ToDouble(Console.ReadLine());

            while (originalAmount <= 0)
            {
                Console.WriteLine("Please enter a positive number");
                originalAmount = Convert.ToDouble(Console.ReadLine());
            }

            while (originalAmount > 2)
            {
                originalAmount -= 2;
                count++;
            }
            while (originalAmount > 1 && originalAmount < 2)
            {
                originalAmount -= 1;
                count++;
            }
            while (originalAmount > 0.50 && originalAmount < 1)
            {
                originalAmount -= 0.50;
                count++;
            }
            while (originalAmount > 0.20 && originalAmount < 0.50)
            {
                originalAmount -= 0.20;
                count++;
            }
            while (originalAmount > 0.10 && originalAmount < 0.20)
            {
                originalAmount -= 0.10;
                count++;
            }
            while (originalAmount > 0.05 && originalAmount < 0.10)
            {
                originalAmount -= 0.05;
                count++;
            }
            while (originalAmount > 0.02 && originalAmount < 0.05)
            {
                originalAmount -= 0.02;
                count++;
            }
            while (originalAmount == 0.01)
            {
                originalAmount -= 0.01;
                count++;
            }

            Console.WriteLine($"Minimum number of coins is {count}");
        }
    }
}

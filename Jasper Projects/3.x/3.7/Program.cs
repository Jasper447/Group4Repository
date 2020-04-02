using System;

namespace _3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opdracht 3.7
            //Werp een dobbelsteen totdat het totaal groter is dan 1000
        
            Random rand = new Random();
            int roll = rand.Next(1, 7);
            int total = 0;

            while (total <= 1000)
            {
                total += roll;
                Console.WriteLine(total);
            }
        }

    }
}

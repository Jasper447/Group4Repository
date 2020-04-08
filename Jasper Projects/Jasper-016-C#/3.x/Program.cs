using System;

namespace _3.x
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opdracht 3.7
        
            Random rand = new Random();
            int roll = rand.Next(1, 7);
            int total = 0;
            while (total <= 1000)
            {
                total += roll;
                Console.WriteLine(total);
            }
            Console.WriteLine(total);
        }

    }
}

using System;

namespace _3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Opdracht 3.8
            Laat eerste 25 getallen van Fibonacci zien*/

            int sumA = 0;
            int sumB = 1;
            int sumC = 0;
            int counter = 0;

            //Print 0 en 1
            Console.WriteLine(sumA + "\n" + sumB);

            while (counter < 25)
            {
                sumC = sumA + sumB;
                Console.WriteLine(sumC);
                sumA = sumB;
                sumB = sumC;
                counter++;
                
            }

        }
    }
}

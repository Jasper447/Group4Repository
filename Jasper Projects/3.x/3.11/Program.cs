using System;

namespace _3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opdracht 3.11
            //Vraag om geldbedrag en rentepercentage
            Console.WriteLine("Please enter a moneyamount and an interestamount ");
            double moneyAmount = Convert.ToDouble(Console.ReadLine());
            double interestAmount = Convert.ToDouble(Console.ReadLine());

            //Bereken ieder jaar nieuw geldbedrag na rente
            for (int i = 0; i < 10; i++)
            {
                moneyAmount = (moneyAmount * interestAmount / 100) + moneyAmount;
                Console.WriteLine(moneyAmount);
            }

        }
    }
}

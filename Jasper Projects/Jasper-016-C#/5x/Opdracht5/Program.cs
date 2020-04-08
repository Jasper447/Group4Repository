using System;

namespace Opdracht4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of euro you want to convert");
            double euro = Convert.ToDouble(Console.ReadLine());

            double yen = euro * 118.05;
            double dollar = euro * 1.08;
            double britishPound = euro * 0.88;
            double ruble = euro * 82.62;
            double real = euro * 5.78;

            Console.WriteLine("Your amount in yen is " + yen);
            Console.WriteLine("Your amount in American dollar is " + dollar);
            Console.WriteLine("Your amount in British pounds is " + britishPound);
            Console.WriteLine("Your amount in  Russian ruble is " + ruble);
            Console.WriteLine("Your amount in Brazilian real is " + real);
        }
    }
}

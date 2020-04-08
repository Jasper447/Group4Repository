using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefenen
{
    class Program
    {
        private static void Main()
        {

            Console.WriteLine("Please Enter The Amount\n");
            double change = double.Parse(Console.ReadLine());

            double twoE = 2d;
            double oneE = 1d;
            double halfE = 0.50d;
            double twentyC = 0.20d;
            double tenC = 0.10d;
            double cent = 0.01d;

            double twoEuros = change / twoE;
            double oneEuro = ((change % twoEuros) / oneE);
            double halfEuro = ((change % twoEuros) % oneEuro) / halfE;
            double twentyCents = (((change % twoEuros) % oneEuro) % halfEuro) / twentyC;
            double tenCents = ((((change % twoEuros) % oneEuro) % halfEuro) % twentyCents) / tenC;
            double oneCent = (((((change % twoEuros) % oneEuro) % halfEuro) % twentyCents) % tenCents) / cent;

            int amount = 0;

            while (change >= 2d)
            {
                twoEuros++;
                change -= 2;
                amount++;
                change = Math.Round(change, 2, MidpointRounding.ToEven);

            }

            while (change >= 1d)
            {
                oneEuro++;
                change -= 1;
                amount++;
                change = Math.Round(change, 2, MidpointRounding.ToEven);

            }
            while (change >= 0.50d)
            {
                halfEuro++;
                change -= 0.50d;
                amount++;
                change = Math.Round(change, 2, MidpointRounding.ToEven);

            }
            while (change >= 0.20d)
            {
                twentyCents++;
                change -= 0.20d;
                amount++;
                change = Math.Round(change, 2, MidpointRounding.ToEven);

            }
            while (change >= 0.10d)
            {
                tenCents++;
                change -= 0.10d;
                amount++;
                change = Math.Round(change, 2, MidpointRounding.ToEven);

            }
            while (change >= 0.01d)
            {
                oneCent++;
                change -= 0.01d;
                amount++;
                change = Math.Round(change, 2, MidpointRounding.ToEven);

            }

            Console.WriteLine("\nYou Will Get " + amount + " Coins Back");

            Console.WriteLine("\nPress Any Key To End . . .");

            Console.ReadKey();
        }
    }
}


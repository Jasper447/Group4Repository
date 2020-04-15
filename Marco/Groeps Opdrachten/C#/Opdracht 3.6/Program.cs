using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double sum = 0;



            Console.WriteLine("5 worpen: ");
            
            for (int i = 0; i < 5; i++)
            {
                
                Console.WriteLine(random.Next(1, 7));
                //Som dobbelsteen
                sum += random.Next(1, 7);

            }

            Console.WriteLine();
            Console.WriteLine("Totaal " + sum);

            //Gemiddelde
            double gemiddelde = sum / 5;


            Console.WriteLine();
            Console.WriteLine("Gemiddelde: " + gemiddelde);






            Console.WriteLine();
            Console.WriteLine("Druk op Enter");

            Console.ReadKey();
        }
    }
}

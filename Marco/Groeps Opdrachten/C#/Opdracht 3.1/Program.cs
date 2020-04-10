using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //opdracht 3.1 - Laat getallen 1 tot 25 op scherm zien

            for(int i = 1; i <= 25; i++ )
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Druk op Enter");
            Console.ReadKey();
        }
    }
}

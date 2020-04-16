using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opdracht 3.4 - Laat van alle jaren vanaf 1900 zien of het wel of geen schrikkeljaar is.

            //int a = 1900;
            //int b = 2020;
            //int four = a / 4;


            //for (int i = a; i <= b; i++);


            //{
            //    if (four == 0)
            //    Console.WriteLine(four + "Schrikkeljaar");

            //}
            //    else 
            //{
            //    Console.WriteLine(i); 

            //}

            int a = 1900;
            int b = 2020;
            int wel = 0;
            


            for (int i = a; i <= b; i++)
                
            if (wel == (i/4)) 
                    //Ik snap niet hoe ik de berekening hier moet toepassen
                    //Laat staan de rest van de berekening(delen door 100 en dan door 400)
            {
                    
                Console.WriteLine(wel + " Schrikkeljaar");

            }
            
            else
            {

                Console.WriteLine(i + " Geen Schrikkeljaar");

            }
            



                Console.ReadKey();




            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Color Temperature Program\n\n");
            Console.WriteLine("Please Enter A Temperature In Celsius Between -30, +50!\n");
            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp >= -30 && temp <= 50)
            {
                while (temp >= -30 && temp < -20)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\t MAGENTA \t");
                    break;
                }
                while (temp >= -20 && temp < -10)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\t\t DARK GRAY \t\t");
                    break;
                }
                while (temp >= -10 && temp < 0)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\t\t\t CYAN \t\t\t");
                    break;
                }
                while (temp >= 0 && temp < 10)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\t\t\t\t BLUE \t\t\t\t");
                    break;
                }
                while (temp >= 10 && temp < 20)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\t\t\t\t\t YELLOW \t\t\t\t\t");
                    break;
                }
                while (temp >= 20 && temp < 30)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t\t\t RED \t\t\t\t\t\t");
                    break;
                }
                while (temp >= 30 && temp <= 50)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\t\t\t\t\t\t\t DARK RED \t\t\t\t\t\t\t");
                    break;
                }
            }
            else
            {
                Console.WriteLine("\nInvalid Input");

            }



            Console.ReadKey();
        }
    }
}

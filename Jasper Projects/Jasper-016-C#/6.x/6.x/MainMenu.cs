/*
 * This is the main menu for all the exercises of chapter  3 (Iterations)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.x
{

    class MainMenu
    {
        static void Main(string[] args)
        {
            int choice = 0;

            // Show the main menu until the users stops with menu option 99
            while (choice != 99)
            {
                Console.Clear();
                Console.Write("Geef het nummer van de opdracht die je uit wilt voeren (5 - 8, 99 = STOP): ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 5:
                        new Opdracht5();
                        break;
                    case 6:
                        Console.WriteLine("Enter a base number and an exponent");
                        int baseNumber = Convert.ToInt32(Console.ReadLine());
                        int exponent = Convert.ToInt32(Console.ReadLine());
                        new Opdracht6(baseNumber, exponent);
                        break;
                    case 7:
                        new Opdracht7();
                        break;
                    case 8:
                        Console.WriteLine("Enter a number to calculate the sum of");
                        string sum = Console.ReadLine();
                        new Opdracht8(sum);
                        break;
                    case 99:
                        Console.WriteLine("Bye bye ...");
                        System.Threading.Thread.Sleep(1000);
                        return;
                    default:
                        // Show for 1 second a message to make the user aware of an invalid choise and the show then manu again
                        Console.WriteLine("Ongeldige keuze ...");
                        System.Threading.Thread.Sleep(1000);
                        break;
                }
            }
        }
    }
}

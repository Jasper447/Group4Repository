using System;

namespace Project_Decider
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What Is Your Yes Or No Question?\n\n");
            string choice = Console.ReadLine();

            int roll = (new Random()).Next(10);

            switch (roll)
            {
                case 0:
                    Console.BackgroundColor = ConsoleColor.Red;

                    Console.WriteLine("\n\nOh, That's a certain NO!");
                    break;
                case 1:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\nAbsolutely!");
                    break;

                case 3:
                    Console.BackgroundColor = ConsoleColor.Red;

                    Console.WriteLine("\n\nOh, That's a certain NO!");
                    break;
                case 4:
                    Console.BackgroundColor = ConsoleColor.Green;

                    Console.WriteLine("\n\nOf course, BIG FAT YES!!");
                    break;
                case 5:
                    Console.BackgroundColor = ConsoleColor.Green;

                    Console.WriteLine("\n\nMost certainly yes!");
                    break;
                case 6:
                    Console.BackgroundColor = ConsoleColor.Red;

                    Console.WriteLine("\n\nNO!!!");
                    break;
                case 7:
                    Console.BackgroundColor = ConsoleColor.Green;

                    Console.WriteLine("\n\nPositive!");
                    break;
                case 8:
                    Console.BackgroundColor = ConsoleColor.Red;

                    Console.WriteLine("\n\nNegative!");
                    break;
                case 9:
                    Console.BackgroundColor = ConsoleColor.Green;

                    Console.WriteLine("\n\nOUI!");
                    break;
                case 10:
                    Console.BackgroundColor = ConsoleColor.Red;

                    Console.WriteLine("\n\nNON!");
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("\n\nI'm Not Sure About That!");
                    break;
            }

            //if (roll <= 0)
            //{
            //    Console.WriteLine("Oh, That's a certain NO!");

            //}
            //else if (roll <= 2)
            //{
            //    Console.WriteLine("Absolutely!");
            //}
            //else if (roll > 2 && roll <= 5)
            //{
            //    Console.WriteLine("That's a NO NO and you know it!");
            //}
            //else if (roll > 5 && roll <= 7)
            //{
            //    Console.WriteLine("Of course, BIG FAT YES!");
            //}
            //else if (roll > 7 && roll <= 9)
            //{
            //    Console.WriteLine("I wish it was a yes but unfortunately it's a no");
            //}
            //else if (roll == 10)
            //{
            //    Console.WriteLine("JACKBOT");
            //}

            Console.ReadKey();

        }

    }
}

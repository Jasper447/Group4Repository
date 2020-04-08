using System;
using System.Threading;

namespace MENU
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter The First Number = ");
            decimal first = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Please Enter The Second Number = ");
            decimal second = Convert.ToDecimal(Console.ReadLine());

            decimal plus = first + second;
            decimal minus = first - second;
            decimal times = first * second;
            decimal divis = first / second;
            decimal modul = first % second;

            ConsoleKey choice = ConsoleKey.D0;


            while (choice != ConsoleKey.D9 || choice != ConsoleKey.NumPad9)
            {
                Console.Clear();
                Console.WriteLine("Please Enter the number of the operation you want to be excuted!\n");
                Console.WriteLine($" 1.PLUS = {first} + {second} \n 2.MINUS = {first} - {second} \n 3.MULTIPLICATION = {first} * {second} \n 4.DIVISION = {first} / {second} \n 5.MODULUS = {first} % {second}\nOr Press 9 to exit the program!");
                choice = Console.ReadKey().Key;
                Console.WriteLine();
                if (choice == ConsoleKey.D9 || choice == ConsoleKey.NumPad9)
                {
                    Console.Write("Have a great day!\nProgram will exit now");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(". ");
                        Thread.Sleep(1000);
                    }
                    break;
                }
                switch (choice)
                {
                    case ConsoleKey.NumPad1:
                        Console.WriteLine($"\n{first} + {second} = {plus}");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D1:
                        Console.WriteLine($"\n{first} + {second} = {plus}");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.NumPad2:
                        Console.WriteLine($"\n{first} - {second} = {minus}");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D2:
                        Console.WriteLine($"\n{first} - {second} = {minus}");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.NumPad3:
                        Console.WriteLine($"\n{first} x {second} = {times}");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine($"\n{first} x {second} = {times}");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.NumPad4:
                        if (second == 0)
                        {
                            Console.WriteLine("You can't divide on zero!");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"\n{first} / {second} = {divis}");
                            Console.ReadKey();
                            break;
                        }

                    case ConsoleKey.D4:
                        if (second == 0)
                        {
                            Console.WriteLine("You can't divide on zero!");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"\n{first} / {second} = {divis}");
                            Console.ReadKey();
                            break;
                        }
                    case ConsoleKey.NumPad5:
                        Console.WriteLine($"\n{first} % {second} = {modul}");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D5:
                        Console.WriteLine($"\n{first} % {second} = {modul}");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("\nInvalid choice!");
                        Console.ReadKey();
                        break;

                }
            }


        }
    }
}

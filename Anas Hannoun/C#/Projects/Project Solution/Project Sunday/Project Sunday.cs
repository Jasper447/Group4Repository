﻿using System;
namespace Sunday
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
                {
                    Console.WriteLine(i);
                }
                else if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
                {
                    Console.WriteLine("SunDayToday!");
                }
                else if (i % 3 == 0 && i % 5 == 0 && i % 7 != 0)
                {
                    Console.WriteLine("SunDay!");
                }
                else if (i % 3 == 0 && i % 7 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("SunToday!");
                }
                else if (i % 5 == 0 && i % 7 == 0 && i % 3 != 0)
                {
                    Console.WriteLine("DayToday");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Sun!");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Day!");
                }
                else if (i % 7 == 0)
                {
                    Console.WriteLine("Today!");
                }

            }
            Console.ReadKey();
        }
    }
}

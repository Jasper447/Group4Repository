﻿using System;

namespace Oefenen
{
    class Program
    {
        private static void Main()
        {

            Console.WriteLine("Hi there! What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"How old are you , { name} ? <Please, Enter a positive digit>");
            string age = Console.ReadLine();

            Console.WriteLine($"And what is your favourite sport , {name} ?");
            string sport = Console.ReadLine();

            Console.WriteLine($"{ name} is {age } and loves { sport} !, That's Amazing!");

            Console.WriteLine("");

            Console.WriteLine("Press Enter to end.");


            Console.ReadLine();



            Console.ReadKey();

        }
    }
}

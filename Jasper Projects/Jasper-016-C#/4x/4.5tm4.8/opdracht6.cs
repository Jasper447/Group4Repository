﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _4._5tm4._8
{
    class opdracht6
    {
        static void Main(string[] args)
        {
            //Lees gegevens in

            Console.WriteLine("How many working hours?");
            int workhours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How old is the machine?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many malfunctions per week are there?");
            int malfunctions = Convert.ToInt32(Console.ReadLine());

            //Kijk of draaibank aan vervanging toe is

            if (workhours >= 10000 || age >= 7 || malfunctions > 25)
            {
                Console.WriteLine("Your lathe needs replacement");
            }
        }
    }
}

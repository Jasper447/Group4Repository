﻿using System.Text.RegularExpressions;
using System;

namespace Email_Validation
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Please Enter Your Email Adress");
            string emailAdress = Console.ReadLine();

            string emailPattern = @"^\w+@[a-zA-Z_0-9]+?\.[a-zA-Z]{2,3}$";
            Match match = Regex.Match(emailAdress, emailPattern);
            if (match.Success)
            {
                Console.WriteLine("Thank You!");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

            Console.WriteLine("\nPress Any Key To End . . .");

            Console.ReadKey();

        }
    }
}
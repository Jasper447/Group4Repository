﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibboncci
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnumber = 0;
            int secondnumber = 1;
            int result = 0;
            int fibona = 0;

            for (int i = 2; fibona < 4000000; i++)
            {
                fibona = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = fibona;

                int fibonaEven = fibona % 2;

                if (fibonaEven == 0)
                {
                    result = result + fibona;
                    Console.WriteLine($"{ fibona}  {result}");

                }
            }
            Console.WriteLine("\n\nThe SUM of Fibonacci even number under 4 million =" +result);

            Console.WriteLine("\n\nPress Any Key To End...");

            Console.ReadKey();

        }
    }
}
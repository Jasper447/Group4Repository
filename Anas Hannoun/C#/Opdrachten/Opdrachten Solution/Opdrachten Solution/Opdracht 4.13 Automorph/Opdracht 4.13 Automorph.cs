﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automorph
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());

            int square = input * input;
            int inputRest = input % 10;
            int squareRest = square % 10;


            while (input > 0)
            {
                if (inputRest == squareRest)
                {
                    Console.WriteLine($"{input} is an Automorph number");
                    break;

                }
                else if (input % 10 != squareRest)
                {
                    Console.WriteLine($"{input} is NOT an Automorph number");

                    break;

                }

            }
            Console.ReadKey();


        }

    }
}

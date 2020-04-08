using System;

namespace Opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for camper dimensions and calculate area

            Console.WriteLine("What is the length of your camper?");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the width of your camper?");
            double width = Convert.ToDouble(Console.ReadLine());
            double area = length * width;

            // Calculate cost per year

            double cost = area * 1.5;
            double costTwoYears = (cost * 2) - ((cost * 2)* 0.05);
            double costThreeYears = (cost * 3) - ((cost * 3) * 0.10);

            // Display cost to user

            Console.WriteLine("Your cost after 1 year is " + Math.Round(cost, 2));
            Console.WriteLine("Your cost after 2 years is " + Math.Round(costTwoYears, 2));
            Console.WriteLine("Your cost after 3 years is " + Math.Round(costThreeYears, 2));
        }
    }
}

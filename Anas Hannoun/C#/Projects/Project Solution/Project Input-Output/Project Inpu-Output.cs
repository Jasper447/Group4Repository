using System;

namespace Oefenen
{
    class Program
    {
        private static void Main()
        {

            Console.WriteLine("Hi, Please Enter Your Name");
            string name = Console.ReadLine();

            Console.WriteLine($"Okay, { name} Let's Calculate Your BMI.\n Enter Your Height in Centimeters");
            double height = Convert.ToDouble(Console.ReadLine());
            double heightInM = height / 100.0;

            Console.WriteLine("And Enter Your Weight in Kg");
            double weight = Convert.ToDouble(Console.ReadLine());

            double calWeight = Math.Round(weight, 1);

            double bmi = calWeight / (heightInM * heightInM);

            double bmiCal = Math.Round(bmi, 1);

            Console.WriteLine($"Okay, { name} Your BMI Is !");


            Console.WriteLine(bmiCal);

            Console.WriteLine("Press Enter to end.");


            Console.ReadLine();



            Console.ReadKey();

        }
    }
}

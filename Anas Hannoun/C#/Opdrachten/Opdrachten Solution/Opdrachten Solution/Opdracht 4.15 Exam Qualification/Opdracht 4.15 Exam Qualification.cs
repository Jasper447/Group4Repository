using System;
using System.Threading;

namespace Exam_qualification
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the qualification test!\n\nPlease follow the instructions!\n");
            Thread.Sleep(1000);

            Console.WriteLine("\nPlease Enter your Maths score!\n");
            double math = Convert.ToDouble(Console.ReadLine());
            Thread.Sleep(1000);

            Console.WriteLine("\nPlease Enter your Physics score!\n");
            double physics = Convert.ToDouble(Console.ReadLine());
            Thread.Sleep(1000);

            Console.WriteLine("\nPlease Enter your Chemistry score!\n");
            double chemistry = Convert.ToDouble(Console.ReadLine());

            double total = math + physics + chemistry;

            if (math > 100 || math <= 0 || physics > 100 || physics <= 0 || chemistry > 100 || chemistry <= 0)
            {
                Console.WriteLine("Invalid input, scores must be between 0 and 100");
            }

            else if (math < 40 || physics < 40 || chemistry < 40 || total < 180)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry, You don't qualify this time!\nGood luck next time");
            }

            else
            {
                while (math > 40 && math <= 100 && physics > 40 && physics <= 100 && chemistry > 40 && chemistry <= 100)
                {
                    if (total >= 180 || (math >= 60 && (physics >= 60 || chemistry >= 60)))
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("Congratulations, You are qualified.");
                    }
                    break;
                }
            }
            Console.WriteLine("Press any key to exit the program. . .");
            Console.ReadKey();
        }
    }
}

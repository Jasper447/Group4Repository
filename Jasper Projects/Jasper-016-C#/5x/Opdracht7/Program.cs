using System;

namespace Opdracht6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your student number?");
            int studentNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            double nedAverage = 0;
            double engAverage = 0;
            double wisAverage = 0;
            double prgAverage = 0;
            double dbdAverage = 0;
            double algAverage = 0;


            string[] vakken = new string[] { "NED", "ENG", "WIS", "PRG", "DBD", "ALG" };
            for (int i = 0; i < vakken.Length; i++)
            {
                Console.WriteLine("What is your first grade for " + vakken[i]);
                double temp1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is your second grade for " + vakken[i]);
                double temp2 = Convert.ToDouble(Console.ReadLine());

                switch (vakken[i])
                {
                    case "NED":
                        nedAverage = (temp1 + temp2)/3;
                        break;
                    case "ENG":
                        engAverage = (temp1 + temp2)/3;
                        break;
                    case "WIS":
                        wisAverage = (temp1 + temp2)/3;
                        break;
                    case "PRG":
                        prgAverage = (temp1 + (temp2 * 2))/3;
                        break;
                    case "DBD":
                        dbdAverage = (temp1 + (temp2 * 2))/3;
                        break;
                    case "ALG":
                        algAverage = (temp1 + (temp2 * 2))/3;
                        break;
                }
            }
            Console.WriteLine(studentNumber + " " + firstName + " " + lastName);
            Console.WriteLine("NED: " + Math.Round(nedAverage, 1));
            Console.WriteLine("ENG: " + Math.Round(engAverage, 1));
            Console.WriteLine("WIS: " + Math.Round(wisAverage, 1));
            Console.WriteLine("PROG: " + Math.Round(prgAverage, 1));
            Console.WriteLine("DBD: " + Math.Round(dbdAverage, 1));
            Console.WriteLine("ALG: " + Math.Round(algAverage, 1));
        }
    }
}

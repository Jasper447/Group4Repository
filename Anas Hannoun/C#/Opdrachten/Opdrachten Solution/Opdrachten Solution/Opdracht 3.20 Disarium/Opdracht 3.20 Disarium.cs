using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._20_Disarium
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter A Number Between Ten And Million.");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int result))
            {
                int inputCal = Convert.ToInt32(input);
                if (inputCal >= 10 && inputCal <= 1000000)
                {
                    for (int i = 1; i <= inputCal; i++)
                    {
                        double disarium = 0;
                        string length = Convert.ToString(i);

                        for (int j = 0; j < length.Length; j++)
                        {
                            disarium += Math.Pow(Convert.ToDouble(length[j].ToString()), Convert.ToDouble(j) + 1);
                        }

                        int d = Convert.ToInt32(disarium);

                        if (d == i)
                        {
                            Console.WriteLine(i + " is a disarium number!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("The Number Should Be Between Ten And A Million");
                }
            }


            else
            {
                Console.WriteLine("Invalid Input!");
            }
            Console.WriteLine("Press Any Key To End...");
            Console.ReadKey();
        }


    }
}

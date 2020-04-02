using System;

namespace _3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opdracht 3.10
            //Vraag user om input tussen 10 en 100
            Console.WriteLine("Please enter a number between 10 and 100");

            string input = Console.ReadLine();
            int convertedInput = Int32.Parse(input);
            int counter = 0;
            int sum = 0;

            if (convertedInput < 10 || convertedInput > 100)
            {
                Console.WriteLine("Wrong input, please restart the program");
            }

            //Loop over alle getallen en display ze als ze oneven zijn
            while (counter <= convertedInput)
            {
                if (counter % 2 != 0)
                {
                    Console.WriteLine(counter);
                    sum += counter;
                }
                counter++;
            }
            Console.WriteLine(sum);
        }
    }
}

using System;

namespace _3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opdracht 3.9
            //Vraag user om input tussen 10 en 20
            Console.WriteLine("Please enter a number between 10 and 20");

            string input = Console.ReadLine();
            int convertedInput = Int32.Parse(input);
            int counter = 0;

            if (convertedInput < 10 || convertedInput > 20)
            {
                Console.WriteLine("Wrong input, please restart the program");
            }

            while (counter <= convertedInput)
            {
                Console.WriteLine(counter);
                counter++;
            }
            Console.WriteLine(convertedInput * convertedInput);
        }
    }
}

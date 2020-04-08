using System;

namespace opdracht7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What time is it?");
            int timeOfDay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What day is it?");
            string day = Console.ReadLine().ToLower();
            string weekend = "";
            string greeting = "";

            //Check if day is weekend or not
            if (day == "saturday" || day == "sunday")
            {
                weekend = "weekend";
            }
            else
            {
                weekend = "een werkdag";
            }


            if (timeOfDay >= 18)
            {
                greeting = "Goedeavond";
            }
            else if (timeOfDay >= 12)
            {
                greeting = "Goedemiddag";
            }
            else
            {
                greeting = "Goedemorgen";
            }
            Console.WriteLine(greeting + " het is vandaag  " + weekend);
        }
    }
}

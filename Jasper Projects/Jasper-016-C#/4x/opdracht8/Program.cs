using System;
using System.Globalization;

namespace opdracht8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get user input

            Console.WriteLine("Hello! Please pick a language by typing the number and hitting enter");
            Console.WriteLine("1 = Nederlands");
            Console.WriteLine("2 = Duits");
            Console.WriteLine("3 = Engels");
            Console.WriteLine("4 = Frans");
            Console.WriteLine("5 = Spaans");
            Console.WriteLine("6 = Italiaans");
            int language = Convert.ToInt32(Console.ReadLine());

           
            string country = "";

            switch (language)
            {
                case 1:
                    country = "nl";
                    break;
                case 2:
                    country = "de";
                    break;
                case 3:
                    country = "en";
                    break;
                case 4:
                    country = "fr";
                    break;
                case 5:
                    country = "es";
                    break;
                case 6:
                    country = "it";
                    break;
                default:
                    Console.WriteLine("You picked an invalid number. please restart the program");
                    break;
            }

            // Get current month
            string month = DateTime.Now.ToString("MMMMM", new CultureInfo(country));


            switch (language)
            {
                case 1:
                    Console.WriteLine("De huidige maand is " + month);
                    break;
                case 2:
                    Console.WriteLine("Der aktuelle Monat ist " + month);
                    break;
                case 3:
                    Console.WriteLine("The current month is " + month);
                    break;
                case 4:
                    Console.WriteLine("Le mois en cours est " + month);
                    break;
                case 5:
                    Console.WriteLine("El mes actual es " + month);
                    break;
                case 6:
                    Console.WriteLine("Il mese corrente è " + month);
                    break;
                default:
                    Console.WriteLine("You picked an invalid number. please restart the program");
                    break;
            }


        }
        
    }
}

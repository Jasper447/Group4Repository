using System;

namespace TripPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting();
            Budget();
            TimeDifference();
            Area();
            Haversine();
        }

        // Greet the user and ask him about his trip
        private static void Greeting()
        {
            Console.WriteLine("Welcome to Trip Planner!");
            Console.Write("What is your full name? ");
            string username = Console.ReadLine();

            Console.WriteLine("Hello, " + username);
            Console.Write("What is your travel destination? ");
            string destination = Console.ReadLine();
            Console.WriteLine(destination + " sounds lovely this time of year!");
        }

        // Convert the users budget to a foreign countries currency
        public static void Budget()
        {
            Console.Write("How many days is your trip? ");
            int days = Convert.ToInt32(Console.ReadLine());
            int hours = 14 * 24;
            int minutes = hours * 60;

            Console.Write("How much are you going to spend, in Euro, on the trip? ");
            double budget = Convert.ToDouble(Console.ReadLine());
            double dailyBudget = budget / days;
            string formattedDailyBudget = String.Format("{0:n2}", dailyBudget);

            Console.Write("What is the three letter currency symbol for your destination? ");
            string currency = Console.ReadLine();

            Console.Write("How many " + currency + " are there in 1 Euro? ");
            double exchangeRate = Convert.ToDouble(Console.ReadLine());
            double convertedBudget = budget * exchangeRate;
            double convertedDailyBudget = convertedBudget / days;
            string formatConvertedDailyBudget = String.Format("{0:n2}", convertedDailyBudget);

            Console.WriteLine("If you are traveling for " + days + " days that is the same as " + hours + " hours or " + minutes + " minutes");
            Console.WriteLine("if you are going to spend " + budget + " that means daily you can spend up to " + formattedDailyBudget + " in Euro");
            Console.WriteLine("Your total budget in " + currency + " is " + convertedBudget + " which per day is " + formatConvertedDailyBudget);
        }

        // Calculate the time difference between two countries
        public static void TimeDifference()
        {
            Console.Write("What is the time difference in hours, between your home and your destination? ");
            int timeDifference = Convert.ToInt32(Console.ReadLine());
            int midnight = (24 + timeDifference)%24;
            int noon = (12 + timeDifference)%24;
            Console.WriteLine("That means that when it is midnight at home it will be " + midnight + ":00 in your travel destination and when it is noon at home it will be " + noon + ":00");
        }

        // Calculate the area of a country in square kilometers
        public static void Area()
        {
            Console.Write("What is the area of your destination country in square miles? ");
            double miles = Convert.ToInt32(Console.ReadLine());
            double kilometers = miles / 0.38610;
            string formattedKilometer = String.Format("{0:n0}", kilometers);
            Console.WriteLine("In kilometers that is " + formattedKilometer + " square kilometers");
        }

        // Calculate the distance between the two countries using latitude and longitude
        public static void Haversine()
        {
            Console.Write("What is the latitude of your current position? ");
            double lat1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the longitude of your current position? ");
            double lon1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the latitude of your destination? ");
            double lat2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the longitude of your destination? ");
            double lon2 = Convert.ToDouble(Console.ReadLine());

            const double r = 6371; // Radius of the earth

            var lat = Math.Sin((lat2 - lat1) / 2);
            var lon = Math.Sin((lon2 - lon1) / 2);
            var q = lat * lat + Math.Cos(lat1) * Math.Cos(lat2) * lon * lon;
            var distance = 2 * r * Math.Asin(Math.Sqrt(q));
            string formattedDistance = String.Format("{0:n0}", distance);

            Console.WriteLine("The distance is " + formattedDistance + " kilometers");
        }
    }
}

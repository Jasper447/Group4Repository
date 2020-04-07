using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bio
{
	class Program
	{
		static void Main(string[] args)
		{
			string fullName = "Leroy Visser";
			string adres = "Zunabrink 37";
			string zipcode = "7544 DM";
			string city = "Enschede";
			int age = 30;

			Console.WriteLine($"Naam: " + fullName );
			Console.WriteLine("Adres: " + adres);
			Console.WriteLine("Postcode: " + zipcode + " " + city);
			Console.WriteLine("Leeftijd: " + age);
		}
	}
}
//devops test
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2._5
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Wat is uw naam?");
			string fullName = Console.ReadLine();

			Console.WriteLine($"Hallo {fullName} , wat is de prijs van uw auto?");
			int basePrice = Convert.ToInt32(Console.ReadLine());

			int carPaint = (basePrice * 5) / 100;
			int carLeather = (basePrice * 5) / 100;
			int carAutomatic = basePrice + 1000;

			int basePriceTaxes = (basePrice + (basePrice * 21) / 100);
			int pricePaint = (basePrice + ((basePrice + carPaint) * 21) / 100);
			int priceLeather = (basePrice + ((basePrice + carLeather) * 21) / 100);
			int priceAutomatic = (basePrice + ((basePrice + carAutomatic) * 21) / 100);
			

			Console.WriteLine("Welke opties wilt U bij uw auto? \n1. Metallic lak \n2. Leren bekleding \n3. Automaat ");
			int autoOpties = Convert.ToInt32(Console.ReadLine());

			if (autoOpties == 1)
			{
				Console.WriteLine($"De totaalprijs van uw auto met metallic lak is {pricePaint}.");
			}
			else if (autoOpties == 2)
			{
				Console.WriteLine($"De totaalprijs van uw auto met leren bekleding is {priceLeather}.");
			}
			else if (autoOpties == 3)
			{
				Console.WriteLine($"De totaalprijs van uw auto met automaat is {priceAutomatic}.");
			}
			else
			{
				Console.WriteLine($"U heeft heeft geen extra opties gekozen voor uw nieuwe auto, de totaalprijs is {basePriceTaxes}.");
			}

		}
	}
}

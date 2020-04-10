using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Voer uw tekst in.");
			string tekst = Console.ReadLine().ToLower();

			int totaalKlinkers = 0;
			int totaalNummers = 0;
			int totaalSpch = 0;
			int totaalMedeKlinkers = 0;
			var klinkers = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
			var nummers = new HashSet<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
			var spch = new HashSet<char> { '!', '?', ':', '.', ',' };
			var medeKlinkers = new HashSet<char> { 'q', 'w', 'r', 't', 'y', 'p', 's', 'd', 'f', 'g', 'h', 'k', 'j', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };



			for (int i = 0; i < tekst.Length; i++)
			{
				if (klinkers.Contains(tekst[i]))
				{
					totaalKlinkers++;
				}
			}

			Console.WriteLine("Het totale nummer klinkers in de tekst is: {0}", totaalKlinkers);
			for (int i = 0; i < tekst.Length; i++)
			{
				if (nummers.Contains(tekst[i]))
				{
					totaalNummers++;
				}
			}

			Console.WriteLine("Het totale aantal nummers in de tekst is: {0}", totaalNummers);
			for (int i = 0; i < tekst.Length; i++)
			{
				if (spch.Contains(tekst[i]))
				{
					totaalSpch++;
				}
			}
			Console.WriteLine("Het totale aantal speciale characters in de tekst is: {0}", totaalSpch);

			for (int i = 0; i < tekst.Length; i++)
			{
				if (medeKlinkers.Contains(tekst[i]))
				{
					totaalMedeKlinkers++;
				}
			}
			Console.WriteLine("Het totale aantal medeklinkers in de tekst is: {0}", totaalMedeKlinkers);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3._14
{
	class Program
	{
		static void Main(string[] args)
		{
			int invoer;
			int waarde;
			int[] binaireConversie = new int[10];
			Console.WriteLine("Geef ons een decimaal getal en wij maken er een binaire en hexadecimale waarde van!");
			invoer = int.Parse(Console.ReadLine());

			for (waarde = 0; invoer > 0; waarde++)
			{
				binaireConversie[waarde] = invoer % 2;
				invoer = invoer / 2;
			}
			Console.Write("De decimale waarde van het gegeven getal is: ");
			for (waarde = waarde - 1; waarde >= 0; waarde--)
			{
				Console.Write(binaireConversie[waarde]);
			}

		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
	class Program
	{
		static void Main(string[] args)
		{
			int bedrag = (int)(23.89  * 100);
			int aantalMunten = 0;

			int euro2 = bedrag / 200;
			aantalMunten += euro2;
			int restant = bedrag % 200;

			int euro1 = restant / 100;
			aantalMunten += euro1;
			int restant1 = restant % 100;

			int euro050 = restant1 / 50;
			aantalMunten += euro050;
			int restant2 = restant1 % 50;

			int euro010 = restant2 / 10;
			aantalMunten += euro010;
			int restant3 = restant2 % 10;

			int euro0050 = restant3 / 5;
			aantalMunten += euro0050;
			int restant4 = restant3 % 5;

			int euro0020 = restant4 / 2;
			aantalMunten += euro0020;
			int restant5 = restant4 % 2;

			int euro0010 = restant5 / 1;
			aantalMunten += euro0010;

			Console.WriteLine("Je krijgt " + aantalMunten + " " + "munten terug.");



		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hondenjaren
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Wil je je leeftijd in hondenjaren weten? Type dan nu je leeftijd in.");
				int dogAge = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Je leeftijd in hondenjaren is: " + dogAge / 7);
			Console.WriteLine(); 
			Console.WriteLine("Wil je ook graag weten hoe oud je hond in mensenjaren is? Type dan nu je hond zijn/haar leeftijd in.");
				int humanAge = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Je hond zijn/haar leeftijd in mensenjaren is: " + humanAge * 7);
		}
	}
}

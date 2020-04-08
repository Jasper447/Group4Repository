using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your name!");
            DateTime old = DateTime.Now;
            Console.ReadLine();
            Console.WriteLine("Please enter your age!");
            Console.ReadLine();
            DateTime now = DateTime.Now;
            TimeSpan difference = now.Subtract(old);
            Console.WriteLine($"That took {difference.TotalSeconds} seconds!");
            Console.ReadKey();
        }
    }
}

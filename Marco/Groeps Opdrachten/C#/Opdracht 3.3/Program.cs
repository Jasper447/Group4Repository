using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3._3
{
    class Program
    {
        static void Main(string[] args)
        {

        //Opdracht 3.3 -Laat de gebruiker 2 getallen invoeren
        //             -Laat vervolgens alle tussenliggende getallen zien 

            


            Console.WriteLine("Voer een getal in: ");
            string eerste = Console.ReadLine();
            
            Console.WriteLine("Voer een tweede getal in: ");
            string tweede = Console.ReadLine();




            //for (int i = n1; i <= n2; i++)

            int a, b;
            a = Convert.ToInt32(eerste);
            b = Convert.ToInt32(tweede);

            for (int o = a; o <b; o++)
            {

                Console.WriteLine(o);
                //niet tevreden met uitkomst, geeft eerste opgegeven nummer ook weer.
            }

                



                //for (string x = eerste; x <=)  ??????

                //listBox1.Items.Clear();       <<-- hulpbron internet
                //int n1, n2;
                //n1 = Convert.ToInt32(txtNum1.Text);
                //n2 = Convert.ToInt32(txtNum2.Text);

            






                Console.WriteLine("Druk op 'Enter'");
            Console.ReadKey();
        }
    }
}

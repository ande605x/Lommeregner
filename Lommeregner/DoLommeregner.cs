using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner
{
    class DoLommeregner
    {

        public void MyCode()
        {

            Calculate calcu = new Calculate();

            Console.WriteLine("Velkommen til Lommeregner");
            Console.WriteLine("=========================");
            Console.WriteLine();


            string sentinel = "y";

            while (sentinel != "n")
            {
                Console.WriteLine("Indtast tal 1: ");
                string input1 = Console.ReadLine();
                int tal1 = Int32.Parse(input1);

                Console.WriteLine("Indtast en matematisk oprator: ");
                string input2 = Console.ReadLine();

                Console.WriteLine("Indtast tal 2: ");
                string input3 = Console.ReadLine();
                int tal2 = Int32.Parse(input3);

                Console.WriteLine($"Resultat: " + calcu.mathcalc(tal1, tal2, input2));

                Console.WriteLine("Forsæt [y/n]: ");
                sentinel = Console.ReadLine();
                Console.WriteLine();

            }

          


            //int tal2 = Int32.Parse(input2);
            //bool erOperator = Int32.TryParse(input1, tal2);

        }
    }
}

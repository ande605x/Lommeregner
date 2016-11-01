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
            UserInput useri = new UserInput();

            Console.WriteLine("Velkommen til Lommeregner");
            Console.WriteLine("=========================");
            Console.WriteLine();


            string sentinel = "y";

            while (sentinel != "n")
            {
                Console.WriteLine("Indtast tal 1: ");
                double tal1 =  useri.ReadNumber();
                

                Console.WriteLine("Indtast en matematisk oprator[+ - * / %]: ");
                string input2 = useri.ReadOperator();

                Console.WriteLine("Indtast tal 2: ");
                double tal2 = useri.ReadNumber();

                Console.WriteLine($"Resultat: " + calcu.mathcalc(tal1, tal2, input2));

                Console.WriteLine("Forsæt [y/n]: ");
                sentinel = Console.ReadLine();
                Console.WriteLine();

            }

          


            //double tal2 = double32.Parse(input2);
            //bool erOperator = double32.TryParse(input1, tal2);

        }
    }
}

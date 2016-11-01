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

            Console.WriteLine("Velkommen til Lommeregner");
            Console.WriteLine("=========================");
            Console.WriteLine();


            Console.WriteLine("Indtast tal 1: ");
            string input1 = Console.ReadLine();
            int tal1 = Int32.Parse(input1);

            Console.WriteLine("Indtast en matematisk oprator: ");
            string input2 = Console.ReadLine();

            Console.WriteLine("Indtast tal 2: ");
            string input3 = Console.ReadLine();
            int tal2 = Int32.Parse(input2);


            //int tal2 = Int32.Parse(input2);
            //bool erOperator = Int32.TryParse(input1, tal2);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner
{
    class UserInput
    {
        public int ReadNumber()
        {
           
            int tal1 = 0;
            string input1 = Console.ReadLine();

            while (!(Int32.TryParse(input1 , out tal1)))
            {
                Console.WriteLine("Indtast et TAL: ");
                input1 = Console.ReadLine();
                //tal1 = Int32.Parse(input1);   
            }
            
           return tal1;



        }

        public string ReadOperator()
        {
            string input = Console.ReadLine();

            while (!(input == "+" || input == "-" || input == "/" || input == "*"))
            {
                Console.WriteLine("Indtast en matematisk operator af [+ - * / %]");
                input = Console.ReadLine();
            }

            return input;



        }
    }
}

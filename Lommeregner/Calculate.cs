using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner
{
    class Calculate
    {
        public double mathcalc(double tal1, double tal2, string mathsymbol)
        {
            if (mathsymbol == "+")
            {
                return tal1 + tal2;
            }

            else if (mathsymbol == "*")
            {
                return tal1 * tal2;
            }

            else if (mathsymbol == "/")
            {
                if (tal2 == 0)
                {
                    Console.WriteLine("kan ikke dividere med 0! ");
                    return 0;
                }
                else
                    return tal1 / tal2;
            }
            else if (mathsymbol == "%")
            {
                return tal1 % tal2;
            }

            else if (mathsymbol == "-")
            {
                return tal1 - tal2;
            }

            else
                return 0;

        }
    }
}

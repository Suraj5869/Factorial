using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialOfNumber.Models
{
    internal class RecursiveFactorial
    {
        public static double CalculateFactorial(int number)
        {
            if (number == 0)
            { return 1; }
            return number * CalculateFactorial(number - 1);
        }
    }
}

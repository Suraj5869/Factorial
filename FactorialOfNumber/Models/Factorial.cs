﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialOfNumber.Models
{
    internal class Factorial
    {
        public static double CalculateFactorial(int number)
        {
            double product = 1;

            for (int i = 2; i <= number; i++)
            {
                product = product * i;
            }
            return product;
        }
    }
}

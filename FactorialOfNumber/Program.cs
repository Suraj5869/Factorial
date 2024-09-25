using FactorialOfNumber.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int number = int.Parse(Console.ReadLine());

            //Fcatorial of a number using simple method
            Console.WriteLine("Factorial of number using simple method:");
            Console.WriteLine($"Factorial of number {number} is: {Factorial.CalculateFactorial(number)}\n");

            //Factorial of a number using recursive method
            double fact = RecursiveFactorial.CalculateFactorial(number);
            Console.WriteLine("Factorial of number using recursive method:");
            Console.WriteLine($"Factorial of number {number} is: {fact}\n");
        }
    }
}

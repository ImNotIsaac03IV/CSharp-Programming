using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.Write("Insert a number to dissect it into it's primfactors: ");
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Incorrect input. Only digits are allowed");
            }

            int factorizer = 2;

            while (input > 1)
            {
                if (input % factorizer == 0)
                {
                    Console.WriteLine($"{input,4}  : {factorizer,4} = {input / factorizer,4}");

                    input /= factorizer;
                }
                else
                {
                    factorizer++;
                }
            }
        }
    }
}

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3XPlus1
{
    internal class Program
{
    static void Main(string[] args)
    {
        int number;
        int iterations = 0;
        Console.Write("Enter a number: ");
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Please enter a digit.");
        }

        Console.WriteLine();

        while (number != 1)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} : 2 = {number / 2}");
                number /= 2;
            }
            else if (number % 2 == 1)
            {
                Console.WriteLine($"{number} x 3 + 1 = {(number * 3) + 1}");
                number = (number * 3) + 1;
            }
            iterations++;
        }
        Console.WriteLine();
        Console.WriteLine($"Number of iterations needed to reach 1: {iterations}");
        Console.ReadKey();
    }
}
}

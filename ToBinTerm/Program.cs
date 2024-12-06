using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToBinTerm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            string input;
            Console.WriteLine("Convert decimal to binary");
            Console.WriteLine("=========================");
            do
            {
                Console.Write("Please enter a number: ");
                input = Console.ReadLine();
                Console.WriteLine();
                while (!int.TryParse(input, out number))
                {
                    Console.WriteLine("Invalid input.");
                }
                string seperate = " ";
                string binary = " ";
                int exponent = 0;
                int answer = 1;
                if(number == 0)
                {
                    Console.WriteLine("Kann nicht eingegeben werden");
                    break;
                }
                Console.Write($"This number {number} can be written as: ");
                while (answer <= number)
                {
                    if ((number & answer) == answer)
                    {
                        Console.Write(seperate + $"2^{exponent}");
                        seperate = " + ";
                    }
                    exponent++;
                    answer *= 2;
                }
                Console.Write($" = {input}");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write($"The binary form of {number} is: ");
                while (number > 0)
                {
                    int remainder = number % 2;
                    binary = remainder.ToString() + binary;
                    number /= 2;
                }
                Console.WriteLine($" {binary}");
                Console.WriteLine();
                Console.WriteLine("=========================");
                Console.WriteLine();
            }
            while (input.ToLower() != "x");
        }
    }
}
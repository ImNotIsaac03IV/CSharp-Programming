using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Christmas_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int input;
            Console.Write("Enter the height of your christmas tree: ");
            while (!int.TryParse(Console.ReadLine(), out input) || input <= 0) 
            {
                Console.WriteLine("Invalid input.");
                Console.WriteLine();
                Console.Write("Enter the height of your christmas tree: ");
            }

            for (int i = 0; i < input; i++)
            {
                for (int n = i; n < input; n++)
                {
                    Console.Write(" ");
                }
                for (int n = 0; n < i * 2 - 1; n++)
                {
                    counter++;
                    if (counter % 7 == 0)
                    {
                        Console.Write("Q");
                    }
                    else
                    {
                        Console.Write("x");
                    }
                }
                Console.WriteLine();
            }

            for (int i = 0; i < input - 1; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("x");

            Console.ReadKey();
        }
    }
}
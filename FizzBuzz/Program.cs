using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz");
            Console.WriteLine("=========");
            int startwert;
            Console.Write("Startwert eingeben: ");
            while (!int.TryParse(Console.ReadLine(), out startwert)||startwert <= 0)
            {
                Console.WriteLine("Ungültige Eingabe!");
                Console.WriteLine();
                Console.Write("Startwert eingeben: ");
            }
            int endwert;
            Console.Write("Endwert eingeben: ");
            while(!int.TryParse(Console.ReadLine(), out endwert)||endwert < startwert)
            {
                Console.WriteLine("Ungültige Eingabe!");
                Console.WriteLine();
                Console.Write("Endwert eingeben: ");
            }
            int counter = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("**********");
            }
            Console.WriteLine();
            while (startwert <= endwert)
            {
                if (startwert % 3 == 0 && startwert % 5 == 0)
                {
                    Console.Write($"{"FizzBuzz,",10}");
                }
                else if (startwert % 3 == 0)
                {
                    Console.Write($"{"Fizz,",10}");
                }
                else if (startwert % 5 == 0)
                {
                    Console.Write($"{"Buzz,",10}");
                }
                else
                {
                    Console.Write($"{startwert + ",", 10}");
                }
                counter++;
                if (counter % 10 == 0)
                {
                    Console.WriteLine();
                }
                startwert++;
            }
            if (counter % 10 != 0)
            {
                Console.WriteLine();
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write("**********");
            }
            Console.WriteLine();
        }
    }
}
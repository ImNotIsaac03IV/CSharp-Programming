﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Array_Statistic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Statistic");
            StarPrinter();

            Console.Write("Please enter the count of numbers: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());

            int[] values = InsertValues(arraySize);

            Console.Write("Please enter lower bound: ");
            int lowerBound = int.Parse(Console.ReadLine());

            Console.Write("Please enter upper bound: ");
            int upperBound = int.Parse(Console.ReadLine());

            PrintResult(values, lowerBound, upperBound);

            Console.ReadKey();
        }
        static void StarPrinter()
        {
            Console.WriteLine("*******************************");
        }
        static void LineBreaker()
        {
            Console.WriteLine();
        }
        static int[] InsertValues(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Please enter {i + 1}. number: ");
                int input = int.Parse(Console.ReadLine());

                array[i] = input;
            }
            return array;
        }
        static void PrintResult(int[] values, int lowerBound, int upperBound)
        {
            int counter = 0;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > lowerBound && values[i] < upperBound)
                {
                    counter++;
                }
            }
            Console.Write($"{counter} numbers are in the range of [{lowerBound}...{upperBound}]");
            LineBreaker();
            StarPrinter();
        }
    }
}

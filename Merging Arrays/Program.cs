using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GradeStatistic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[ReadUserInput("Please enter the size of your first array: ")];

            LineBreaker();

            Console.WriteLine("Insert values for your first array");

            firstArray = InsertValues(firstArray);

            LineBreaker();

            int[] secondArray = new int[ReadUserInput("Please enter the size of your second array: ")];

            LineBreaker();

            Console.WriteLine("Insert values for your second array");

            secondArray = InsertValues(secondArray);

            int[] jointArray = MergeArray(firstArray, secondArray);

            LineBreaker();

            PrintResult(jointArray);

            Console.ReadKey();
        }
        static int ReadUserInput(string message)
        {
            Console.Write(message);

            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
            {
                Console.Write("Invalid input, enter a number: ");
            }
            return number;
        }
        static int[] InsertValues(int[] intValue)
        {
            for (int i = 0; i < intValue.Length; i++)
            {
                Console.Write($"Insert {i + 1}. value: ");

                int value = ReadNumber();

                intValue[i] = value;
            }
            return intValue;
        }
        static void LineBreaker()
        {
            Console.WriteLine();
        }
        static int[] MergeArray(int[] firstValue, int[] secondValue)
        {
            int[] jointArray = new int[firstValue.Length + secondValue.Length];

            int i;

            for (i = 0; i < jointArray.Length / 2; i++)
            {
                jointArray[i] = firstValue[i];
            }
            int n = 0;

            for (int j = i; j < jointArray.Length; j++)
            {
                jointArray[j] = secondValue[n];

                n++;
            }
            return SortArray(jointArray);
        }
        static void PrintResult(int[] jointArray)
        {
            Console.WriteLine("The values of your merged array");
            Console.WriteLine("-------------------------------");

            int counter = 0;
            foreach (int i in jointArray)
            {
                if (counter > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(i);
                counter++;

                if (counter == jointArray.Length)
                {
                    Console.Write(".");
                }
            }
        }
        static int ReadNumber()
        {
            int value;
            while (!int.TryParse(Console.ReadLine(), out value) || value < 0)
            {
                Console.Write("Insert a valid number: ");
            }
            return value;
        }
        static int[] SortArray(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length - i - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        int temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;
                    }
                }
            }
            return input;
        }
    }
}
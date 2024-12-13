using Microsoft.SqlServer.Server;
using System;

namespace SudokuHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string notFoundDigits = "";
            string sudokuNumbers = "123456789";

            bool isValid = true;
            bool hasInvalidChars = false;

            Console.Write("Please enter all digits in a row/col/3x3 (empty to exit): ");
            string input = Console.ReadLine();

            for (int i = 0; i <input.Length && isValid; i++)
            {
                char c = input[i];

                if ((c < '1' || c > '9') && c != ' ')
                {
                    isValid = false;
                    hasInvalidChars = true;
                }
            }

            if (isValid && !hasInvalidChars)
            {
                for (int i = 0; i < input.Length && isValid; i++)
                {
                    char c = input[i];
                    if (c != ' ')
                    {
                        for (int j = i + 1; j < input.Length; j++)
                        {
                            char l = input[j];
                            if(l == c)
                            {
                                isValid = false;
                            }
                        }
                    }
                }
            }

            if (isValid && !hasInvalidChars)
            {
                for (int i = 0; i < sudokuNumbers.Length; i++)
                {
                    char s = sudokuNumbers[i];
                    bool isFound = false;
                    for (int j = 0; j < input.Length && !isFound; j++)
                    {
                        if (input[j] == s)
                        {
                            isFound = true;
                        }
                    }
                    if (!isFound)
                    {
                        notFoundDigits += s;
                    }
                }
                if (notFoundDigits == "")
                {
                    Console.WriteLine("Nothing is possible");
                }
                else
                {
                    Console.WriteLine($"{notFoundDigits} is possible");
                }
            }
            else
            {
                Console.WriteLine("Make sure input contains only numbers and no duplicates");
            }
            Console.ReadKey();
        }
    }
}

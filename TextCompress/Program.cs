using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextCompress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence to compress: ");
            string input = Console.ReadLine();
            int start = 0;
            int end = input.Length - 1;
            string output = "";

            while (start <= input.Length && input[start] == ' ')
            {
                start++;
            }
            while (end >= input.Length && input[end] == ' ')
            {
                end--;
            }
            bool previousWasSpace = false;
            for (int i = start; i <= end; i++)
            {
                char c = input[i];
                if (c == ' ')
                {
                    if (!previousWasSpace)
                    {
                        output += input[i];
                        previousWasSpace = true;
                    }
                }
                else
                {
                    output += c;
                    previousWasSpace = false;
                }
            }
            Console.WriteLine($"Compressed form: {output}");
            Console.ReadKey();
        }
    }
}
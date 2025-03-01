using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Letter-Count");
            Console.Write("Please enter a text: ");
            string input = UserInput();
            Console.WriteLine();

            int[] letterSize = new int[26];

            int other = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (c >= 'A' && c <= 'Z')
                {
                    int value = c - 'A';
                    letterSize[value]++;
                }
                else
                {
                    other++;
                }
            }
            PrintResults(letterSize);
            Console.Write($"Other: " + other);
        }
        static string UserInput()
        {
            return Console.ReadLine().ToUpper();
        }
        static void PrintResults(int[] letterSize)
        {
            for (int i = 0; i < letterSize.Length / 2; i++)
            {
                Console.Write($"{(char)(i + 'A')}: {letterSize[i],-3}");

                int rightColumn = (letterSize.Length / 2) + i;
                if (rightColumn < 26)
                {
                    Console.Write($"{(char)(rightColumn + 'A')}: {letterSize[rightColumn],-3}");
                }
                Console.WriteLine();
            }
        }
    }
}

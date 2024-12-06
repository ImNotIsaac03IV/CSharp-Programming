using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string output = "";
            Console.Write("Type in a sentence: ");
            string input = Console.ReadLine();
            Console.Write("Enter letters you'd like to exclude: ");
            string excludedLetters = Console.ReadLine();
            Console.Write("Output text: ");
            for (int i = 0; i < input.Length; i++)
            {
                char c = char.ToLower(input[i]);
                bool isExcluded = false;

                for (int j = 0; j < excludedLetters.Length; j++)
                {
                    if(c == char.ToLower(excludedLetters[j]))
                    {
                        isExcluded = true;
                    }
                }
                if (!isExcluded)
                {
                    output += input[i];
                }
            }
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterVocals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Extracting vowels from input");
            Console.WriteLine("============================");
            Console.Write("Text: ");
            string input = Console.ReadLine();
            string vowels = "aeiou";
            string extractedVowels = "";
            int vowelCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char c = char.ToLower(input[i]);
                bool isVowel = false;
                for (int x = 0; x < vowels.Length; x++)
                {
                    if (c == vowels[x])
                    {
                        isVowel = true;
                    }
                }
                bool foundVowels = false;
                for (int y = 0; y < extractedVowels.Length; y++)
                {
                    if ( c == extractedVowels[y])
                    {
                        foundVowels = true;
                    }
                }
                if(isVowel && !foundVowels)
                {
                    vowelCount++;
                    extractedVowels += c;
                }
            }
            Console.WriteLine($"The Text \"{input}\" contains {vowelCount} Vowels: {extractedVowels}");
            Console.ReadKey();
        }
    }
}

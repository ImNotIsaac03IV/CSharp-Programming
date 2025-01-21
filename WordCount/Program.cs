using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Words in a sentence");
            Console.WriteLine("*******************");
            Console.Write("Sentence: ");
            string input = Input();
            while (End(input))
            {
                Console.Write($"The sentence: \"{input}\" contains {WordsCounter(input)}");
                Console.WriteLine();
                WordsCounter(input);
                Console.WriteLine();
                Console.Write("Sentence: ");
                input = Input();
            }
            Console.WriteLine();
            Console.WriteLine("Closing program, goodbye!");
        }
        static string Input()
        {
            string textInput = Console.ReadLine();
            return textInput;
        }
        static bool End(string textInput)
        {
            if (textInput.ToLower() == "end")
            {
                return false;
            }
            return true;
        }
        static string RemoveOuterSpace(string textInput)
        {
            int start = 0;
            int end = textInput.Length - 1;
            string output = "";

            while (start < textInput.Length && textInput[start] == ' ')
            {
                start++;
            }
            while (end >= textInput.Length - start && textInput[end] == ' ')
            {
                end--;
            }
            for (int i = start; i <= end; i++)
            {
                char c = textInput[i];
                output += c;
            }
            return output;
        }
        static string RemoveInnerSpace(string textInput)
        {
            textInput = RemoveOuterSpace(textInput);
            string output = "";
            bool previousWasSpace = false;

            for (int i = 0; i < textInput.Length; i++)
            {
                char c = textInput[i];

                if (c == ' ')
                {
                    if (!previousWasSpace)
                    {
                        output += c;
                        previousWasSpace = true;
                    }
                }
                else
                {
                    output += c;
                    previousWasSpace = false;
                }
            }
            return output;
        }
        static int WordsCounter(string textInput)
        {
            textInput = RemoveInnerSpace(textInput);
            string output = "";
            int counter = 1;
            bool isSpace = false;
            if (textInput != "")
            {
                for (int i = 0; i < textInput.Length; i++)
                {
                    isSpace = false;
                    char c = textInput[i];
                    if (c != ' ')
                    {
                        output += c;
                    }
                    else
                    {
                        output = "";
                        isSpace = true;
                    }

                    if (output == "" && isSpace)
                    {
                        counter++;
                    }
                }
                if (counter >= 1)
                {
                    return counter;
                }
            }
            return 0;
        }
    }
}
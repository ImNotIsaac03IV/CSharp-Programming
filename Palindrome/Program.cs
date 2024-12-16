using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string output = "";
            int remainder;
            Console.Write("Enter a number to check if it's palindrome: ");
            int input = int.Parse(Console.ReadLine());
            int input2 = input;
            while (input > 0)
            {
                remainder = input % 10;
                output = output + remainder.ToString();
                input /= 10;    
            }
            Console.WriteLine();
            if(input2.ToString() == output)
            {
                Console.WriteLine($"Your input \"{input2}\" is Palindrome");
            }
            else
            {
                Console.WriteLine($"Your input \"{input2}\" is Not Palindrome");
            }
            Console.ReadKey();
        }
    }
}

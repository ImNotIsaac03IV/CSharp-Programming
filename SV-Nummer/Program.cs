using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV_Nummer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Check a SV Number");
            Console.WriteLine("*************************");
            Console.Write("Please enter a SV Number: ");
            input = Console.ReadLine();

            while (!String.IsNullOrEmpty(input))
            {
                int[] weight = { 3, 7, 9, 0, 5, 8, 4, 2, 1, 6 };
                if (CheckSVNumber(input, weight))
                {
                    Console.WriteLine($"The SV Number \"{input}\" is valid");
                }
                else
                {
                    Console.WriteLine($"The SV Number \"{input}\" is invalid");
                }
                Console.Write("Please enter a SV Number: ");
                input = Console.ReadLine();
            }
        }
        static int LengthSVNumber(string input)
        {
            return input.Length;
        }
        static bool ValidateSVNumber(string input)
        {
            while(!int.TryParse(input, out _))
            {
                return false;
            }
            return true;
        }
        static bool CheckDigit(string input, int[] weight)
        {
            int sum = 0;
            int rest;
            for (int i = 0; i < input.Length; i++)
            {
                int digit = input[i] - '0';
                sum += (digit * weight[i]);
            }
            rest = sum % 11;
            return rest == input[3] - '0';
        }
        static bool CheckSVNumber(string input, int[] weight)
        {
            if (LengthSVNumber(input) != 10)
            {
                return false;
            }
            if (!ValidateSVNumber(input))
            {
                return false;
            }
            if (!CheckDigit(input, weight))
            {
                return false;
            }
            return true;
        }
    }
}
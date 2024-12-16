using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int digitCounter = 0;
            Console.Write("Enter a number to check if it's narcissistic or not: ");
            int input = Convert.ToInt32(Console.ReadLine());

            while (input < 0)
            {
                Console.WriteLine("Make sure input > 0");
                Console.WriteLine();
                Console.Write("Insert number: ");
                input = Convert.ToInt32(Console.ReadLine());
            }
            int tempInput = input;
            int sum = 0;

            while (tempInput > 0)
            {
                tempInput /= 10;
                digitCounter++;
            }
            tempInput = input;
            while (tempInput > 0)
            {
                int lastDigit = tempInput % 10;
                tempInput /= 10;

                int power = 1;
                for (int i = 0; i < digitCounter; i++)
                {
                    power *= lastDigit;
                }
                sum += power;
            }

            if (sum == input)
            {
                Console.WriteLine($"\"{input}\" is a narcissistic number.");
            }
            else
            {
                Console.WriteLine($"\"{input}\" is not a narcissistic number.");
            }
            Console.ReadKey();
        }
    }
}

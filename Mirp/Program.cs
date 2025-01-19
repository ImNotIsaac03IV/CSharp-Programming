using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int counter = 0;

            for (int i = 10; i < 1000; i++)
            {
                if (IsMirp(i))
                {
                    Console.Write($"{i}, ");
                    counter++;

                    LineBreaker(counter);
                }
            }
            Console.WriteLine();
        }
        static void LineBreaker(int counter)
        {
            if (counter % 10 == 0)
            {
                Console.WriteLine();
            }
        }
        static bool isPrim(int numberInput)
        {
            int counter = 0;
            for (int i = 1; i <= numberInput; i++)
            {
                if (numberInput % i == 0)
                {
                    counter++;
                }
            }
            if (counter == 2)
            {
                return true;
            }
            return false;
        }
        static int reversedNumberInput(int numberInput)
        {
            string reversedNumberInput = "";
            while (numberInput > 0)
            {
                int remainder = numberInput % 10;
                reversedNumberInput = reversedNumberInput + remainder.ToString();
                numberInput /= 10;
            }
            return int.Parse(reversedNumberInput);
        }
        static bool IsMirp(int numberInput)
        {
            if (isPrim(numberInput) && isPrim(reversedNumberInput(numberInput)))
            {
                return true;
            }
            return false;
        }
    }
}

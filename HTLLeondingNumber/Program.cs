using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTLLeondingNumber
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Find HTL Leonding Number Numbers");
            Console.WriteLine("**********************************");
            Console.Write("Calculate until: ");
            int input = int.Parse(Console.ReadLine());
            int counter = 0;
            Console.WriteLine("**********************************");
            for (int i = 0; i < input; i++)
            {
                if (IsHTLLeondingNumber(i))
                {
                    if (counter > 0)
                    {
                        Console.Write(", ");
                        LineBreaker(counter);
                    }
                    Console.Write(i);
                    counter++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("************************************");
        }   
        static bool IsOdd(int input)
        {
            return input % 2 != 0;
        }
        static int DigitSum(int input)
        {
            int sum = 0;
            while (input > 0)
            {
                sum += input % 10;
                input /= 10;
            }
            return sum;
        }
        static bool SumDigitBiggerThanTen(int input)
        {
            return DigitSum(input) > 10;
        }
        static bool SmallerNumWithSameDigitSum(int input)
        {
            int inputDigitSum = DigitSum(input);
            for (int i = input - 1; i > 0; i--)
            {
                int digitSumI = DigitSum(i);
                if (digitSumI == inputDigitSum)
                {
                    return true;
                }
            }
            return false;
        }
        static int GGT(int a, int b)
        {
            int c;
            do
            {
                c = a % b;
                a = b;
                b = c;
            }
            while (c != 0);
            return a;
        }
        static bool IsPrime(int input)
        {
            if (input <= 1)
            {
                return false;
            }

            for (int i = 2; i * i <= input; i++)
            {
                if (input % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsHTLLeondingNumber(int input)
        {
            if (!IsOdd(input))
            {
                return false;
            }

            int digitSumInput = DigitSum(input);
            if (digitSumInput <= 10)
            {
                return false;
            }

            for (int i = input - 1; i > 0; i--)
            {
                int digitSumI = DigitSum(i);
                if (digitSumI == digitSumInput)
                {
                    if (IsPrime(GGT(input, i)))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        static void LineBreaker(int n)
        {
            if (n % 10 == 0)
            {
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieb_des_Eratosthenes
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Bis zu welcher Zahl wollen Sie Primzahlen ausgeben? ");
            int input = ReadUserInput();

            bool[] isPrime = SiebDesEra(input);

            int counter = 0;
            for (int i = 0; i < input; i++)
            {
                if (isPrime[i])
                {
                    Console.WriteLine(i);
                    counter++;

                    if (counter == 22)
                    {
                        Console.WriteLine("<Eingabetaste für ENDE>");
                        Console.ReadLine();
                        counter = 0;
                    }
                }
            }
        }
        static int ReadUserInput()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input) || input <= 1)
            {
                Console.Write("Input must be greater than 1: ");
            }
            return input;
        }
        static bool[] SiebDesEra(int size)
        {
            bool[] isPrime = new bool[size];
            isPrime[0] = false;
            isPrime[1] = false;

            for (int i = 2; i < size; i++)
            {
                isPrime[i] = true;
            }

            for (int i = 2; i * i < size; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j < size; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            return isPrime;
        }
    }
}

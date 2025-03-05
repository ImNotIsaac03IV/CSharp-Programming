using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieb_des_Eratosthenes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = UserInput("Bis zu welcher Zahl wollen Sie Primzahlen ausgeben? ");
            Console.WriteLine($"Primzahlen von 1 - {input}");
            for (int i = 2; i < input; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static int UserInput(string message)
        {
            Console.Write(message);
            int input;
            while (!int.TryParse(Console.ReadLine(), out input) || input < 2)
            {
                Console.Write("Ungültiger Eingabe. Eingabe wiederholen: ");
            }
            return input;
        }
        static bool IsPrime(int input)
        {
            if (input == 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(input); i++)
            {
                if (input % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

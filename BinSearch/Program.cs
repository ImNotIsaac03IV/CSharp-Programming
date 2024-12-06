using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BinSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int minNumber = 1;
            int maxNumber = 1000;
            int tries = 0;
            char answer = '.';

            while (answer != 'e')
            {
                int guess = (minNumber + maxNumber) / 2;

                tries++;
                Console.WriteLine($"My guess is: {guess}");
                Console.WriteLine($"Is your number [g]reater, [l]ess or [e]qual:");
                answer = char.Parse(Console.ReadLine().ToLower());

                if (answer == 'l')
                {
                    maxNumber = guess - 1;
                }
                else if (answer == 'g')
                {
                    minNumber = guess + 1;
                }
                else if (answer == 'e')
                {
                    Console.WriteLine($"I have found the number within {tries} tries");
                    return;
                }
            }
        }
    }
}

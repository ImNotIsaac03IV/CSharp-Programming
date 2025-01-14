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
            Console.Write("Enter a number: ");
            isMirp();
            Console.ReadKey();
        }
        static void isMirp()
        {
            bool reversedInputIsPrime = false;
            string reversedInput = "";
            bool inputIsPrime = false;
            int counter = 0;
            int number;
            string input = Console.ReadLine();

            while (!int.TryParse(input, out number) || !(number > 10 && number < 1000))
            {
                Console.WriteLine("input must be a number between 10 and 1000");
                Console.Write("Enter a number: ");
                input = Console.ReadLine();
            }

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    counter++;
                }
            }
            if (counter == 2)
            {
                inputIsPrime = true;
            }
            else
            {
                inputIsPrime = false;
            }
            counter = 0;

            while (number > 0)
            {
                int remainder = number % 10;
                reversedInput = reversedInput + remainder.ToString();
                number /= 10;
            }

            for (int i = 1; i <= 1000; i++)
            {
                if (int.Parse(reversedInput) % i == 0)
                {
                    counter++;
                } 
            }
            if (counter == 2)
            {
                reversedInputIsPrime = true;
            }
            else
            {
                reversedInputIsPrime = false;
            }

            if (reversedInputIsPrime && inputIsPrime)
            {
                Console.WriteLine("Your input is a mirp number!!!");
            }
            else
            {
                Console.WriteLine("Your input isn't a mirp number...");
            }
        }
    }
}

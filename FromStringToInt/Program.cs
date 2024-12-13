using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromStringToInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello World"; //<--- Input here
            int value = 1 * 1000 + 2 * 100 + 3 * 10 + 4;
            int value2 = ((1 * 10 + 2) * 10 + 3) * 10 + 4;

            int val = 0;

            for (int i = 0; i < text.Length; i++)
            {
                val = val * 10 + text[i] - '0';
            }

            Console.WriteLine(val);
            Console.ReadKey();
        }
    }
}

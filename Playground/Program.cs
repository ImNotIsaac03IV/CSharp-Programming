using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;

class Program
{
    static void Main()
    {
        int sum = 0;
        Console.Write("Enter a number to check if it's perfect or not: ");
        int input = Convert.ToInt32(Console.ReadLine());

        while (input < 0)
        {
            Console.WriteLine("Input must be > 0");
            Console.WriteLine();
            Console.Write("Enter a number to check if it's perfect or not: ");
            input = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 1; i <= input / 2; i++)
        {
            if (input % i == 0)
            {
                sum += i;
            }
        }
        if(sum == input)
        {
            Console.WriteLine("Perfect number");
        }
        else
        {
            Console.WriteLine("Non-Perfect number");
        }
        Console.ReadKey();
    }
}

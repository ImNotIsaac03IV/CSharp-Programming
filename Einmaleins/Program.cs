using System;

class Program
{
    static void Main(string[] args)
    {
        int input;
        Console.Write("Enter a number to print out it's multiplication table: ");
        while (!int.TryParse(Console.ReadLine(), out input))
        {
            Console.Write("Input invalid. Enter a number: ");
        }
        Console.WriteLine();

        if (input == 0)
        {
            Console.WriteLine("+");
        }

        Console.Write("+");

        for (int i = 1; i <= input; i++)
        {
            Console.Write("---+");
        }
        Console.WriteLine();

        for (int x = 1; x <= input; x++)
        {
            Console.Write("|");

            for (int y = 1; y <= input; y++)
            {
                int row = x * y;

                Console.Write($"{row,3}");

                Console.Write("|");
            }
            Console.WriteLine();

            Console.Write("+");

            for (int i = 1; i <= input; i++)
            {
                Console.Write("---+");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}

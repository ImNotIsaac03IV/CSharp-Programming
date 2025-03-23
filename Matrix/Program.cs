using System;

namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Rows? ");
                int rows = ReadUserInput("Rows");

                Console.Write("Columns? ");
                int columns = ReadUserInput("Columns");

                int[,] matrix = CreateMatrix(rows, columns);

                CompareAndPrintMatrix(matrix);
                Console.WriteLine();
                Console.Write("New matrix? (Y/ N) ");
            }
            while (Continue(Console.ReadLine()));
            Console.WriteLine();
            Console.WriteLine("Closing program... bye!");

        }
        public static int ReadUserInput(string rowcolumn)
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.Write($"Invalid input, enter a number ({rowcolumn}): ");
            }
            return input;
        }
        public static int[,] CreateMatrix(int rows, int columns)
        {
            int[,] array = new int[rows, columns];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Random.Shared.Next(1, 10);
                }
            }
            return array;
        }
        public static void CompareAndPrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                bool first = true;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (!first)
                    {
                        if (matrix[i, j - 1] < matrix[i, j])
                        {
                            Color("Red");
                            Console.Write("<");
                            Color("None");
                        }
                        else if (matrix[i, j - 1] > matrix[i, j])
                        {
                            Color("Red");
                            Console.Write(">");
                            Color("None");
                        }
                        else
                        {
                            Color("Green");
                            Console.Write("=");
                            Color("None");
                        }

                    }
                    first = false;

                    Color("Yellow");
                    Console.Write($" {matrix[i, j]} ");
                    Color("None");

                }
                Console.WriteLine();
            }
        }
        public static void Color(string colourName)
        {
            switch (colourName.ToLower())
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                break;

                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                break;

                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                break;

                default:
                    Console.ForegroundColor = ConsoleColor.White;
                break;
            }
        }
        public static bool Continue(string input)
        {
            bool output;
            while (String.IsNullOrEmpty(input) || !(input.ToLower() == "y" || input.ToLower() == "n"))
            {
                Console.Write("Enter \"Y\" or \"N\" to proceed: ");
                input = Console.ReadLine();
            }
            if (input.ToLower() == "y")
            {
                output = true;
            }
            else
            {
                output = false;
            }
            Console.WriteLine();
            return output;
        }
    }
}

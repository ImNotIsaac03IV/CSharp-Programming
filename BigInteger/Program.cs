using System;

class Program
{
    static void Main()
    {
        string input;
        do
        {
            Console.WriteLine("Big integer");
            Console.WriteLine("***********");
            string bigInteger1 = ReadBigInteger("Please enter 1. number: ");
            string bigInteger2 = ReadBigInteger("Please enter 2. number: ");
            string sum = AddBigInteger(bigInteger1, bigInteger2);
            LineBreaker();
            Console.WriteLine($"Sum: {sum}");
            string product = MultiplyBigInteger(bigInteger1, bigInteger2);
            Console.WriteLine($"Product: {product}");

            Console.Write("Continue with \"y\": ");
            input = Console.ReadLine();
            LineBreaker();
        }
        while (Continue(input));
    }
    static string ReadBigInteger(string message)
    {
        Console.Write(message);
        string numbers = Console.ReadLine();
        while (!IsValidBigInteger(numbers) || string.IsNullOrEmpty(numbers))
        {
            Console.WriteLine("Invalid input.");
            Console.Write("Please, enter a valid number: ");
            numbers = Console.ReadLine();
            LineBreaker();
        }
        return numbers;
    }
    static bool IsValidBigInteger(string input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] < '0' || input[i] > '9')
            {
                return false;
            }
        }
        return true;
    }
    static string AddBigInteger(string bigInteger1, string bigInteger2)
    {
        while (bigInteger1.Length < bigInteger2.Length)
        {
            bigInteger1 = "0" + bigInteger1;
        }
        while (bigInteger2.Length < bigInteger1.Length)
        {
            bigInteger2 = "0" + bigInteger2;
        }
        int remainder = 0;
        string result = "";
        for (int i = bigInteger1.Length - 1; i >= 0; i--)
        {
            int sum = (bigInteger1[i] - '0') + (bigInteger2[i] - '0') + remainder;
            remainder = sum / 10;
            result = (sum % 10) + result;
        }
        if (remainder > 0)
        {
            result = remainder + result;
        }
        return result;
    }
    static string MultiplyBigIntegerWithDigit(string bigInteger, char digit)
    {
        int remainder = 0;
        string result = "0";
        for (int i = bigInteger.Length - 1; i >= 0; i--)
        {
            int product = (bigInteger[i] - '0') * (digit - '0') + remainder;
            remainder = product / 10;
            result = (product % 10) + result;
        }
        if (remainder > 0)
        {
            result = remainder + result;
        }
        return result;
    }
    static string MultiplyBigInteger(string bigInteger1, string bigInteger2)
    {
        if (bigInteger1 == "0" ||bigInteger2 == "0")
        {
            return "0";
        }
        string result = "0";
        string zeros = "";
        for (int i = bigInteger2.Length - 1; i >= 0; i--)
        {
            string product = MultiplyBigIntegerWithDigit(bigInteger1, bigInteger2[i]);
            product += zeros;
            result = AddBigInteger(product, result);
            zeros += "0";
        }
        int index = 0;
        while (index < result.Length - 1 && result[index] == '0')
        {
            index++;
        }
        string cleanedResult = "";
        for (int i = index; i < result.Length; i++)
        {
            cleanedResult += result[i];
        }
        return cleanedResult;
    }
    static void LineBreaker()
    {
        Console.WriteLine();
    }
    static bool Continue(string input)
    {
        if (input.ToLower() == "y")
        {
            return true;
        }
        return false;
    }
}

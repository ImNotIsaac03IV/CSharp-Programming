using System;

class Program
{
    static void Main()
    {
        char c = ' ';
        string decrypted = "";
        string encrypted = "";
        Console.Write("Enter a sentece to encrypt: ");
        string input = Console.ReadLine();
        Console.WriteLine();

        while (input.ToLower() != "exit")
        {
            encrypted = "";

            for (int i = 0; i < input.Length; i++)
            {
                c = input[i];
                if(c >= 'a' && c <= 'z')
                {
                    c = (char)((c - 'a' + 13) % 26 + 'a');
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    c = (char)((c - 'A' + 13) % 26 + 'A');
                }
                encrypted += c;
            }
            decrypted = "";

            for (int j = 0; j < encrypted.Length; j++)
            {
                c = encrypted[j];
                if (c >= 'a' && c <= 'z')
                {
                    c = (char)((c - 'a' + 13) % 26 + 'a');
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    c = (char)((c - 'A' + 13) % 26 + 'A');
                }
                decrypted += c;
            }
            Console.WriteLine("Encrypted text: " + encrypted);
            Console.WriteLine();
            Console.WriteLine("Decrypted text: " + decrypted);
            Console.WriteLine();
            Console.WriteLine("======================================");
            Console.Write("Type in another text or \"exit\" to exit: ");
            input = Console.ReadLine();
            Console.WriteLine();
        }
        Console.WriteLine("Goodbye");
    }
}

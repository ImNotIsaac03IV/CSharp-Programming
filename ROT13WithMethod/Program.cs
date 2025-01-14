using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROT13WithMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encryption/Decryption with ROT13");
            Console.Write("Plain: ");
            Rot13();
            Console.ReadKey();
        }

        static void Rot13()
        {
            string encrypt = "";
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (c >= 'a' && c < 'z')
                {
                    c = (char)((c - 'a' + 13) % 26 + 'a');
                }
                encrypt += c;
            }
            string decrypt = "";
            for (int j = 0; j < encrypt.Length; j++)
            {
                char s = encrypt[j];

                if (s >= 'a' && s < 'z')
                {
                    s = (char)((s - 'a' + 13) % 26 + 'a');
                }
                decrypt += s;
            }

            Console.WriteLine($"Encrypted: {encrypt}");
            Console.WriteLine($"Decrypted: {decrypt}");
        }
    }
}

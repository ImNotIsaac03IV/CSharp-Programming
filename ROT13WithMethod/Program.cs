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
            Console.Write("Please enter a plain text: ");
            string textInput = Console.ReadLine();

            string encodedTextDisplay = Encrypt(textInput);
            string decodedTextDisplay = Decode(encodedTextDisplay);

            Console.WriteLine($"Plain:     {textInput}");
            Console.WriteLine($"Encrypted: {encodedTextDisplay}");
            Console.WriteLine($"Decryted:  {decodedTextDisplay}");
        }
        static string Encrypt(string encodeText)
        {
            string encodedTextOutput = "";
            for (int i = 0; i < encodeText.Length; i++)
            {
                char c = encodeText[i];
                if (c >= 'a' && c <= 'z')
                {
                    c = (char)((c - 'a' + 13) % 26 + 'a');
                }
                encodedTextOutput += c;
            }
            return encodedTextOutput;
        }
        static string Decode(string encodeText)
        {
            return Encrypt(encodeText);
        }
    }
}

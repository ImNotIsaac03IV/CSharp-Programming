using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turtle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.Clear();

            bool penDown = false;
            int movement;
            int x = 0, y = 24;
            string input;

            Console.Write("Enter the commands to start drawing: ");
            input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (c == 'D')
                {
                    penDown = true;
                }
                else if (c == 'U')
                {
                    penDown = false;
                }
                else if (c >= '0' && c <= '9')
                {
                    movement = c - '0';

                    switch (movement)
                    {
                        case 0:
                            y--;
                        break;

                        case 1:
                            y--; x++;
                        break;

                        case 2:
                            x++;
                        break;

                        case 3:
                            x++; y++;
                        break;

                        case 4:
                            y++;
                        break;

                        case 5:
                            y++; x--;
                        break;

                        case 6:
                            x--;
                        break;

                        case 7:
                            x--; y--;
                        break;

                        default:
                            Console.WriteLine("Invalid command");
                        break;
                    }

                    Console.SetCursorPosition(x, y);
                }

                if (y < 0)
                {
                    y = 0;
                }
                if (y >= 25)
                {
                    y = 24;
                }
                if (x < 0)
                {
                    x = 0;
                }
                if (x >= 80)
                {
                    x = 79;
                }

                if (penDown)
                {
                    Console.Write("*");
                }
            }
            Console.SetCursorPosition(0, 24);
            Console.WriteLine();
        }
    }
}

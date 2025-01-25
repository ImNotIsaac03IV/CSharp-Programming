using System;

class Program
{
    const int COLS = 80;
    const int ROWS = 25;

    static void Main()
    {
        Initialize();
        DrawLine(0, 0, COLS - 1, 0, ConsoleColor.Green);
        DrawAHouse(5, 1, ConsoleColor.White);
        DrawAHouse(30, 2, ConsoleColor.Magenta);
        DrawAHouse(55, 3, ConsoleColor.Yellow);
    }

    static void Initialize()
    {
        Console.SetWindowSize(COLS, ROWS);
    }

    static void DrawDot(int x, int y, ConsoleColor color)
    {
        y = ROWS - y - 1;
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write('*');
    }

    static void DrawLine(int x0, int y0, int x1, int y1, ConsoleColor color)
    {
        int distanceX = x1 - x0;
        int distanceY = y1 - y0;

        int distance = Math.Max(Math.Abs(distanceX), Math.Abs(distanceY));

        for (int i = 0; i <= distance; i++)
        {
            int x = x0 + i * distanceX / distance;
            int y = y0 + i * distanceY / distance;
            DrawDot(x, y, color);
        }
    }

    static void DrawBox(int x0, int y0, int x1, int y1, ConsoleColor color)
    {
        DrawLine(x0, y0, x1, y0, color);
        DrawLine(x0, y1, x1, y1, color);
        DrawLine(x0, y0, x0, y1, color);
        DrawLine(x1, y0, x1, y1, color);
    }

    static void FillBox(int x0, int y0, int x1, int y1, ConsoleColor color)
    {
        for (int y = y0; y <= y1; y++)
        {
            for (int x = x0; x <= x1; x++)
            {
                DrawDot(x, y, color);
            }
        }
    }

    static void DrawAHouse(int startX, int startY, ConsoleColor houseColor)
    {
        DrawBox(startX, startY, startX + 17, startY + 10, houseColor);

        DrawLine(startX - 1, startY + 9, startX + 8, startY + 18, houseColor);
        DrawLine(startX + 8, startY + 18, startX + 18, startY + 9, houseColor);

        FillBox(startX + 7, startY, startX + 10, startY + 3, ConsoleColor.DarkRed);

        FillBox(startX + 3, startY + 6, startX + 5, startY + 8, ConsoleColor.White);
        FillBox(startX + 10, startY + 6, startX + 12, startY + 8, ConsoleColor.White);
        FillBox(startX + 10, startY + 2, startX + 12, startY + 4, ConsoleColor.White);
    }
}

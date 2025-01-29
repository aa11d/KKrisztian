using System;
class Valami
{

    const int N = 60;

    const int M = 30;

    static int[,] palya = new int[N, M];

    static void KajaElhelyez(int db)
    {
        Random rnd = new();
        for (int i = 0; i < db; i++)
        {
            int kajaX = rnd.Next(0, N);
            int kajaY = rnd.Next(0, M);
            int kajaErtek = rnd.Next(5, 10);
            palya[kajaX, kajaY] = kajaErtek;
        }
    }

    static void KajaRajz()
    {
        for (int x = 0; x < N; x++)
        {
            for (int y = 0; y < M; y++)
            {
                if (palya[x, y] > 0)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(palya[x, y]);
                }
            }
        }
    }

    static void KajaFogy()
    {
        for (int x = 0; x < N; x++)
        {
            for (int y = 0; y < M; y++)
            {
                if (palya[x, y] > 0)
                {
                    palya[x, y]--;
                    if (palya[x, y] == 0)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write(' ');
                    }
                }
            }
        }
    }

    static void Main()
    {
        Console.SetWindowSize(N, M);

        bool exit = false;
        int timer = 0;
        int babuX = N / 2;
        int babuY = M / 2;
        int teleHas = 10;
        Console.SetCursorPosition(babuX, babuY);
        Console.Write('X');
        KajaElhelyez(30);
        while (!exit)
        {
            timer++;

            Console.SetCursorPosition(0, 0);
            Console.Write(teleHas);
            if (timer % 50 == 0)
            {
                KajaFogy();
            }
            if (timer % 70 == 0)
            {
                teleHas--;
                if (teleHas == 0)
                {
                    exit = true;
                }
            }
            KajaRajz();

            Thread.Sleep(100);
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressed = Console.ReadKey(true);
                if (pressed.Key == ConsoleKey.Escape)
                {
                    exit = true;
                }
                else if (pressed.Key == ConsoleKey.UpArrow && babuY > 0)
                {
                    Console.SetCursorPosition(babuX, babuY);
                    Console.Write(' ');
                    babuY--;
                    Console.SetCursorPosition(babuX, babuY);
                    Console.Write('X');
                }
                else if (pressed.Key == ConsoleKey.DownArrow && babuY < M - 1)
                {
                    Console.SetCursorPosition(babuX, babuY);
                    Console.Write(' ');
                    babuY++;
                    Console.SetCursorPosition(babuX, babuY);
                    Console.Write('X');
                }
                else if (pressed.Key == ConsoleKey.LeftArrow && babuX > 0)
                {
                    Console.SetCursorPosition(babuX, babuY);
                    Console.Write(' ');
                    babuX--;
                    Console.SetCursorPosition(babuX, babuY);
                    Console.Write('X');
                }
                else if (pressed.Key == ConsoleKey.RightArrow && babuX < N - 1)
                {
                    Console.SetCursorPosition(babuX, babuY);
                    Console.Write(' ');
                    babuX++;
                    Console.SetCursorPosition(babuX, babuY);
                    Console.Write('X');
                }

                if (palya[babuX, babuY] > 0)
                {
                    teleHas += palya[babuX, babuY];
                    palya[babuX, babuY] = 0;

                }
            }
        }
        Console.ReadKey();

    }
}
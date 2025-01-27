using System;

class HopesModellezes
{
    static int N = 30;
    static int M = 50;
    static double p = 0.1;
    static int[,] palya = new int[N, M];

    static Random rand = new Random();

    static void Main()
    {
        for (int j = 0; j < M; j++)
        {
            palya[N - 1, j] = 1;
        }

        while (HopehelyLetrehozas())
        {
            HopehelyMozgatas();
        }

        KiirPalya();
    }

    static bool HopehelyLetrehozas()
    {
        for (int j = 0; j < M; j++)
        {
            if (palya[0, j] == 0 && rand.NextDouble() < p)
            {
                palya[0, j] = 1;
                return true;
            }
        }
        return false;
    }

    static void HopehelyMozgatas()
    {
        for (int i = 0; i < N - 1; i++)
        {
            for (int j = 0; j < M; j++)
            {
                if (palya[i, j] == 1)
                {
                    var ujPos = new System.Collections.Generic.List<(int, int)>();

                    if (i + 1 < N && palya[i + 1, j] == 0) ujPos.Add((i + 1, j));
                    if (j - 1 >= 0 && palya[i + 1, j - 1] == 0) ujPos.Add((i + 1, j - 1));
                    if (j + 1 < M && palya[i + 1, j + 1] == 0) ujPos.Add((i + 1, j + 1));

                    if (ujPos.Count > 0)
                    {
                        var (ujI, ujJ) = ujPos[rand.Next(ujPos.Count)];
                        palya[ujI, ujJ] = 1;
                        palya[i, j] = 0;
                    }
                }
            }
        }
    }

    static void KiirPalya()
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write(palya[i, j] == 0 ? "." : "#");
            }
            Console.WriteLine();
        }
    }
}
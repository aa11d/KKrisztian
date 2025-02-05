using System;
class Lakotelep{

    const int N = 35;

    const int M = 35;

    const int K = 8;

    const double P = 0.1;

    static int[,] palya = new int[N, M];


    static void palyakiir(){

        for (int x = 0; x < N; x++)
        {
            for (int y = 0; y < M; y++)
            {
                if ( palya[x,y] == 0){
                    Console.Write('■');   
                }
                else{
                    Console.Write(palya[x,y]);
                }
            }
        }


    }
    

    static void szamitas(){
        int lakas = 0;
        for (int X = 0; X < N; X++)
        {
            for (int Y = 0; Y < M; Y++)
            {
                if (palya[X,Y] >= 1)
                {
                    lakas += palya[X,Y];
                }
            }
        }
        Console.WriteLine(lakas);
    }

    static void epulet(){
        
        int db = 0;
        
        while (db < K)
        {
            Random rnd = new Random();
            int x = rnd.Next(1, N-1);
            int y = rnd.Next(1, M-1);
            int szint = rnd.Next(1, 10);
            if ( palya[x,y] == 0 && palya[x-1,y] == 0 && palya[x+1,y] == 0 && palya[x,y-1] == 0 && palya[x,y+1] == 0){
                palya[x,y] = szint;
                db++;
            }
        }
        
    }

    static void panorama(){
         int panoramasdb = 0; 
        for (int x = 0; x < N; x++)
        {
            for (int y = 0; y < M; y++)
            {
                if (palya[x,y] > 0)
                {
                    bool van = false;
                    for (int i = x+1; i < N; i++)
                    {
                        if (palya[i,y] >= palya[x,y])
                        {
                           van = true;
                        }
                    }
                    if (!van)
                    {
                        panoramasdb++;
                    }
                    for (int j = x-1; j >=0 ; j--)
                    {
                        if (palya[j,y] >= palya[x,y])
                        {
                            van = true;
                        }
                    }
                    if (!van)
                    {
                        panoramasdb++;
                    }
                    for (int k = y+1; k < M; k++)
                    {
                        if (palya[x,k] >= palya[x,y])
                        {
                            van = true;
                        }
                    }
                    if (!van)
                    {
                        panoramasdb++;
                    }
                    for (int l = y-1; l >= 0; l--)
                    {
                        if (palya[x,l] >= palya[x,y])
                        {
                            van = true;
                        }
                    }
                    if (!van)
                    {
                        panoramasdb++;
                    }
                }


            }
        }
        Console.WriteLine($"Panorámás lakások: {panoramasdb}");

    }


    static void Main(){

        Console.SetWindowSize(N, M);
        epulet();
        palyakiir();
        szamitas();
        panorama();
    }

}
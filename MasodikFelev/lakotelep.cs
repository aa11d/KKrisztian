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
        Console.Write(lakas);
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

        for (int x = 0; x < N; x++)
        {
            for (int y = 0; y < M; y++)
            {
                if (palya[x,y] > 0)
                {
                    
                }
            }
        }

    }


    static void Main(){

        Console.SetWindowSize(N, M);
        epulet();
        palyakiir();
        szamitas();
        panorama();
    }

}
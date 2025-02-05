using System;
class Ut{

    static double P = 0.1;

    const int N = 80;

    static int[] palya = new int [80];

    static int[] Bal = [1, 3, 5, 6, 9]; 
    static int[] Jobb = [2, 4, 7, 8, 0];

    static Random rnd = new Random(); 

    static void Main(){
        for (int i = 0; i < 80; i++)
        {
            palya[i] = -1; 
        }
        int t = 0;
        while (!Console.KeyAvailable){
            t++;
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < N; i++)
            {
                if (palya[i] == -1){
                    Console.Write(' ');
                }
                else{
                    Console.Write(palya[i] % 10);
                }
            }
            if (palya[0] == -1){
                double veletlen = rnd.NextDouble();
                if (veletlen < P){
                    int velindex = rnd.Next(0, 5);
                    palya[0] = Bal[velindex];
                }
            }
            if (palya[79] == -1){
                t++;
                double vel3 = rnd.NextDouble();
                    if (vel3 < P){
                        int velindex2 = rnd.Next(0, 5);
                        palya[79] = Jobb[velindex2];
                    }
            }
            for (int i = 0; i < N; i++)
            {
                if (palya[i] != -1 && t % palya[i] == 0){
                    if (Bal.Contains(palya[i])){
                        if ( i == 79 ){
                            palya[i] = -1;
                        }
                        else{
                            if ( palya[i+1] == -1 ){
                                palya[i+1] = palya[i];
                                palya[i] = -1;
                            }
                        }
                    }
                    else {

                    }
                }
            }
        }

    }
}
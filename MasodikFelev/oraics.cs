using System;
class Orai{
       static int[] tomb;
       const int N = 20;

    static void kiir(){
        for ( int i = 0; i < N; i++){
            System.Console.Write(tomb[i]+" ");
        }
        System.Console.WriteLine();
    }
    static void csere(int i, int j){
        int plusz = tomb[i];
        tomb[i] = tomb[j];
        tomb[j] = plusz;
    }
    static void buborek(){
        for ( int meddig = N-2; meddig >= 0; meddig--){
            for (int mutato = 0; mutato <= meddig; mutato++){
                if ( tomb[mutato] > tomb[mutato+1]){
                    csere(mutato, mutato+1);
                }
            }
        }
    }
    static void Main(){
        tomb = new int[N];
        Random rnd = new ();
        for (int i = 0; i < N; i++){
            tomb[i] = rnd.Next(10,100);
        }
        kiir();
        boburek();
        kiir();
    }
}
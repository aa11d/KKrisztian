using System;

class Fuggvenyek
{

    static double Elteres(double a, double b, double c)
    {
        double eltab = Math.Abs(a-b);
        double eltac = Math.Abs(a-c);
        if ( eltab > eltac )
        {
            return eltab;
        }
        else
        {
            return eltac;
        }
    }

    /*
    static char Szovegel(string s, int n)
    {
        
    }*/


    static double parosAtlag( int[] szamok)
    {
        int osszeg = 0;
        int db = 0;
        for (int i = 0; i < szamok.Length; i++)
        {
            if ( szamok[i] % 2 == 0)
            {
                osszeg += szamok[i];
                db++;
            }
        }
        if ( db > 0)
        {
            return (double) osszeg / db;
        }
        else
        {
            return 0.0;
        }
    }



    static void Main()
    {   /*
        System.Console.WriteLine("Első szám: ");
        double elso = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Második szám: ");
        double maso = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Harmadik: ");
        double harm = double.Parse(Console.ReadLine());

        double eltmax = Elteres(elso, maso, harm);
        System.Console.WriteLine("Legnagyobb eltérés: " + eltmax);
        */

        System.Console.WriteLine("Számok: ");
        string sor = Console.ReadLine();
        string[] darabok = sor.Split(' ');
        int[] egeszek = new int[darabok.Length];
        for (int i = 0; i < darabok.Length; i++)
        {
            egeszek[i] = int.Parse(darabok[i]);
        }
        double atlag = parosAtlag(egeszek);
        System.Console.WriteLine("Az átlag: " + atlag);

    }
}
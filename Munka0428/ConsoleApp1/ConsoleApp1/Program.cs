namespace ConsoleApp1
{
    internal class Program
    {

        static int[] hosszak(string[] szovegek)
        {
            int[] hosszusagok = new int[szovegek.Length];
            for (int i = 0; i < szovegek.Length; i++)
            {
                hosszusagok[i] = szovegek[i].Length;
            }
            return hosszusagok;
        }

        static float oszt_szor(float num1, float num2, float num3)
        {
            float osszeg = 0;

            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                return 0;
            }
            else
            {
               osszeg = (num1 * num2) / num3;
            }
            return osszeg;
        }

        static int ptl_szama(List<int> szamok)
        {
            
        }

        static void Main(string[] args)
        {
            /*Console.WriteLine("Kérek egy szöveget, vesszővel elválasztva: ");
            string aszoveg = Console.ReadLine();
            string[] feldarabolva = aszoveg.Split(',');
            int[] ahosszak = hosszak(feldarabolva);
            Console.WriteLine("A hosszúságuk:");
            for (int i = 0; i < ahosszak.Length; i++)
            {
                Console.Write(ahosszak[i]);

                if ( i < ahosszak.Length - 1 )
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.WriteLine();
                }
            }
            */
            /*
            Console.WriteLine("Első szám: ");
            float elso = float.Parse(Console.ReadLine());
            Console.WriteLine("Második szám: ");
            float masodik = float.Parse(Console.ReadLine());
            Console.WriteLine("Harmadik szám: ");
            float harmadik = float.Parse(Console.ReadLine());
            Console.WriteLine(oszt_szor(elso, masodik, harmadik));
            */
            Console.Write("Számok: ");
            string aszoveg = Console.ReadLine();
            string[] feldarabolva = aszoveg.Split(' ');
            int[] szamok = new int[feldarabolva.Length];
            for (int i = 0; i < feldarabolva.Length; i++)
            {
                szamok[i] = int.Parse(feldarabolva[i]);
            }
            int db = ptl_szama(szamok.ToList());


        }
    }
}

using System;

namespace Games
{
    class Program
    {
        static void Main(string[] args)
        {
            int releaseJaar1 = DateTime.Now.Year - 1; // 1 jaar geleden
            int releaseJaar2 = DateTime.Now.Year - 2; // 2 jaar geleden
            Game g1 = new Game("Just Cause 3", releaseJaar1, 49.98);
            Game g2 = new Game("Need for Speed: Rivals", releaseJaar2, 45.99);
            Game g3 = new Game("Need for Speed: Rivals", releaseJaar2, 45.99);
            Persoon p1 = new Persoon("Eric", 200);
            Persoon p2 = new Persoon("Hans", 55);
            Persoon p3 = new Persoon("Arno", 185);

            Console.WriteLine("p1 koopt g1:" + (p1.koop(g1) ? "" : " niet") + " gelukt");
            Console.WriteLine("p1 koopt g2:" + (p1.koop(g2) ? "" : " niet") + " gelukt");
            Console.WriteLine("p1 koopt g3:" + (p1.koop(g3) ? "" : " niet") + " gelukt");
            Console.WriteLine("p2 koopt g2:" + (p2.koop(g2) ? "" : " niet") + " gelukt");
            Console.WriteLine("p2 koopt g1:" + (p2.koop(g1) ? "" : " niet") + " gelukt");
            Console.WriteLine("p3 koopt g3:" + (p3.koop(g3) ? "" : " niet") + " gelukt");           

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3); 

            Console.WriteLine("p1 verkoopt g1 aan p3:" + (p1.verkoop(g1, p3) ? "" : " niet") + " gelukt");
            Console.WriteLine("p2 verkoopt g2 aan p3:" + (p2.verkoop(g2, p3) ? "" : " niet") + " gelukt");
            Console.WriteLine("p2 verkoopt g1 aan p1:" + (p2.verkoop(g1, p1) ? "" : " niet") + " gelukt");

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3); 
        }
    }
}

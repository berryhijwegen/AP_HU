using System;

namespace Zwembad
{
    class Program
    {
        static void Main(string[] args)
        {
            Zwembad z1 = new Zwembad(2.0, 5.5, 1.5);

            Console.WriteLine("BREEDTE: " + z1.Breedte);
            Console.WriteLine("LENGTE: " + z1.Lengte);
            Console.WriteLine("DIEPTE: " + z1.Diepte);
            Console.WriteLine("BEREKENDE INHOUD: " + z1.inhoud());
            Console.WriteLine("");

            Zwembad z2 = new Zwembad();
            z2.Breedte = 2.5;
            z2.Lengte = 100.0;
            z2.Diepte = 2.0;

            Console.WriteLine("GEGEVENS ZWEMBAD: " + z2.toString());
            Console.WriteLine("BEREKENDE INHOUD: " + z2.inhoud());
        }
    }
}

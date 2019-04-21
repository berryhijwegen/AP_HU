using System;

namespace Autohuur
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoHuur ah1 = new AutoHuur();
            Console.WriteLine("Eerste autohuur:\n" + ah1);
            Klant k = new Klant("Mijnheer de Vries");
            k.Korting = 10.0;
            ah1.Huurder = k;
            Console.WriteLine("Eerste autohuur:\n" + ah1);
            Auto a1 = new Auto("Peugeot 207", 50);
            ah1.GehuurdeAuto = a1;
            ah1.AantalDagen = 4;
            Console.WriteLine("Eerste autohuur:\n" + ah1);
            AutoHuur ah2 = new AutoHuur();
            Auto a2 = new Auto("Ferrari", 3500);
            ah2.GehuurdeAuto = a2;
            ah2.Huurder = k;
            ah2.AantalDagen = 1;
            Console.WriteLine( "Tweede autohuur:\n" + ah2);
            Console.WriteLine( "Gehuurd: " + ah1.GehuurdeAuto);
            Console.WriteLine( "Gehuurd: " + ah2.GehuurdeAuto);
        }
    }
}

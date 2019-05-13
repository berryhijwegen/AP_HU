using System;

namespace Huisbaas
{
    class Program
    {
        static void Main(string[] args)
        {
            Huis h1 = new Huis("Nijenoord 1", 1970);
            Persoon p1 = new Persoon("Ronald Plasterk", 52);
            h1.Huisbaas = p1;
            p1.naam = "abca";
            Console.WriteLine(h1);
            Console.WriteLine();

            Huis h2 = new Huis("Vredenburg", 1991);
            Persoon p2 = new Persoon("Annie Brouwers", 59);
            h2.Huisbaas = p2;
            Console.WriteLine(h2);
            Console.WriteLine();
            Console.WriteLine("Huisbaas 1: " + h1.Huisbaas);
            Console.WriteLine("Huisbaas 2: " + h2.Huisbaas);
        }
    }
}

using System;

namespace Geldbedragen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MoneyUtils.bedrag("GBP", 3.1431592));
            Console.WriteLine(MoneyUtils.bedrag("USD", 3.1431592, 1));
            Console.WriteLine("Count: " + MoneyUtils.Count);
        }
    }
}

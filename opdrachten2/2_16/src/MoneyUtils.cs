using System;

namespace Geldbedragen
{
    class MoneyUtils
    {
        private static int count;

        public static string bedrag(string currencyCode, double bdrg){
            count++;
            return bedrag(currencyCode, bdrg, 2);
        }

        public static string bedrag(string currencyCode, double bdrg, int precisie){
            count++;
            return String.Format("{0} {1:N" + precisie + "}", CurrencyCodeMapper.GetSymbol(currencyCode), bdrg);
        }

        public static int Count {get {return count;}}
    }
}

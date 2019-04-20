using System;

namespace Huisbaas
{
    class Huis
    {
        private string adres;
        private int bouwjaar;
        private Persoon huisbaas;

        public Persoon Huisbaas {get {return huisbaas;} set {huisbaas = value;}}

        public Huis(string adr, int bwjr){
            adres = adr;
            bouwjaar = bwjr;
        }

        public override string ToString(){
            return String.Format("huis {0} is gebouwed in {1}\nen heeft huisbaas {2}.", adres, bouwjaar, huisbaas);
        }
    }
}

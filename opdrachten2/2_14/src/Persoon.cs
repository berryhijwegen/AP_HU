using System;

namespace Huisbaas
{
    class Persoon
    {
        private string naam;
        private int leeftijd;

        public Persoon(string nm, int lft){
            naam = nm;
            leeftijd = lft;
        }
        
        public override string ToString(){
            return String.Format("{0}; leeftijd {1} jaar", naam, leeftijd);
        }
    }
}

using System;

namespace Games
{
    class Game
    {
        private string naam;
        private int releaseJaar;
        private double nieuwprijs;

        public Game(string nm, int rJ, double nwpr)
        {
            naam = nm;
            releaseJaar = rJ;
            nieuwprijs = nwpr;
        }

        public string Naam {get {return naam;}}

        public double huidigeWaarde(){
            return nieuwprijs * Math.Pow(0.7, DateTime.Now.Year - releaseJaar);
        }

        public override Boolean Equals(Object andereObject){
            Boolean result = false;
            if(andereObject is Game){
                Game gameObject = (Game) andereObject;
                if(gameObject.naam == this.naam && gameObject.releaseJaar == this.releaseJaar && gameObject.nieuwprijs == this.nieuwprijs){
                    result = true;
                }
            }
            return result;
        }

        public override string ToString(){
            return String.Format("{0}, uitgegeven in {1}; nieuwprijs: €{2:N2} nu voor: €{3:N2}", naam, releaseJaar, nieuwprijs, huidigeWaarde());
        }
    }
}

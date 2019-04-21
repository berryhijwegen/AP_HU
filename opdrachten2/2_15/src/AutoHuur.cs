using System;

namespace Autohuur
{
    class AutoHuur
    {
        private int aantalDagen;
        private Auto gehuurdeAuto;
        private Klant huurder;
        
        public AutoHuur(){

        }

        public int AantalDagen      {set {aantalDagen = value;}}
        public Auto GehuurdeAuto    {set {gehuurdeAuto = value;} get {return gehuurdeAuto;} }
        public Klant Huurder        {set {huurder = value;} get {return huurder;} }

        public double totaalPrijs(){
            if(aantalDagen != 0){
                return gehuurdeAuto.PrijsPerDag * aantalDagen * (1-(huurder.Korting/100));
            }
            return 0;
        }

        public override string ToString(){
            string s = "";
            if(gehuurdeAuto != null){
                s += String.Format("autotype: {0}", gehuurdeAuto);
            }
            else {
                s += "er is geen auto bekend\n";
            }

            if(Huurder != null){
                s += String.Format("op naam van: {0}", huurder);
            }
            else {
                s += "er is geen huurder bekend";
            }
            s += String.Format("\naantal dagen: {0} en dat kost {1}\n", aantalDagen, totaalPrijs());
            return s;
        }
    }
}

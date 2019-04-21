using System;

namespace Autohuur
{
    class Klant
    {
        private string naam;
        private double kortingspercentage;

        public Klant(string nm){
            naam = nm;
        }

        public double Korting {set {kortingspercentage = value;} get {return kortingspercentage;}}

        public override string ToString(){
            return String.Format("{0} (korting: {1:0.00}%)", naam, kortingspercentage);
        }
    }
}

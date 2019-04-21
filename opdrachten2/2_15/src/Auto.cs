using System;

namespace Autohuur
{
    class Auto
    {
        private string type;
        private double prijsPerDag;

        public Auto(string tp, double prPd){
            type = tp;
            prijsPerDag = prPd;
        }

        public double PrijsPerDag {set {prijsPerDag = value;} get {return prijsPerDag;}}

        public override string ToString(){
            return String.Format("{0} met prijs per dag: {1:0.00}\n", type, prijsPerDag);
        }
    }
}

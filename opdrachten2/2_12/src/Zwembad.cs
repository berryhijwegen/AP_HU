using System;

namespace Zwembad
{
    class Zwembad {
        private double breedte;
        private double lengte;
        private double diepte;

        public double Breedte {get {return breedte;} set {breedte = value;}}
        public double Lengte {get {return lengte;} set {lengte = value;}}
        public double Diepte {get {return diepte;} set {diepte = value;}}
        public Zwembad(double br, double lgt, double dpt){
            breedte = br;
            lengte = lgt;
            diepte = dpt;
        }
        public Zwembad(){

        }

        public double inhoud(){
            return breedte * lengte * diepte;
        }

        public string toString(){
            string s = "Dit zwembad ";
            if(lengte != 0.0){
                s += String.Format("heeft een lengte van {0} meter, ", lengte);
            }
            if(breedte != 0.0){
                s += String.Format("een breedte van {0} meter, ", breedte);
            }
            if(diepte != 0.0){
                s += String.Format("en een breedte van {0} meter, ", diepte);
            }
            return s.Substring(0, s.Length -2) + ".";
        }
    }
}
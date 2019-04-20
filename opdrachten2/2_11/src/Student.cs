using System;
using System.Collections.Generic;

namespace StudentGegevens
{
    struct Student
    {
        private string naam;
        private int leeftijd;
        private List<int> cijferlijst;
        private string huisdier;
        public List<int> cijfers {get {return cijferlijst;}}

        public Student(string nm, int lft, List<int> cfrlst, string hsdr){
            naam = nm;
            leeftijd = lft;
            cijferlijst = cfrlst;
            huisdier = hsdr;
        }
        public Student(string nm, int lft, List<int> cfrlst){
            naam = nm;
            leeftijd = lft;
            cijferlijst = cfrlst;
            huisdier = string.Empty;
        }
        public Student(string nm, int lft){
            naam = nm;
            leeftijd = lft;
            cijferlijst = new List<int>();
            huisdier = string.Empty;
        }

        public void voegCijferToe(int cijfer){
            cijferlijst.Add(cijfer);
        }

        public string toString(){
            string s = String.Format("Student {0} ({1}) heeft ", naam, leeftijd);
            if(cijferlijst.Count == 0){
                return s + "nog geen cijfers.";
            }
            else {
                s += "de volgende cijfers: ";
                foreach (int cijfer in cijferlijst)
                {
                    s += cijfer + ", ";
                }
                return s.Substring(0, s.Length-2) + ".";
            }
        }
    }
}

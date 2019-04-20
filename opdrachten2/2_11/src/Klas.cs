using System;
using System.Collections.Generic;

namespace StudentGegevens
{
    struct Klas
    {
        private string naam;
        private List<Student> alleStudenten;
        private List<Docent> alleDocenten;

        public Klas(string nm){
            naam = nm;
            alleStudenten = new List<Student>();
            alleDocenten = new List<Docent>();
        }

        public void voegStudentToe(Student student){
            alleStudenten.Add(student);
        }

        public void voegDocentToe(Docent docent){
            alleDocenten.Add(docent);
        }

        public float berekenGemiddelde(){
            float totaalPunten = 0;
            float totaalCijfers = 0;
            foreach (Student student in alleStudenten)
            {
                List<int> cijferlijst = student.cijfers;
                foreach (int cijfer in cijferlijst)
                {
                    totaalPunten += cijfer;
                    totaalCijfers++;
                }
            }
            return totaalPunten / totaalCijfers;
        }

        public string toString(){
            return String.Format("De klas {0} heeft een gemiddelde van een {1:0.#}.", naam, berekenGemiddelde());
        }
    }
}

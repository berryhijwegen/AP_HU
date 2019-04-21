using System;
using System.Collections.Generic;

namespace Games
{
    class Persoon
    {
        private string naam;
        private double budget;
        private List<Game> mijnGames;

        public Persoon(string nm, double bud){
            naam = nm;
            budget = bud;
            mijnGames = new List<Game>();
        }

        public Boolean koop(Game g){
            Boolean result = false;
            if(!mijnGames.Contains(g) && budget >= g.huidigeWaarde()){
                budget -= g.huidigeWaarde();
                mijnGames.Add(g);
                result = true;
            }
            return result;
        }

        public Boolean verkoop(Game g, Persoon koper){
            Boolean result = false;
            if(mijnGames.Contains(g) && koper.koop(g)){
                mijnGames.Remove(g);
                budget += g.huidigeWaarde();
                result = true;
            }
            return result;
        }

        public override string ToString(){
            string s = String.Format("{0} heeft een budget van €{1:N2} en bezit de volgende games:\n",naam, budget);
            foreach (Game game in mijnGames){
                s+= game + "\n";
            }
            return s;
        }
    }
}

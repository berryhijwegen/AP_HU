using System;
using System.Globalization;

namespace MarkovChainGenerator
{
    public class Transition
    {
        private int s;
        private int d;
        private double chance;

        public int getD() => this.d;

        public void setD(int d) => this.d = d;

        public int getS() => this.s;

        public void setS(int s) => this.s = s;

        public double getChance() => this.chance;

        public void setChance(double chance) => this.chance = chance;

        public override string ToString(){
            return String.Format("Kans: {0,3}, uitkomst: s = {1}, d = {2}", chance.ToString("0.00", CultureInfo.GetCultureInfo("en-US")), s, d);
        }
    }
}
using System;
using System.Collections;

namespace MarkovChainGenerator
{
    public class State
    {
        public int stateNum;
        public ArrayList allTransitions = new ArrayList();

        public State(int stateNum, ArrayList allTransactions)
        {
            this.stateNum = stateNum;
            this.allTransitions = allTransactions;
        }

        public State(){

        }

        public int getStateNum() {
		    return this.stateNum;
        }

        public void setStateNum(int stateNum) {
            this.stateNum = stateNum;
        }

        public ArrayList getAllTransitions() {
            return this.allTransitions;
        }

        public void setAllTransitions(ArrayList allTransitions) {
            this.allTransitions = allTransitions;
        }

        public void addTransition(Transition transition){
            this.allTransitions.Add(transition);
        }

        public Boolean totalChanceValid(){
            double total = 0;
            foreach (Transition item in this.allTransitions)
            {
                total += item.getChance();
            }

            return total == 1.0;
        }

        public Transition getRandomTransition(){
            Random r = new Random();
            double diceRoll = r.NextDouble();

            double cumulative = 0.0;
            for (int i = 0; i < allTransitions.Count; i++)
            {
                Transition t = (Transition) allTransitions[i];
                cumulative += t.getChance();
                if (diceRoll < cumulative)
                {
                    return t;
                }
            }
            return null;
        }

        public override string ToString(){
            string s = "State number: " + stateNum + "\n";
            foreach (Transition t in this.allTransitions)
            {
                s += String.Format("{0}\n", t);
            }

            return s;
        }
    }   
}

using System;
using System.Collections.Generic;

namespace MarkovChainGenerator
{
    class MarkovChain
    {
        private List<State> path;
    
        public MarkovChain(){
            path = new List<State>();
        }

        public static MarkovChain generateMarkovChainFromPRISM(string path){
            string[] states = System.IO.File.ReadAllLines(Environment.CurrentDirectory + "\\" +  path);
            
            MarkovChain markovChain = new MarkovChain();
            foreach (string prismState in states)
            {
                State generatedState = PRISMConverter.PRISMToState(prismState);
                markovChain.addState(generatedState);
            }
            return markovChain;
        }

        public void addState(State state){
            path.Add(state);
        }

        public State getStateByNum(int num){
            foreach (State state in path)
            {
                if(state.stateNum == num){
                    return state;
                }
            }
            return null;
        }
        
        public string generatePath(){
            int result = 0;
            int currentState = 0;
            string pathString = "";
            int lastState = 0; 
            Transition t;
            while(true){
                int previousState = currentState;
                pathString += getStateByNum(previousState).stateNum + ", ";
                t = getStateByNum(currentState).getRandomTransition();
                if(t.getD() != 0){
                    result = t.getD();
                }
                if(t.getS() == currentState && t.getChance() == 1.0){ 
                    lastState = currentState;
                    break;
                }
                else {
                    currentState = t.getS();
                }
            }
            return String.Format("{0,-25} uitkomst: s = {1}, d = {2}", pathString, lastState, result);
        }

        public override string ToString(){
            string s = "States:\n";
            foreach (State state in this.path)
            {
                s += "  " + state + "\n";
            }

            return s;
        }       
    }
}

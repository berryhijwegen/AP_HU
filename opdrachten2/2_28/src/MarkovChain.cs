using System;
using System.Collections.Generic;

namespace MarkovChainPRISM
{
    class MarkovChain
    {
        private List<State> path;
    
        public MarkovChain(){
            path = new List<State>();
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
            Random random = new Random();
            int result = 0;
            int currentState = 0;
            string pathString = "";
            int lastState = 0;
            while(result == 0){
                int num = random.Next(2);
                int previousState = currentState;
                pathString += getStateByNum(previousState).stateNum + ", ";
                currentState = (num == 0) ? getStateByNum(currentState).option0 : getStateByNum(currentState).option1;
                if(currentState == 0){
                    result = (num == 0) ? getStateByNum(previousState).result0 : getStateByNum(previousState).result1;
                    lastState = getStateByNum(previousState).stateNum;
                }
            }
            return String.Format("{0,6} uitkomst: s = {1}, d = {2}", pathString, lastState, result);
        }       
    }
}

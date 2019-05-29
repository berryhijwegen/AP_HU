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
            State currentState = getStateByNum(0);
            string pathString = "";
            int lastState = 0;
            while(result == 0){
                int num = random.Next(2);
                State previousState = currentState;
                pathString += currentState.stateNum + ", ";
                currentState = (num == 0) ? currentState.option0 : currentState.option1;
                if(currentState == null){
                    result = (num == 0) ? previousState.result0 : previousState.result1;
                    lastState = previousState.stateNum;
                }
            }
            return String.Format("{0,6} uitkomst: s = {1}, d = {2}", pathString, lastState, result);
        }       
    }
}

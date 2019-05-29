using System;
using System.Collections.Generic;

namespace DiceGenerator
{
    class Dice
    {
        private List<State> allStates;
    
        public Dice(){
            allStates = new List<State>();
        }

        public void generateDiceFromPRISM(string filename){

        }

        public void addState(State state){
            allStates.Add(state);
        }

        public State getStateByNum(int num){
            foreach (State state in allStates)
            {
                if(state.stateNum == num){
                    return state;
                }
            }
            return null;
        }

        public void rollDice(){
            Random random = new Random();
            int result = 0;
            State currentState = getStateByNum(0);
            while(result == 0){
                int num = random.Next(2);
                State previousState = currentState;
                currentState = (num == 0) ? currentState.option0 : currentState.option1;
                if(currentState == null){
                    result = (num == 0) ? previousState.result0 : previousState.result1;
                }
            }
            Console.WriteLine(result);
        }       
    }
}

using System;

namespace DiceGenerator
{
    class State
    {
        public int stateNum;
        public State option0;
        public State option1;
        public int result0;
        public int result1;

        public State(int stnm, State opt0 = null, State opt1 = null, int res0 = 0, int res1 = 0){
            stateNum = stnm;
            option0 = opt0;
            option1 = opt1;
            result0 = res0;
            result1 = res1;
        }
    }   
}

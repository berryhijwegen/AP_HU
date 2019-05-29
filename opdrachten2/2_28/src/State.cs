using System;

namespace MarkovChainPRISM
{
    class State
    {
        public int stateNum;
        public int option0;
        public double chanceOption0;
        public int option1;
        public double chanceOption1;
        public int result0;
        public double chanceResult0;
        public int result1;
        public double chanceResult1;
        
        public State(){

        }

        public int getStateNum() {
            return this.stateNum;
        }

        public void setStateNum(int stateNum) {
            this.stateNum = stateNum;
        }

        public int getOption0() {
            return this.option0;
        }

        public void setOption0(int option0) {
            this.option0 = option0;
        }

        public double getchanceOption0() {
            return this.chanceOption0;
        }

        public void setchanceOption0(double chanceOption0) {
            this.chanceOption0 = chanceOption0;
        }

        public int getOption1() {
            return this.option1;
        }

        public void setOption1(int option1) {
            this.option1 = option1;
        }

        public double getchanceOption1() {
            return this.chanceOption1;
        }

        public void setchanceOption1(double chanceOption1) {
            this.chanceOption1 = chanceOption1;
        }

        public int getResult0() {
            return this.result0;
        }

        public void setResult0(int result0) {
            this.result0 = result0;
        }

        public double getchanceResult0() {
            return this.chanceResult0;
        }

        public void setchanceResult0(double chanceResult0) {
            this.chanceResult0 = chanceResult0;
        }

        public int getResult1() {
            return this.result1;
        }

        public void setResult1(int result1) {
            this.result1 = result1;
        }

        public double getchanceResult1() {
            return this.chanceResult1;
        }

        public void setchanceResult1(double chanceResult1) {
            this.chanceResult1 = chanceResult1;
        }

        public string toString(){
            return "State number: " + stateNum + "\n" + 
                   "option 0: " + option0 + " with chance: " + chanceOption0 + "\n" + 
                   "option 1: " + option1 + " with chance: " + chanceOption1 + "\n" + 
                   "result 0: " + result0 + " with chance: " + chanceResult1 + "\n" + 
                   "result 1: " + result1 + " with chance: " + chanceResult1 + "\n";
        }
    }   
}

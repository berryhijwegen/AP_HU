using System;
using System.Collections.Generic;
using System.IO;  
using System.Globalization;
using System.Collections;
using System.Text.RegularExpressions;

namespace MarkovChainGenerator
{
    public static class PRISMConverter
    {
        public static void addSorD(string element, Transition t){
            if(element.Contains('s')){
                t.setS(Int32.Parse(element[4..element.IndexOf(')')]));
            }
            else if(element.Contains('d')){
                t.setD(Int32.Parse(element[4..element.IndexOf(')')]));
            }
            else {
                throw new System.Exception("Syntax error");
            }
        }

        // Remove spacing and split into properties
        public static string[] splitString(string s){
            string stateNoSpace = s[0..s.Length -1].Replace(" ", String.Empty);
            return stateNoSpace.Split(new[] { "->", "+" }, StringSplitOptions.None);
        }

        public static State PRISMToState(string prism){
            State currentState = new State();

            string[] stateProperties = splitString(prism);
            
            // Get first property and set as stateNum of current state object
            int stateNum = Int32.Parse(stateProperties[0][2..stateProperties[0].Length]);
            currentState.setStateNum(stateNum);
            
            for (int i = 1; i < stateProperties.Length; i++)
            {
                Transition currentTransition = new Transition();                
                
                // for every state with > 1 option
                string[] options = stateProperties[i].Split(':');     
                for (int j = 0; j < options.Length; j++)
                {
                    if(options.Length == 1){
                        addSorD(options[j], currentTransition);
                        currentTransition.setChance(1.0);
                    }
                    else if(options.Length > 1){
                        if(options[j].Contains('.')){
                            currentTransition.setChance(Double.Parse(options[j], CultureInfo.InvariantCulture));
                        }
                        else if(!options[j].Contains('&')){
                            addSorD(options[j], currentTransition);
                        }
                        else {
                            string[] statesInOptions = options[j].Split('&');
                            for(int k = 0; k < statesInOptions.Length; k++){
                                addSorD(statesInOptions[k], currentTransition);
                            }
                        }   
                    }
                }
                currentState.addTransition(currentTransition);
            }

            if(!currentState.totalChanceValid()){
                throw new System.Exception("Chances don't add up to 100%");
            }

            return currentState;
        }
    }
}
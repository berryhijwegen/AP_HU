using System;
using System.Collections.Generic;
using System.IO;  
using System.Globalization;
using System.Collections;
using System.Text.RegularExpressions;

namespace MarkovChainPRISM
{
    public static class PRISMConverter
    {
        public static State PRISMToState(string prism){
            State currentState = new State();

            // Delete spaces from string
            string stateNoSpace = prism[0..prism.Length -1].Replace(" ", String.Empty);

            // Split all properties of the state
            string[] stateProperties = stateNoSpace.Split(new[] { "->", "+" }, StringSplitOptions.None);
            
            // Get first property and set as stateNum of current state object
            int stateNum = Int32.Parse(stateProperties[0][2..stateProperties[0].Length]);
            currentState.setStateNum(stateNum);

            for (int i = 1; i < stateProperties.Length; i++)
            {
                // if there is only one option assign to object and set chance equal to 1.0
                if(stateProperties.Length == 2){
                    currentState.result0 = Int32.Parse(stateProperties[i][4..stateProperties[i].IndexOf(')')]);
                    currentState.chanceResult0 = 1.0;
                }
                
                // for every state with > 1 option
                else {
                    string[] options = stateProperties[i].Split(':');     
                    for (int j = 0; j < options.Length; j++)
                    {
                        // skip all chances, those are used when iterated over the possible states
                        if(options[j].Contains(".")){
                            continue;
                        }

                        // for the possible states
                        else if(options[j].Contains("=")){
                            
                            // get previous element. This is the chance.
                            double chance = Double.Parse(options[j - 1], CultureInfo.InvariantCulture);

                            // check if there is more than '=' in the option, this means there is a outcome in this option.
                            if(Regex.Matches(options[j], "=").Count > 1){
                                // get part of string where the number of outcome is
                                string step = options[j][options[j].IndexOf('d')-1..options[j].Length];
                                int result = Int32.Parse(step[step.IndexOf('d') + 3..step.IndexOf(')')]);
                                if(currentState.result0 == 0 && currentState.option0 == 0){
                                    currentState.result0 = result;
                                    currentState.chanceResult0 = currentState.result0 != 0 ? chance : 0.0;
                                }

                                else {
                                    currentState.result1 = result;
                                    currentState.chanceResult1 = chance;
                                }
                            }

                            else {
                                if(options[j].Contains('s')){
                                    
                                    int option = Int32.Parse(options[j][options[j].IndexOf('s') + 3..options[j].IndexOf(')')]);
                                    if(currentState.result0 == 0 && currentState.option0 == 0){
                                        currentState.option0 = option;
                                        currentState.chanceOption0 = chance;
                                    }

                                    else {
                                        currentState.option1 = option;
                                        currentState.chanceOption1 = chance;
                                    }
                                }

                            }
                        }

                        else {
                            throw new System.Exception("Wrong Syntax. String does not include '='.");
                        }
                    }
                }              
            }

            if(currentState.chanceOption0 + currentState.chanceOption1 + currentState.chanceResult0 + currentState.chanceResult1 != 1.0){
                throw new System.Exception("All chances combined do not equal 1.0.");
            }

            return currentState;
        }
    }
}
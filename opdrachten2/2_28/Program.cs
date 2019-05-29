using System;
using System.IO;  
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MarkovChainPRISM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            MarkovChain markovChain = new MarkovChain();
            string[] states = System.IO.File.ReadAllLines(Environment.CurrentDirectory + "\\" +  args[0]);
            
            foreach (string state in states)
            {
                Console.WriteLine("---");
                State currentState = new State();

                string stateNoSpace = state.Substring(0, state.Length -1).Replace(" ", String.Empty);
                string[] stateProperties = stateNoSpace.Split(new[] { "->", "+" }, StringSplitOptions.None);
                
                int stateNum = Int32.Parse(stateProperties[0].Substring(2, stateProperties[0].Length - 2));
                currentState.setStateNum(stateNum);

                Dictionary<int, double> chancesAndPositions = new Dictionary<int, double>();
                for (int i = 1; i < stateProperties.Length; i++)
                {
                    if(stateProperties.Length == 2){
                        chancesAndPositions.Add(Int32.Parse(stateProperties[i].Substring(4, stateProperties[1].Length -5)), 1.0);
                    }
                    else {
                        string[] options = stateProperties[i].Split(':');     
                        for (int j = 0; j < options.Length; j++)
                        {
                            if(options[j].Contains(".")){
                            }
                            else if(options[j].Contains("=")){
                                double chance = Double.Parse(options[j - 1], CultureInfo.InvariantCulture);
                                if(Regex.Matches(options[j], "=").Count > 1){
                                    if(currentState.result0 == 0 && currentState.option0 == 0){
                                        string step = options[j][options[j].IndexOf('d')-1..options[j].Length];
                                        currentState.result0 = Int32.Parse(step[step.IndexOf('d') + 3..step.IndexOf(')')]);
                                        currentState.chanceResult0 = currentState.result0 != 0 ? chance : 0.0;
                                    }
                                    else {
                                        string step = options[j][options[j].IndexOf('d')-1..options[j].Length];
                                        currentState.result1 = Int32.Parse(step[step.IndexOf('d') + 3..step.IndexOf(')')]);
                                        currentState.chanceResult1 = chance;
                                    }
                                }
                                else {
                                    if(options[j].Contains('s')){
                                        if(currentState.result0 == 0 && currentState.option0 == 0){
                                            currentState.option0 = Int32.Parse(options[j][options[j].IndexOf('s') + 3..options[j].IndexOf(')')]);
                                            currentState.chanceOption0 = chance;
                                        }
                                        else {
                                            currentState.option1 = Int32.Parse(options[j][options[j].IndexOf('s') + 3..options[j].IndexOf(')')]);
                                            currentState.chanceOption1 = chance;
                                        }
                                    } 
                                }
                            }
                        }
                    }              
                }
                Console.WriteLine(currentState.toString());
            }
        }
    }
}

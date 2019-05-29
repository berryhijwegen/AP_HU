using System;
using System.IO;  
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _2_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, object> allStates = new Dictionary<int, object>();
            string[] states = System.IO.File.ReadAllLines(@"C:\Users\berry\OneDrive\Bureaublad\School\Semester_2\AP\code\opdrachten2\2_28\prism.txt");
            
            foreach (string state in states)
            {
                Dictionary<string, object> currentStateData = new Dictionary<string, object>();

                string stateNoSpace = state.Substring(0, state.Length -1).Replace(" ", String.Empty);
                string[] stateProperties = stateNoSpace.Split(new[] { "->", "+" }, StringSplitOptions.None);
                
                int stateNum = Int32.Parse(stateProperties[0].Substring(2, stateProperties[0].Length - 2));
                currentStateData.Add("stateNum", stateNum);

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
                            double chance;
                            if(options[j].Contains(".")){
                               chance = Double.Parse(options[j], CultureInfo.InvariantCulture);
                            }
                            else if(options[j].Contains("=")){
                                if(Regex.Matches(options[j], "=").Count > 1){

                                }
                            }
                            Console.WriteLine(options[j]);
                        }
                    }                    
                }
                // Console.WriteLine("-----------");  

                // allStates.Add(stateNum, stateData);     
            }
        }
    }
}

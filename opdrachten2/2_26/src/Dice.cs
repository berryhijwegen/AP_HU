using System;
using System.Collections.Generic;

namespace DiceGenerator
{
    class Dice
    {
        public static void rollDice(){
            Random random = new Random();
            int count = 0;
            while(count < 3){
                int state = 0, result = 0;
                List<int> previousPositions =  new List<int>();
                while(result == 0){
                    int num = random.Next(2);
                    if(num == 0){
                        previousPositions.Add(state);
                        switch(state){
                            case 0:
                                state = 1;
                                break;
                            case 1:
                                state = 3;
                                break;
                            case 2:
                                state = 5;
                                break;
                            case 3:
                                state = 1;
                                break;
                            case 4:
                                result = 2;
                                break;
                            case 5:
                                result = 4;
                                break;
                            case 6:
                                result = 6;
                                break;
                        }
                    }
                    else if(num == 1){
                        previousPositions.Add(state);
                        switch(state){
                            case 0:
                                state = 2;
                                break;
                            case 1:
                                state = 4;
                                break;
                            case 2:
                                state = 6;
                                break;
                            case 3:
                                result = 1;
                                break;
                            case 4:
                                result = 3;
                                break;
                            case 5:
                                result = 5;
                                break;
                            case 6:
                                state = 2;
                                break;
                        }
                    }
                }
                count++;
                Console.Write(String.Format("pad {0}: ", count));
                string s = "";
                foreach (int num in previousPositions)
                {
                    s += num + ",";
                }
                Console.WriteLine(s.Substring(0,length - 1));
                Console.WriteLine(String.Format("\nUitkomst: {0}\n", result));
            }
        }
    }
}

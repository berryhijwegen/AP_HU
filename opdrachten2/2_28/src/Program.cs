// using System;

// namespace MarkovChainPRISM
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             MarkovChain markovChain = new MarkovChain();
            
//             State state2 = new State(2, opt0: 5, opt1: 6);
//             State state6 = new State(6, res0: 7, res1: 8);
//             State state5 = new State(5, res0: 5, res1: 6);            
//             State state4 = new State(4, res0: 3, res1: 4);
//             State state3 = new State(3, res0: 1, res1: 2);
//             State state1 = new State(1, opt0: 3, opt1: 4);
//             State state0 = new State(0, opt0: 1, opt1: 2);

//             markovChain.addState(state0);
//             markovChain.addState(state1);
//             markovChain.addState(state2);
//             markovChain.addState(state3);
//             markovChain.addState(state4);
//             markovChain.addState(state5);
//             markovChain.addState(state6);

//             for (int i = 0; i < 99; i++)
//             {
//                 Console.Write("pad " + (i+1) + ": ");
//                 Console.WriteLine(markovChain.generatePath());
//             }
//         }
//     }
// }

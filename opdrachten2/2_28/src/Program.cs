using System;

namespace MarkovChainPRISM
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 99; i++)
            {
                MarkovChain markovChainFromPRISM = MarkovChain.generateMarkovChainFromPRISM(args[0]);
                Console.Write("pad " + (i+1) + ": ");
                Console.WriteLine(markovChainFromPRISM.generatePath());
            }
        }
    }
}

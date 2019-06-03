using System;

namespace MarkovChainGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            MarkovChain markovChainFromPRISM = MarkovChain.generateMarkovChainFromPRISM(args[0]);

            Console.WriteLine(markovChainFromPRISM);
            for (int i = 0; i < 99; i++)
            {
                Console.Write("pad " + (i+1) + ": ");
                Console.WriteLine(markovChainFromPRISM.generatePath());
            }
        }
    }
}

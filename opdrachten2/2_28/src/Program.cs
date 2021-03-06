﻿using System;

namespace MarkovChain
{
    class Program
    {
        static void Main(string[] args)
        {
            MarkovChain markovChainFromPRISM = MarkovChain.generateMarkovChainFromPRISM(args[0]);

            for (int i = 0; i < 99; i++)
            {
                Console.Write("pad " + (i+1) + ": ");
                Console.WriteLine(markovChainFromPRISM.generatePath());
            }
        }
    }
}

﻿using System;

namespace VectorControle
{
    class Program
    {
        static void Main(string[] args)
        {
            VectorControle vectorControle = new VectorControle();
            Console.WriteLine(vectorControle.isValid(new Boolean[]{true,false,true, false, false, false, false}));
        }
    }
}

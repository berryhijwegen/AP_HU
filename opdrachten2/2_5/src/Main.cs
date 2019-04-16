using System;

namespace Fibonacci
{
    class main
    {
        static void Main(string[] args) {
            Fibonacci fibonacci = new Fibonacci();
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(fibonacci.getFibonacci(i));
            }
        }
    }
}

using System;

namespace Fibonacci
{
    class Fibonacci
    {
        public int getFibonacci(int n){
            if(n > 1){
                return getFibonacci(n - 1) + getFibonacci(n-2);
            }
            else {
                return n;
            }
        }   
    }
}
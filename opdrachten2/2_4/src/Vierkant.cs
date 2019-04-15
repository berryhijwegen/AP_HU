using System;

namespace Vierkant
{
    class Vierkant
    {
        public void maakVierkant(int size){
            for(int i = 0; i < size; i++){
                for(int x = 0; x < size; x++){
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
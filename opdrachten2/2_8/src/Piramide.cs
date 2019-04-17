using System;

namespace Piramide
{
    class Piramide
    {
        private int size;

        public Piramide(int s){
            size = s;
        }

        public void maakPiramide()
        {
            for (int i = 1; i <= size; i++)
            {
                string s = "";
                for (int x = 0; x < i; x++)
                {
                    s +="*";
                }
                Console.WriteLine(string.Format("{0,"+ size + "}", s));
            }
            
            for (int i = size; i > 1; i--)
            {
                string s = "";
                for(int x = i - 1; x > 0; x--)
                {
                    s +="*";
                }
                Console.WriteLine(string.Format("{0,"+ size + "}", s));
            }
        }
    }
}

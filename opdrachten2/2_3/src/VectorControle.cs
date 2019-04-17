using System;

namespace VectorControle
{
    class VectorControle
    {
        public Boolean isValid(Boolean[] booleans){
            int truecount = 0;
            int falsecount = 0;
            for (int i = 0; i < booleans.Length; i++)
            {
                if(booleans[i]){
                    truecount += 1;
                }
                else {
                    falsecount += 1;
                }
            }
            
            return truecount > falsecount && falsecount < 13;
        }
    }
}
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
                switch(booleans[i]){
                    case true:
                        truecount += 1;
                        break;
                    case false:
                        falsecount += 1;
                        break;
                }

            }
            
            if(truecount > falsecount && falsecount < 13){
                    return true;
            }
            return false;
        }
    }
}
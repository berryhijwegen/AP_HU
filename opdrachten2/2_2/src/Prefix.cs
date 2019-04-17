using System;

namespace Prefix
{
    class prefix
    {
        public Boolean isPrefix(string word, string prefix){
            if(prefix.Length > word.Length){
                return false;
            }
            for (int i = 0; i < prefix.Length; i++)
            {
                if(word[i] != prefix[i]){
                    return false;
                }
            }
            return true;
        }
    }
}
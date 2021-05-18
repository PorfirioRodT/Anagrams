using System;
using System.Linq;

namespace AreAnagrams
{

    public class Program
    {

        public bool IsAnAnagram(string word1, string word2){

            if (word1 is null || word2 is null)
            {

                throw new ArgumentNullException();
                
            }else{
                
                var string1 = word1.ToLower().ToArray();
                var string2 = word2.ToLower().ToArray();

                Array.Sort(string1);
                Array.Sort(string2);

                return new string(string1) == new string(string2);

            }

        }
        
    }
    
}
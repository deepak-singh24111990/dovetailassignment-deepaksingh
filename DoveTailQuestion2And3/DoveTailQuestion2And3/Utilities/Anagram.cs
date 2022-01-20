
namespace DoveTailQuestion2And3.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Anagram
    {
        public bool CheckAnagram(string firstString, string secondString)
        {
            if (firstString == null || secondString == null)
            {
                return false;
            }
            if (firstString == string.Empty || secondString == string.Empty)
            {
                return false;
            }
            if (firstString.Length != secondString.Length)
            {
                return false;
            }
            //Convert string to character array  
            char[] firstCharsArray = firstString.ToLower().ToCharArray();
            char[] secondCharsArray = secondString.ToLower().ToCharArray();
            //Sort array  
            Array.Sort(firstCharsArray);
            Array.Sort(secondCharsArray);
            //Check each character and position.  
            for (int i = 0; i < firstCharsArray.Length; i++)
            {
                if (firstCharsArray[i].ToString() != secondCharsArray[i].ToString())
                {
                    return false;
                }
            }
            return true;
        }
    }
}

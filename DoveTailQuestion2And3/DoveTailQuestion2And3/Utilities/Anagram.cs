
namespace DoveTailQuestion2And3.Utilities
{
    using System;
    public static class Anagram
    {
        public static bool CheckForAnagram(string firstString, string secondString)
        {
            if (!CheckForNullsAndEmpty(firstString, secondString))
            {
                return false;
            }
            var firstCharsArray = firstString.ToLower().ToCharArray();
            var secondCharsArray = secondString.ToLower().ToCharArray();
            Array.Sort(firstCharsArray);
            Array.Sort(secondCharsArray);
            for (int i = 0; i < firstCharsArray.Length; i++)
            {
                if (firstCharsArray[i].ToString() != secondCharsArray[i].ToString())
                {
                    return false;
                }
            }
            return true;
        }

        private static bool CheckForNullsAndEmpty(string firstString, string secondString)
        {
            if (string.IsNullOrEmpty(firstString) || string.IsNullOrEmpty(secondString))
            {
                return false;
            }
            if (firstString.Length != secondString.Length)
            {
                return false;
            }
            return true;
        }
    }
}

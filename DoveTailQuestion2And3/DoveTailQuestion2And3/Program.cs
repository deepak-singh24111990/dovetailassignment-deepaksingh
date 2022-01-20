

namespace DoveTailQuestion2And3
{
    using System;
    using Utilities;
    class Program
    {
        static void Main(string[] args)
        {
            //-------------For Anagram------------------------------------

            Console.Write("Enter first word of Anagram :");
            string firstWord = Console.ReadLine();
            Console.Write("Enter second word of Anagram :");
            string secondWord = Console.ReadLine();

            Anagram anagramObject = new Anagram();
            bool checkAnagram = anagramObject.CheckAnagram(firstWord, secondWord);
            Console.WriteLine(checkAnagram);

            //-----------End of Anagram-----------------------------------

            //-----------For Insert,Min,Max,Mean and Mode------------------------

            Console.Write("Please enter n-number of temp measure using comma :- ");
            string tempList = Console.ReadLine();

            TempTracker trackerObj = new TempTracker();
            var temp = trackerObj.InsertTemprature(tempList);
            if (temp.Length == 0)
            {
                Console.WriteLine("Your input {0} is invalid", tempList);
                Console.ReadKey();
            }
            Console.WriteLine("The maximum temp is :- {0} ", trackerObj.GetMaximumTemprature(temp));
            Console.WriteLine("The minimum temp is :- {0} ", trackerObj.GetMinimumTemprature(temp));
            Console.WriteLine("The mean temp is :- {0} ", trackerObj.GetMeanTemprature(temp));
            Console.WriteLine("The mode temp is :- {0} ", trackerObj.GetModeTemprature(temp));
            Console.ReadKey();

        }
    }
}

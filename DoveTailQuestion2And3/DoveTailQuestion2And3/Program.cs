namespace DoveTailQuestion2And3
{
    using System;
    using Utilities;
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first word of Anagram :");
            var firstWord = Console.ReadLine();
            Console.Write("Enter second word of Anagram :");
            var secondWord = Console.ReadLine();
            bool checkAnagram = Anagram.CheckForAnagram(firstWord, secondWord);
            Console.WriteLine(checkAnagram);
            //----------------------------------------------
            Console.Write("Please enter n-number of temp measure using comma :- ");
            var tempratures = Console.ReadLine();
            var temp = TempTracker.InsertTemprature(tempratures);
            if (temp.Length == 0)
            {
                Console.WriteLine("Your input {0} is invalid", tempratures);
                Console.ReadKey();
            }
            Console.WriteLine("The maximum temp is :- {0} ", TempTracker.GetMaximumTemprature(temp));
            Console.WriteLine("The minimum temp is :- {0} ", TempTracker.GetMinimumTemprature(temp));
            Console.WriteLine("The mean temp is :- {0} ", TempTracker.GetMeanTemprature(temp));
            Console.WriteLine("The mode temp is :- {0} ", TempTracker.GetModeTemprature(temp));
            Console.ReadKey();
        }
    }
}

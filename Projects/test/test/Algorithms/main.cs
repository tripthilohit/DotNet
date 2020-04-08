using System;

namespace test.Algo
{
    public class main
    {
        public static void Main(string[] args)
        {
            SumTwoNumbers.sumofTwoNumbers(7, 1);
            Reverse.reverseString("hello");
            Reverse.reverseWordsSentence("my name is arya");
            Reverse.reverseSentence("my name is arya");
            Reverse.reverseCharWordsInSentence(" my name is arya");
            Alternatingcharacters.alternatingCharacters("aaaa");
            FindingAinString.repeatedString("aac", 10);
            LargestSmallestWordInSentence.largestSmallestWordInSentence("My name is Tripthi");
            LargestSmallestWordInSentence.largestSmallestWordInSentence2("My name is Tripthi");
            ShortestBinaryPathToFinish.shortestBinaryPathToFinish(new int[] { 0, 0, 0 ,0, 1, 0 });
            CountingValleys.countingValleys(4, "DUDU");
        }
    }
}

using System;
using System.Collections.Generic;

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
            FindIndex.findIndex("abcdef", "cd");
            numberRepeatedSequential.numberRepeatedSeq(1555666677777);
            MostRepeatedNumber.mostRepeatedNumber(77787999029099098);
            MaximumMoneySpent.getMoneySpent(new int[] { 3, 1 }, new int[] { 5, 2, 8 }, 10);
            CatAndMouse.catAndMouse(1,3,2);
            SmallestDivisorInGivenThreshold.SmallestDivisor(new int[] { 1, 2, 5, 9 }, 6);
            UniqueString.uniqueString("abcabcabc");
            PickingMaxFromArrayDiff1orLess.pickingNumbers(new List<int> { 4, 6, 5, 3 ,3, 1 });
            deleteElementIncludingDuplicate.deleteElement(new int[] { 1, 3, 7, 4 }, 7);
            removeDupesFromArray.removeDupes(new int[] { 1, 1, 1, 7, 3, 3, 4, 5, 6 });
            mostRepeatedNumberinArray.mostRepeatedNumber(new int[] { 1, 2, 5, 3, 21, 8, 22, 21, 1, 1, 1, 1, 1 });
            palindromeString.palindrome("hello");
            nthUniqueCharacterInString.nthUniqueChar("textg", 1);
        }
    }
}

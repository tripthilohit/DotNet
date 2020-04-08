using System;
namespace test.Algo
{
    public class LargestSmallestWordInSentence
    {
       public static void largestSmallestWordInSentence(String sentence)
        {
            String[] wordsArray = sentence.Split(' ');
            String temp= null;

            for (int i = 0;i < wordsArray.Length;i++)
            {
                for (int j = i+1; j < wordsArray.Length; j++)
                {
                    if (wordsArray[i].Length > wordsArray[j].Length)
                    {
                        temp = wordsArray[i];
                        wordsArray[i] = wordsArray[j];
                        wordsArray[j] = temp;
                    }
                }
            }

            foreach(var items in wordsArray)
            {
                Console.WriteLine(items);
            }
            Console.WriteLine("Smallest word in the sentence is " + wordsArray[0]);
            Console.WriteLine("Largest word in the sentence is " + wordsArray[wordsArray.Length-1]);
        }

        public static void largestSmallestWordInSentence2(String sentence)
        {
            String[] wordsArray = sentence.Split(' ');
            String small = wordsArray[0];
            String large = wordsArray[0];
            int smallCounter = wordsArray[0].Length;
            int largeCounter = wordsArray[0].Length;
            foreach(var items in wordsArray)
            {
                if(items.Length < smallCounter)
                {
                    smallCounter = items.Length;
                    small = items;
                }

                if (items.Length > largeCounter)
                {
                    largeCounter = items.Length;
                    large = items;
                }
            }
            Console.WriteLine(" The smallest word in the sentence is " + small);
            Console.WriteLine("The largest word in the sentence is " + large);
        }

    }
   
}

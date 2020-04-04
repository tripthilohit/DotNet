using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace test.Algo
{
    public class Reverse
    {
        public static String reverseString(string stringToReverse)
        {
            String reversedString = "";
            for (int i = stringToReverse.Length - 1; i >= 0; i--)
            {
                reversedString += stringToReverse[i];

            }
            WriteLine("The reversed String is: " + reversedString);
            return reversedString;
        }

        public static void reverseWordsSentence(string sentenceToReverese)
        {
            Console.WriteLine("Original sentence " + sentenceToReverese);

            var splitSentence = sentenceToReverese.Split(' ');

            var reverseWords = splitSentence.Reverse();

            var reversedsentence = String.Join(" ", reverseWords);

            Console.WriteLine("Reverse Words in a Sentence: " + reversedsentence);
        }

        public static void reverseSentence(string sentence)
        {
            var splitSentence = sentence.Split(' ');

            var joinedSentence = String.Join("", splitSentence);

            var reversedSentence = reverseString(joinedSentence);

            Console.WriteLine("Reversed Sentence is  " + reversedSentence);

        }

        public static void reverseCharWordsInSentence(string sentence)
        {
            var splitSentence = sentence.Split(' ');
            List<String> wordsReveresed = new List<string>();
            
            foreach(String items in splitSentence)
            {

               wordsReveresed.Add(reverseString(items)); 
                
            }

                String res = String.Join(" ", wordsReveresed);
           
                Console.WriteLine("reversed char words in sentence " +res);

        }

      
    }
}



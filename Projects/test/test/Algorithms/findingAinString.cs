using System;
using System.Linq;

namespace test.Algo
{
    public class FindingAinString
    {
        public static void repeatedString(string s, int n)
        {
            int multiplier = n / s.Length;
            String sConcated = string.Concat(Enumerable.Repeat(s, multiplier+1));
            Console.WriteLine(sConcated);
         
            int count = 0;
            for (int j = 0; j < n; j++)
            {
                if (sConcated[j] == 'a')
                    count++;
            }

            Console.WriteLine(" Number of times a id present in the given string is " + count);

        }
    }
}

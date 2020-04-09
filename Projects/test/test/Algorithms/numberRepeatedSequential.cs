using System;
using System.Linq;

namespace test.Algo
{
    public class numberRepeatedSequential
    {
        public static void numberRepeatedSeq(long number)
        {
            char[] arr = number.ToString().ToArray();

            Char num = arr[0];
            int count = 1;
            int big = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    count++;
                    if (count > big)
                    {
                        big = count;
                        num = arr[i];
                    }
                }
                else
                    count = 1;
            }
            if (big == 0)
                Console.WriteLine("No numbers were repeated");
            else
                Console.WriteLine("The number repeated seq most number of times is " + num);

        }
    }
}

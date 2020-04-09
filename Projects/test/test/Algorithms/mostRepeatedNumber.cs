using System;
using System.Linq;
namespace test.Algo
{
    public class MostRepeatedNumber
    {
        public static void mostRepeatedNumber(long n)
        {
            char[] arr = n.ToString().ToArray();
            int largestCounter = 1;
            char largestNumber = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        if (count > largestCounter)
                        {
                            largestCounter = count;
                            largestNumber = arr[i];
                        }
                    }
                }

            }
            Console.WriteLine("The number repeated most number of time is:" + largestNumber);
        }
    }
}

using System;
namespace test.Algo
{
    public class mostRepeatedNumberinArray
    {
        public static void mostRepeatedNumber(int[] arr)
        {

            int mostRepNum = arr[0];
            int max = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        count++;

                }
                if (count > max)
                {
                    max = count;
                    mostRepNum = arr[i];
                }
            }

            Console.WriteLine("The most repeated Number is {0} and Number of times repeated is {1}", mostRepNum, max);
        }
    }
}

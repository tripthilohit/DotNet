/*
 * Given an array of integers, find and print the maximum number of integers you can select from the array such that the absolute difference between any two of the chosen integers is less than or equal to 1.
 * For example, if your array is , you can create two subarrays meeting the criterion:  [ 1 2 2  2]and [4 4 5 5 5] . The maximum length subarray has 5 elements.
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace test.Algo
{
    public class PickingMaxFromArrayDiff1orLess
    {
        public static void pickingNumbers(List<int> a)
        {
            int max = 0;
            a.Sort();

            for (int i = 0; i < a.Count - 2; i++)
            {
                List<int> arr = new List<int>();
                arr.Add(a[i]);
                for (int j = i + 1; j < a.Count - 1; j++)
                {
                    if (Convert.ToInt32(Math.Abs(a.ElementAt(i) - a.ElementAt(j))) <= 1)
                    {
                        arr.Add(a[j]);
                    }
                }
                if (arr.Count > max)
                    max = arr.Count;
            }
            Console.WriteLine("The maximum number of integers you can select from the array such that the absolute difference between any two of the chosen integers is less than or equal to 1 is "+max);
        }

    }
}

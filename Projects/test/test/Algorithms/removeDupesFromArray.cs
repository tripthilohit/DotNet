using System;
using System.Collections.Generic;
using System.Linq;
namespace test.Algo
{
    public class removeDupesFromArray
    {
        public static void removeDupes(int[] arr)
        {
            Array.Sort(arr);

            List<int> newArr = new List<int>();
            newArr.Add(arr[0]);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                    newArr.Add(arr[i + 1]);
            }
            Console.WriteLine("The array after removing duplicates is: ");
            foreach (var items in newArr)
                Console.WriteLine(items);

        }
    }
}

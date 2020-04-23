using System;
using System.Linq;
using System.Collections.Generic;

namespace test.Algo
{
    public class deleteElementIncludingDuplicate
    {
        public static void deleteElement(int[] arr, int ele)
        {
            List<int> newArr = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (ele != arr[i])
                {
                    newArr.Add(arr[i]);
                }

            }
            Console.WriteLine("The new Array after deleting the given element");
            foreach (var items in newArr)
            {
                Console.Write("[{0}]", string.Join(", ", items));
            }
            Console.WriteLine("\nThe Size of the new Array is " + newArr.Count);
        }

    }
}

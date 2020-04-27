using System;
using System.Linq;
using System.Collections.Generic;

namespace test.Algo
{
    public class Factors
    {
        public static void factors(int num)
        {
            List<int> arr = new List<int>();

            for (int i = 1; i <= num / 2; i++)
            {

                if (num % i == 0)
                    arr.Add(i);
            }
            Console.WriteLine("Factors of "+num+" are: ");
            foreach (var item in arr)
                Console.WriteLine(item);
        }
    }
}

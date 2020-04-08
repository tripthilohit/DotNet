using System;
//https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem
namespace test.Algo
{
    public class ShortestBinaryPathToFinish
    {
        public static void shortestBinaryPathToFinish(int[] a)
        {
            int shortestDistance = 0;
            int i = 0;
            while (i < a.Length - 1)
            {
                if (i < a.Length - 2 && a[i + 2] == 0)
                {
                    shortestDistance++;
                    i += 2;
                }
                else
                {
                    shortestDistance++;
                    i++;
                }
            }

            Console.WriteLine("The shortest Distance is " + shortestDistance);
        }
    }
  
}

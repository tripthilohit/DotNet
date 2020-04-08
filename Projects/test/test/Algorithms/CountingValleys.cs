using System;
namespace test.Algo
{
    public class CountingValleys
    {
        public static void countingValleys(int n, string s)
        {
            int counter = 0;
            int level = 0;
            Char[] path = s.ToCharArray();
            for (int i = 0; i < n; i++)
            {
                if (path[i] == 'D')
                {
                    level--;
                }
                if (path[i] == 'U')
                {
                    level++;
                }
                if (level == 0 && path[i] == 'U')
                    counter++;
            }
            Console.WriteLine("The number of valleys are " + counter);
        }
    }
}

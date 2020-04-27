using System;
using System.Collections.Generic;
using System.Linq;
namespace test.Algo
{
    public class CheckDuplicateEntry
    {
        public static void dupe(List<string> str)
        {
            bool flag = true;
            for (int i = 0; i < str.Count - 1; i++)
            {
                for (int j = i + 1; j < str.Count; j++)
                {
                    if (str[i].Equals(str[j]))
                    {
                        flag = false;
                        Console.WriteLine(str[i] + " has duplicate entry");
                    }
                }
            }
            if (flag == true)
                Console.WriteLine("No duplicates");

        }
    }
}

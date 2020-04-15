using System;
using System.Collections.Generic;
using System.Linq;

namespace test.Algo
{
    public class UniqueString
    {
        public static void uniqueString(String s)
        {
            int count = 0;
            List<string> uniqueString = new List<string>();

            for(int i=0;i<s.Length-1;i++)
            {
                for(int j=i+1;j<s.Length;j++)
                {
                    if (s[i] == s[j] && !uniqueString.Contains(s[i].ToString()))
                    {
                        uniqueString.Add(s[i].ToString());
                        Console.WriteLine(s[i]);
                    }
                        
                }
            }
     
            Console.WriteLine("The number of characters to remove to make it unique is: " + (s.Length - uniqueString.Count));
        }
       
    }
}



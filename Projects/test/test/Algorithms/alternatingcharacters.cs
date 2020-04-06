using System;
namespace test.Algo
{
    public class Alternatingcharacters
    {
        public static void alternatingCharacters(string s) 
        {
     
                int count = 0;

                for (int i = 0; i < s.Length-1; i++)
                {
                    if (s[i] == s[i + 1])
                    {
                        count++;
                    }
                }
            Console.WriteLine("Number of characters that need to be deleted to get unrepeated sequence is" + count);
            
        }
    }
}

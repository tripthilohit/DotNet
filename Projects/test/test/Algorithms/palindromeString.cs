using System;
namespace test.Algo
{
    public class palindromeString
    {
        public static void palindrome(String num)
        {
            String str = num.ToString();

            int j = 0;

            bool flag = true;

            for (int i = str.Length - 1; i > str.Length / 2; i--)
            {
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
                j++;

            }
            if (flag == true)
                Console.WriteLine("Yes, its a palindrome");
            else
                Console.WriteLine("No, its not a palindrome");

        }
    }
}
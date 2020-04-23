using System;
using System.Collections.Generic;

namespace test.Algo
{
    public class nthUniqueCharacterInString
    {
        public static void nthUniqueChar(String str, int n)
        {
            //Console.WriteLine(str.Length);
            List<String> newArr = new List<String>();
            List<String> comArr = new List<String>();
            bool flag;


            for (int i = 0; i < str.Length - 1; i++)
            {
                flag = true;
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == str[j] || comArr.Contains(str[i].ToString()))
                    {

                        flag = false;
                        comArr.Add(str[i].ToString());                       

                    }
                }
                if (flag)
                {
             
                    newArr.Add(str[i].ToString());
                }
            }

            if (!newArr.Contains(str[str.Length - 1].ToString()))
                newArr.Add(str[str.Length - 1].ToString());

       

            Console.WriteLine("The unique nth character is: " + newArr[n - 1]);

        }
    }
}

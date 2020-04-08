using System;
namespace test.Algo
{
    class FindIndex
    {
        public static void findIndex(String sentence, String sub)
        {
            int index = 0;
            bool flag = false;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == sub[0])
                {
                    int k = 1;
                    flag = true;
                    while (k < sub.Length)
                    {
                        if (sentence[i + 1] == sub[k])
                        {
                            k++;
                            i++;
                        }
                        else
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag == true)
                        index = i - (sub.Length - 1);
                }
            }
            if (flag == true)
                Console.WriteLine("Index is " + index);

        }
    }
}

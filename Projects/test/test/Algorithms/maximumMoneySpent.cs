using System;
namespace test.Algo
{
    public class MaximumMoneySpent
    {
        public static void getMoneySpent(int[] keyboards, int[] drives, int money)
        {
            int sum = 0;
            int max = 0;
            for (int i = 0; i < keyboards.Length; i++)
            {

                for (int j = 0; j < drives.Length; j++)
                {

                    if (money >= keyboards[i] + drives[j])
                    {

                        sum = keyboards[i] + drives[j];
                        if (sum > max)
                            max = sum;
                    }
                }
            }

            if (max == 0)
                Console.WriteLine("Cannot buy both with the money");
            else
                Console.WriteLine("Max money that can be spent " + max);

        }
    }
}

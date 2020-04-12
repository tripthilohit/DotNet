using System;
namespace test.Algo
{
    public class SmallestDivisorInGivenThreshold
    {
        public static void SmallestDivisor(int[] nums, int threshold)
        {

            int div = 1;
            int sum;
            do
            {
                sum = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    sum += (int)Math.Ceiling((double)nums[i] / (double)div);
                }
                div++;
            } while (sum >= threshold);
            Console.WriteLine("The smallest divisor in the threshold is: "+ (div - 1));
        }
    }
}

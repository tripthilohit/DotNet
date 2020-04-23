using System;
using System.Collections.Generic;

namespace test.Algo
{
    public class MaxDiffBetweenElements
    {
        public static void maxDiffBetweenElements(List<int> nums)
        {

            int min_num = nums[0];
            int max_diff = nums[1] - nums[0];

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] - min_num > max_diff)
                    max_diff = nums[i] - min_num;
                if (nums[i] < min_num)
                    min_num = nums[i];

            }
            Console.WriteLine("Maximun diff between elements is :" + max_diff);
        }
    }
    
}

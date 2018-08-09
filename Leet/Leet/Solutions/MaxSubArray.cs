using System;
namespace Leet
{
    public partial class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            int sum = 0, max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum > max) max = sum;
                if (sum < 0) sum = 0;
            }
            return max;
        }


      
    }
}

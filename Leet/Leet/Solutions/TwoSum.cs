using System;
using System.Collections.Generic;

namespace Leet
{
    public partial class Solution
    {
        //Given nums = [2, 7, 11, 15], target = 9,

        //Because nums[0] + nums[1] = 2 + 7 = 9,
        //return [0, 1].
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dir = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int key = target - nums[i];

                if (!dir.ContainsKey(key))
                {
                    dir[key] = i;
                }


            }

            for (int j = 1; j < nums.Length; j++)
            {

                if (dir.ContainsKey(nums[j]))
                {
                    int i = dir[nums[j]];
                    if (i != j)
                        return new int[] { i, j };

                }
            }

            return null;
        }

    }
}

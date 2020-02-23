using System;
using System.Collections.Generic;
using System.Text;

namespace leet1._136._只出现一次的数字
{
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            var result = 0;
            var sameList = new List<int>();
            var count = 0;
            if (nums.Length <= 1)
                return nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (!sameList.Contains(nums[i]))
                {
                    count = 0;
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (i != j)
                        {
                            count++;
                            if (nums[i] == nums[j])
                            {
                                sameList.Add(nums[i]);
                                break;
                            }
                            else if (nums[i] != nums[j] && count == nums.Length - 1)
                            {
                                return nums[i];
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}

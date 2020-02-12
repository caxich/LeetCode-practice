using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet1._561._数组拆分_I
{
    public class Solution
    {
        public int ArrayPairSum(int[] nums)
        {
            var list = nums.OrderBy(x => x).ToArray();
            var result = 0;
            for (int i = 0; i < nums.Length/2; i++)
            {
                result += Math.Min(list[i * 2], list[i * 2 + 1]);
            }
            return result;
        }
    }
}

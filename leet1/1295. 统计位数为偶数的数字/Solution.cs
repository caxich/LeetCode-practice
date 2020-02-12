using System;
using System.Collections.Generic;
using System.Text;

namespace leet1._1295._统计位数为偶数的数字
{
    public class Solution
    {
        public int FindNumbers(int[] nums)
        {
            var count = 0;
            foreach (var item in nums)
            {
                var s = item.ToString();
                if (s.Length % 2 == 0)
                    count++;
            }
            return count;
        }
    }
}

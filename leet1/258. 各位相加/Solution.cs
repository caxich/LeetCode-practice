using System;
using System.Collections.Generic;
using System.Text;

namespace leet1._258._各位相加
{
    public class Solution
    {
        public int AddDigits(int num)
        {
            var result = num;
            while (num > 10)
            {
                var arrs = num.ToString().ToCharArray();
                result = 0;
                for (int i = 0; i < arrs.Length; i++)
                {
                    result += int.Parse(arrs[i].ToString());
                }
                num = result;
            }
            return result;
        }
    }
}

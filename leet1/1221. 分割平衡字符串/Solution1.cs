using System;
using System.Collections.Generic;
using System.Text;

namespace leet1._1221._分割平衡字符串
{
    public class Solution1
    {
        public int BalancedStringSplit(string s)
        {
            var arr = s.ToCharArray();
            var result = 0;
            var lcount = 0;
            var rcount = 0;
            foreach (var item in arr)
            {
                if (item.Equals('L'))
                    lcount++;
                else
                    rcount++;

                if (lcount == rcount)
                {
                    lcount = rcount = 0;
                    result++;
                }
            }
            return result;
        }
    }
}

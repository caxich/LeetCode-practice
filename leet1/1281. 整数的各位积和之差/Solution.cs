using System;
using System.Collections.Generic;
using System.Text;

namespace leet1._1281._整数的各位积和之差
{
    public class Solution
    {
        public int SubtractProductAndSum(int n)
        {
            var s = n.ToString();
            var c = s.ToCharArray();
            var plusRes = 0;
            var multRes = 1;
            foreach (var item in c)
            {
                var m = int.Parse(item.ToString());
                if (m >= 0)
                {
                    plusRes += m;
                    multRes *= m;
                }

            }
            return multRes - plusRes;
        }
    }
}

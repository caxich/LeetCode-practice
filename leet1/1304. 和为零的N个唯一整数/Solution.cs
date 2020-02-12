using System;
using System.Collections.Generic;
using System.Text;

namespace leet1._1304._和为零的N个唯一整数
{
    public class Solution
    {
        public int[] SumZero(int n)
        {
            var list = new List<int>();
            for (int i = 1; i <= n / 2; i++)
            {
                list.Add(i);
                list.Add(0 - i);
            }
            if (n % 2 != 0)
            {
                list.Add(0);
            }
            return list.ToArray();
        }
    }
}

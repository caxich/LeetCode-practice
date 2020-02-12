using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet1._908._最小差值_I
{
    public class Solution
    {
        public int SmallestRangeI(int[] A, int K)
        {
            var max = A.Max();
            var min = A.Min();
            if (max - K <= min + K)
            {
                return 0;
            }
            else
            {
                return max - K - min - K;
            }
        }
    }
}

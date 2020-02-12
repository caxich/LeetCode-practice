using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet1._852._山脉数组的峰顶索引
{
    public class Solution
    {
        public int PeakIndexInMountainArray(int[] A)
        {
            return Array.IndexOf(A, A.Max());
        }
    }
}

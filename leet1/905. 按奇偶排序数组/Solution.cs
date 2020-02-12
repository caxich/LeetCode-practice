using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet1._905._按奇偶排序数组
{
    public class Solution
    {
        public int[] SortArrayByParity(int[] A)
        {
            var list = A.ToList();
            var result = new List<int>();
            result.AddRange(list.Where(x => x % 2 == 0).ToList());
            result.AddRange(list.Where(x => x % 2 != 0).ToList());
            return result.ToArray();
        }
    }
}

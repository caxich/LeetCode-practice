using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet1._977._有序数组的平方
{
    public class Solution
    {
        public int[] SortedSquares(int[] A)
        {
            var arr = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                arr[i] = A[i] * A[i];
            }
            return arr.OrderBy(x => x).ToArray();
        }
    }
}

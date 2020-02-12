using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet1._922._按奇偶排序数组_II
{
    public class Solution
    {
        public int[] SortArrayByParityII(int[] A)
        {
            var result = new int[A.Length];
            var evens = A.Where(x => x % 2 == 0).ToArray();
            var odds = A.Where(x => x % 2 != 0).ToArray();
            var eve = 0;
            var odd = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result[i] = evens[eve];
                    eve++;
                }
                else
                {
                    result[i] = odds[odd];
                    odd++;
                }
            }
            return result;
        }
    }
}

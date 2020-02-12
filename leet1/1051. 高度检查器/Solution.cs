using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet1._1051._高度检查器
{
    public class Solution
    {
        public int HeightChecker(int[] heights)
        {
            var arr = heights.OrderBy(x => x).ToArray();
            var result = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                if (arr[i] != heights[i])
                    result++;
            }
            return result;
        }
    }
}

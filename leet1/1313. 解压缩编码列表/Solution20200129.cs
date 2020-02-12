using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leet1.解压缩编码
{
    public class Solution20200129
    {
        public int[] DecompressRLElist(int[] nums)
        {
            var list = nums.ToList();
            var resultList = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (2 * i < list.Count && list[2 * i] > 0)
                {
                    for (int j = 0; j < list[2 * i]; j++)
                    {
                        resultList.Add(list[2 * i + 1]);
                    }
                }
            }
            return resultList.ToArray();
        }
    }
}

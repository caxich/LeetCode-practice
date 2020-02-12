using System;
using System.Collections.Generic;
using System.Text;

namespace leet1._349._两个数组的交集
{
    public class Solution
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            var list = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                if (list.Contains(nums1[i]))
                    continue;
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        list.Add(nums1[i]);
                        break;
                    }
                }
            }
            return list.ToArray();
        }
    }
}

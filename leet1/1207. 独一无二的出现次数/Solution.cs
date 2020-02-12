using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet1._1207._独一无二的出现次数
{
    public class Solution
    {
        public bool UniqueOccurrences(int[] arr)
        {
            var list = new List<int>();
            var sameList = new List<int>();
            var count = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (!sameList.Contains(arr[i]))
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                        }
                    }
                    sameList.Add(arr[i]);
                    list.Add(count);
                    count = 1;
                }
            }
            return list.Count() == list.Distinct().Count();
        }
    }
}

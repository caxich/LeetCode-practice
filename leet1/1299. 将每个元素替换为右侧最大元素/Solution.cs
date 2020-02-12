using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet1._1299._将每个元素替换为右侧最大元素
{
    public class Solution
    {
        public int[] ReplaceElements1(int[] arr)
        {
            var list = new List<int>();
            var arrList = arr.ToList();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i + 1 < arr.Length)
                    list.Add(arrList.GetRange(i + 1, arr.Length - i - 1).OrderBy(x => x).Last());
                if (i == arr.Length - 1)
                    list.Add(-1);
            }
            return list.ToArray();
        }

        public int[] ReplaceElements(int[] arr)
        {
            var reArr = arr.Reverse().ToList();
            var list = new List<int>
            {
                -1
            };
            for (int i = 0; i < reArr.Count() - 1; i++)
            {
                if (list[i] < reArr[i])
                    list.Add(reArr[i]);
                else
                    list.Add(list[i]);
            }
            list.Reverse();
            return list.ToArray();
        }
    }
}

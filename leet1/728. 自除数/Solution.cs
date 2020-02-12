using System;
using System.Collections.Generic;
using System.Text;

namespace leet1._728._自除数
{
    public class Solution
    {
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            var list = new List<int>();
            for (int i = 0; i <= right - left; i++)
            {
                var item = left + i;
                var arr = item.ToString().ToCharArray();
                var count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] != '0' && item % int.Parse(arr[j].ToString()) == 0)
                        count++;
                }
                if (count == arr.Length)
                    list.Add(item);
            }
            return list;
        }
    }
}

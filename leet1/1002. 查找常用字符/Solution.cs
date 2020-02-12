using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leet1._1002._查找常用字符
{
    public class Solution
    {
        public IList<string> CommonChars(string[] A)
        {
            var len = A.Length;
            var alen = A[0].Length;
            var count = 0;
            var result = new List<string>();
            for (int i = 0; i < alen; i++)
            {
                var itemCnt = result.Count(x => x == A[0][i].ToString()) + 1;
                for (int j = 1; j < len; j++)
                {
                    if (itemCnt == 1)
                    {
                        if (A[j].Contains(A[0][i]))
                        {
                            count++;
                        }
                    }
                    else if (A[j].Count(x => x == A[0][i]) >= itemCnt)
                    {
                        count++;
                    }
                    if (count == len - 1)
                    {
                        result.Add(A[0][i].ToString());
                    }
                }
                count = 0;
            }
            return result.ToArray();
        }
    }
}

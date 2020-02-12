using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet1._1047._删除字符串中的所有相邻重复项
{
    public class Solution
    {
        public string RemoveDuplicates(string S)
        {
            var i = 0;
            while (S.Length > i)
            {
                if (i + 1 < S.Length)
                {
                    if (S[i] == S[i + 1])
                    {
                        S = S.Remove(i, 2);
                        i = 0;
                        continue;
                    }
                }
                i++;
            }
            return S;
        }
    }
}

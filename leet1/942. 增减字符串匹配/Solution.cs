using System;
using System.Collections.Generic;
using System.Text;

namespace leet1._942._增减字符串匹配
{
    public class Solution
    {
        public int[] DiStringMatch(string S)
        {
            var resArr = new int[S.Length + 1];
            int dValue = 0;
            int iValue = S.Length;
            for (int i = 0; i < S.Length; i++)
            {
                resArr[i] = S[i] == 'I' ? dValue++ : iValue--;
                if (i == S.Length - 1)
                {
                    resArr[i + 1] = S[i] == 'I' ? dValue++ : iValue--;
                }
            }
            return resArr;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace leet1._821._字符的最短距离
{
    public class Solution
    {
        public int[] ShortestToChar(string S, char C)
        {
            var len = S.Length;
            var items = new List<int>();
            var result = new List<int>();
            var temp = 10000;
            for (int i = 0; i < len; i++)
            {
                if (S[i] == C)
                    items.Add(i);
            }
            for (int i = 0; i < len; i++)
            {
                if (S[i] == C)
                {
                    result.Add(0);
                }
                else
                {
                    for (int j = 0; j < items.Count; j++)
                    {
                        temp = Math.Min(Math.Abs(i - items[j]), temp);
                    }
                    result.Add(temp);
                    temp = 10000;
                }
            }
            return result.ToArray();
        }
    }
}

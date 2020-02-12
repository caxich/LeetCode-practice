using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet1._557._反转字符串中的单词_III
{
    public class Solution
    {
        public string ReverseWords(string s)
        {
            var result = new StringBuilder();
            var sa = s.Split(' ');
            for (int i = 0; i < sa.Length; i++)
            {
                var temp = sa[i].Reverse().ToArray();
                foreach (var x in temp)
                {
                    result.Append(x);
                }

                if (i < sa.Length - 1)
                    result.Append(' ');
            }
            return result.ToString();
        }
    }
}

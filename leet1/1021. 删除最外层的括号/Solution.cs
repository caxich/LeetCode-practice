using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet1._1021._删除最外层的括号
{
    public class Solution
    {
        public string RemoveOuterParentheses(string S)
        {
            var c = new StringBuilder();
            for (int i = 0; i < S.Length; i++)
            {
                if (i + 1 < S.Length)
                {
                    if (S[i].Equals('(') && S[i + 1].Equals(')'))
                    {
                        c.Append("()");
                    }
                }
            }
            return c.ToString();
        }
    }
}

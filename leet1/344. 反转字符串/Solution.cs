using System;
using System.Collections.Generic;
using System.Text;

namespace leet1._344._反转字符串
{
    public class Solution
    {
        public void ReverseString(char[] s)
        {
            char temp;
            for (int i = 0; i < s.Length / 2; i++)
            {
                temp = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = temp;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace leet1
{
    public class Solution3
    {
        public bool IsValid(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return true;
            var len = s.Length;
            if ((len % 2) != 0)
                return false;

            string[] s1 = new string[3] { "()", "{}", "[]" };
            while (!string.IsNullOrWhiteSpace(s))
            {
                if (s.Contains(s1[0]))
                    s = s.Replace(s1[0], string.Empty);
                else if (s.Contains(s1[1]))
                    s = s.Replace(s1[1], string.Empty);
                else if (s.Contains(s1[2]))
                    s = s.Replace(s1[2], string.Empty);
                else
                    return false;
            }
            return true;
        }
    }
}

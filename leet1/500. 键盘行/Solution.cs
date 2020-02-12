using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet1._500._键盘行
{
    public class Solution
    {
        public string[] FindWords(string[] words)
        {
            var result = new List<string>();
            char[] ar1 = { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p' };
            char[] ar2 = { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l' };
            char[] ar3 = { 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
            for (int i = 0; i < words.Length; i++)
            {
                var temp = words[i].ToLower().ToCharArray().Distinct();
                var len = temp.Count();
                if (ar1.Intersect(temp).Count() == len)
                {
                    result.Add(words[i]);
                    continue;
                }

                if (ar2.Intersect(temp).Count() == len)
                {
                    result.Add(words[i]);
                    continue;
                }

                if (ar3.Intersect(temp).Count() == len)
                {
                    result.Add(words[i]);
                }
            }
            return result.ToArray();
        }
    }
}
